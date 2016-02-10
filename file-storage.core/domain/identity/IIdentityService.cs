namespace FileStorage.domain.identity
{
  public interface IIdentityService
  {
        /// <summary>
    /// Authenticates user and returns it by accessing tge identity context.
    /// </summary>
    /// <param name="jwtToken"></param>
    /// <returns></returns>
     User Authenticate(string jwtToken);
  }
}