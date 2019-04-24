import { Component, Injector, AfterViewInit } from '@angular/core';
import { MatDialog } from '@angular/material';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { BudgetServiceProxy, BudgetDto, BudgetItemDto } from '@shared/service-proxies/service-proxies';

import { CreateOrEditBudgetComponent } from './create-edit-budget/create-edit-budget.component'

@Component({
    templateUrl: './budget.component.html',
    styleUrls: [],
    animations: [appModuleAnimation()],
    // providers: [BudgetServiceProxy] // added it in the service proxy module
})

export class BudgetComponent extends AppComponentBase implements AfterViewInit {
    budgets: BudgetDto[] = [];
    budgetItems: BudgetItemDto[] = [];

    constructor(
        injector: Injector,
        private _budgetAppService: BudgetServiceProxy,
        private _dialog: MatDialog
    ) {
        super(injector);
    }

    ngAfterViewInit(): void {
        console.log('ngAfterViewInit');


        this._budgetAppService.getAllBudgets(undefined, undefined, undefined).subscribe((result) => {
            this.budgets = result;
        });

        console.log('this.budgets', this.budgets);
    }

    createUser(): void {
        this.showCreateOrEditBudget();
    }

    editUser(budget: BudgetDto): void {
        this.showCreateOrEditBudget(budget.id);
    }

    protected deleteBudget(budget: BudgetDto): void {
        abp.message.confirm(
            this.l('DeleteWarningMessage', budget.name),
            (result: boolean) => {
                if (result) {
                    this._budgetAppService.deleteBudgetAsync(budget.id).subscribe(() => {
                        abp.notify.success(this.l('SuccessfullyDeleted'));
                        // this.refresh();
                    });
                }
            }
        );
    }

    protected deleteBudgetItem(budgetItem: BudgetItemDto): void {
        abp.message.confirm(
            this.l('DeleteWarningMessage', budgetItem.categoryId, budgetItem.subCategoryId),
            (result: boolean) => {
                if (result) {
                    this._budgetAppService.deleteBudgetAsync(budgetItem.id).subscribe(() => {
                        abp.notify.success(this.l('SuccessfullyDeleted'));
                        // this.refresh();
                    });
                }
            }
        );
    }

    private showCreateOrEditBudget(id?: number): void {
        let createOrEditBudgetDialog;

        createOrEditBudgetDialog = this._dialog.open(CreateOrEditBudgetComponent, { data: id });

        // should i refresh either way?
        createOrEditBudgetDialog.afterClosed().subscribe(result => {
            return;
        });
    }
}
