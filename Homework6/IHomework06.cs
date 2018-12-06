public interface IHomework06
{
    string DisplayLEDOnScreen(string ledNo);
    bool[] LoadState();
    void SaveCurrentState();
    void SetAppConfigurations(string onSymbol, string offSymbol, int spacing);
}