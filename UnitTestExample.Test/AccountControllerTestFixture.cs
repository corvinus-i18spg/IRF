using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample.test
{
    class AccountControllerTestFixture
    {
        [Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            var accountController = new AccountController();

            var actualResults = accountController.ValidateEmail(email);

            Assert.AreEqual(expectedResult, actualResults);

        }


        [Test,
            TestCase("kukaK", false),
            TestCase("KUKA12", false),
            TestCase("kuka12", false),
            TestCase("1", false),
            TestCase("megFekeleo12", true)]

        public void TestPassword(string password, bool expectedResult)
        {
            var accountController = new AccountController();

            var actualResults = accountController.ValidatePassword(password);

            Assert.AreEqual(expectedResult, actualResults);

        }

        [
    Test,
    TestCase("irf@uni-corvinus.hu", "Abcd1234"),
    TestCase("irf@uni-corvinus.hu", "Abcd1234567"),
]
        public void TestRegisterHappyPath(string email, string password)
        {


            var accountServiceMock = new Mock<IAccountManager>(MockBehavior.Strict);
            accountServiceMock
                .Setup(m => m.CreateAccount(It.IsAny<Account>()))
                .Returns<Account>(a => a);
            var accountController = new AccountController();
            accountController.AccountManager = accountServiceMock.Object;


            var actualResult = accountController.Register(email, password);


            Assert.AreEqual(email, actualResult.Email);
            Assert.AreEqual(password, actualResult.Password);
            Assert.AreNotEqual(Guid.Empty, actualResult.ID);
            accountServiceMock.Verify(m => m.CreateAccount(actualResult), Times.Once);
        }

        [
    Test,
    TestCase("irf@uni-corvinus", "Abcd1234"),
    TestCase("irf.uni-corvinus.hu", "Abcd1234"),
    TestCase("irf@uni-corvinus.hu", "abcd1234"),
    TestCase("irf@uni-corvinus.hu", "ABCD1234"),
    TestCase("irf@uni-corvinus.hu", "abcdABCD"),
    TestCase("irf@uni-corvinus.hu", "Ab1234"),
]
        public void TestRegisterValidateException(string email, string password)
        {

            var accountController = new AccountController();


            try
            {
                var actualResult = accountController.Register(email, password);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ValidationException>(ex);
            }


        }
    }
}
