using NUnit.Framework;


namespace WebAddressbookTests

{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test] 
        public void LoginWithValidCredentials() //тест: вход с валидными данными
        {
            //prepare - подготовка
            app.Navigator.GoToHomePage();
            app.Auth.Logout();

			//action - действие 
			AccountData account = new AccountData("admin", "secret");
			app.Auth.Login(account);
			
			//verification - проверка
			Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }
        [Test]
        public void LoginWithInvalidCredentials() //тест: вход с невалидными данными
        {
            app.Auth.Logout();

            AccountData account = new AccountData("admin", "123456");
            app.Auth.Login(account);

            Assert.IsFalse(app.Auth.IsLoggedIn(account));
        }

    }
}
