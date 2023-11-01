using SAERushBook.Controllers;

namespace TestSAERushBook;

[TestClass]
public class UserTests
{
    [TestMethod]
    public void testUserConstructor()
    {
        string username = "Trey";
        string password = "password";
        string email = "test@test.com";


        User user = new User(username, password, email);

        Assert.AreEqual(username, user.getUsername());
        Assert.AreEqual(password, user.getPassword());
        Assert.AreEqual(email, user.getEmail());

    }
}