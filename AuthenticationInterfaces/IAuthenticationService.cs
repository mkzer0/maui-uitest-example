namespace BasicAppiumSample;

public interface IAuthenticationService
{
    Task<string> AuthenticateAsync();
}