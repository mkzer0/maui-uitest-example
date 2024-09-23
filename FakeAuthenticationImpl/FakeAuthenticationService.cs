namespace BasicAppiumSample;

public class FakeAuthenticationService : IAuthenticationService
{
    public Task<string> AuthenticateAsync()
    {
        // Return a fake token
        return Task.FromResult("FakeAccessToken");
    }
}