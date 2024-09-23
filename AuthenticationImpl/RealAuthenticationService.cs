namespace BasicAppiumSample;

public class RealAuthenticationService : IAuthenticationService
{
    public async Task<string> AuthenticateAsync()
    {
        // Actual authentication logic
        return await Task.FromResult("RealAccessToken");
    }
}