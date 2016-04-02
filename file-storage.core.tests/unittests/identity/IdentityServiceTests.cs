using log4net;
using NUnit.Framework;
using filestorage.core.application;

namespace FileStorage.core.tests.unittests.identity
{
  [NUnit.Framework.TestFixture]
  public class IdentityServiceTests
  {
    private static ILog Log = LogManager.GetLogger(typeof(IdentityServiceTests));
      
    [Test]
    [TestCase("name")]
    public void When_autenticate_with_user_token_expect_user_with_containing_name_returned(string name)
    {      
      //var filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      //var sut = new IdentityService();
      FilesService fs = new FilesService();
      Assert.IsTrue(fs.Create(name));
    }
  } 
}