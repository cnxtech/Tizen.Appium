using NUnit.Framework;

namespace Appium.UITests
{
    [TestFixture]
    public class StepperTest1 : TestTemplate
    {
        [Test]
        public void IncreaseTest()
        {
            var btnId = "button1";

            Driver.Click(btnId);

            var image = "StepperTest1_increase.png";
            //WebElementUtils.GetScreenshotAndSave(Driver, image);
            Assert.AreEqual(true, Driver.CompareToScreenshot(image));
        }

        [Test]
        public void DecreaseTest()
        {
            var inBtnId = "button1";
            var deBtnId = "button2";

            Driver.Click(inBtnId);
            Driver.Click(inBtnId);

            Driver.Click(deBtnId);

            var image = "StepperTest1_decrease.png";
            //WebElementUtils.GetScreenshotAndSave(Driver, image);
            Assert.AreEqual(true, Driver.CompareToScreenshot(image));
        }
    }
}
