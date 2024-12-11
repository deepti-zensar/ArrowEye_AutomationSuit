using OpenQA.Selenium.Support.PageObjects;
using ArrowEye_ClientPortal_Automation.Common;
using OpenQA.Selenium;
using System.Threading;

namespace ArrowEye_ClientPortal_Automation.PageRepository
{
    public class CP_HomePage
    {
        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-9l3uo3']")]
        public IWebElement homePageTitle;

        //[FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-1051h91']")]
        //[FindsBy(How = How.XPath, Using = "//*[contains(@class,'MuiTypography-root MuiTypography-body1 css-1051h91') and contains(text(),'CLIENT GALLERY')]")]
        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-1051h91' and contains(text(),'CLIENT GALLERY') and @data-testid='secondNested']")]
        public IWebElement clientGallery;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-18ahme0' and contains(text(),'EMV')]")]
        public IWebElement emv;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-9l3uo3' and contains(text(),'Issuers')]")]
        public IWebElement issuers;
        
        public void ValidateHomePageTitle()
        {
            //DriverUtil.WaitForElementVisible(By.XPath(
            //"//p[@class='MuiTypography-root MuiTypography-body1 css-9l3uo3']"));
        }

        public void NavigateToIssuers()
        {
            Browser.Click(clientGallery);
            Browser.Click(emv);
            Browser.Click(issuers);
        }


    }
}
