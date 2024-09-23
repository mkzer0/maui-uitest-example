namespace BasicAppiumSample;

public partial class MainPage : ContentPage
{
    int count = 0;
    private readonly IAuthenticationService _authService;

    // Modify the constructor to accept the authentication service
    public MainPage(IAuthenticationService authService)
    {
        InitializeComponent();
        _authService = authService;

        // Fetch and display the token when the page loads
        LoadTokenAsync();
    }

    // Asynchronous method to load and display the token
    private async void LoadTokenAsync()
    {
        try
        {
            // Get the token from the authentication service
            var token = await _authService.AuthenticateAsync(); 
            
            // Display the token in the label
            TokenLabel.Text = $"Token: {token}";
        }
        catch (Exception ex)
        {
            // Handle any exceptions and display an error message
            TokenLabel.Text = $"Error retrieving token: {ex.Message}";
        }
    }

    // Your existing button click logic
    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}