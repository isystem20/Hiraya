import { HirayaTemplatePage } from './app.po';

describe('Hiraya App', function() {
  let page: HirayaTemplatePage;

  beforeEach(() => {
    page = new HirayaTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
