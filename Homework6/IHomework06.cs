public interface IHomework06
{
    string DisplayLEDOnScreen(string ledNo);
    string LoadState();
    void SaveCurrentState();
    void SetAppConfigurations(string onSymbol, string offSymbol, int spacing);
}