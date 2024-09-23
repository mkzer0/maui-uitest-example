namespace BasicAppiumSample;

public partial class App : Application
{
    // Use the service provider to resolve the MainPage
    public App(IServiceProvider serviceProvider)
    {
        InitializeComponent();

        // Resolve MainPage from the service provider
        MainPage = serviceProvider.GetRequiredService<MainPage>();
    }
}