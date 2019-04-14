import { expensejarTemplatePage } from './app.po';

describe('expensejar App', function() {
  let page: expensejarTemplatePage;

  beforeEach(() => {
    page = new expensejarTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
