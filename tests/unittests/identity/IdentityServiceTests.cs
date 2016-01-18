using System.IO;
using System.Reflection;
using NUnit.Framework;


namespace FileStorage.tests.unittests.identity
{
  [TestFixture]
  public class IdentityServiceTests
  {
    [TestCase]
    public void When_autenticate_with_user_token_expect_user_with_containing_name_returned()
    {
      var filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      //var sut = new IdentityService();
      Assert.AreEqual(3, 4);
    }
  } 
}