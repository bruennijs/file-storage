
using System;

namespace FileStorage.domain.identity
{
  /// <summary>
  /// 
  /// </summary>
  public class IdentityService : IIdentityService
  {
    /// <summary>
    /// Authenticates user and returns it by accessing tge identity context.
    /// </summary>
    /// <param name="jwtToken"></param>
    /// <returns></returns>
    public User Authenticate(string jwtToken)
    {
      throw new NotImplementedException("test");
    }
  }
}