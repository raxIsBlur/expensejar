import { Component, Injector, Optional, Inject, OnInit } from '@angular/core';
import {
  MAT_DIALOG_DATA,
  MatDialogRef,
  MatCheckboxChange
} from '@angular/material';
import { finalize } from 'rxjs/operators';
import * as _ from 'lodash';
import { AppComponentBase } from '@shared/app-component-base';
import { BudgetServiceProxy, BudgetDto, BudgetItemDto } from '@shared/service-proxies/service-proxies';

@Component({
  templateUrl: './create-edit-budget.component.html',
  styles: [
    `
      mat-form-field {
        width: 100%;
      }
      mat-checkbox {
        padding-bottom: 5px;
      }
    `
  ]
})

export class CreateOrEditBudgetComponent extends AppComponentBase implements OnInit {
  budget: BudgetDto = new BudgetDto();
  budgetItems: BudgetItemDto[] = [];

  constructor(
    injector: Injector,
    public _budgetService: BudgetServiceProxy,
    private _dialogRef: MatDialogRef<CreateOrEditBudgetComponent>,
    @Optional() @Inject(MAT_DIALOG_DATA) private _id: number
  ) {
    super(injector);
  }

  ngOnInit(): void {
    if(!this._id) {
      this._id = 0;
    }

    this._budgetService.getBudgetDetailAsync(this._id).subscribe(result => {
      this.budget = result;
      this.budgetItems = result.budgetItems;
    });
  }

  save(): void {
    return;
  }

  close(result: any): void {
    this._dialogRef.close(result);
  }
}

