using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Meridian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WebInstance = webBrowser1;
            WebInstance.ScriptErrorsSuppressed = true;
        }
        bool documentCompleted = false;
        WebBrowser WebInstance;
        Account CurrentAccount = new Account();

        // body
        public HtmlElement[] bodyElements;
        
        public DateTime serverTime;
        public void Update(object sender, EventArgs args){

            if (documentCompleted)
            {
                CheckCurrentPage();
            }

            serverTime = ParseServerTime(GetAttributeInnerText("span", "serverTime", "id"));

            time.Text = "Server Time: " + serverTime.ToString("HH:mm:ss", CultureInfo.InvariantCulture);

            wood.Text = "Madeira: " +  GetAttributeInnerText("span", "wood", "id");
            stone.Text = "Argila: " + GetAttributeInnerText("span", "stone", "id");
            iron.Text = "Ferro: " + GetAttributeInnerText("span", "iron", "id");
            storage.Text = "Storage: " + GetAttributeInnerText("span", "storage", "id");

            villagers.Text = "Villagers: " + GetAttributeInnerText("span", "pop_current_label", "id") + "/" + GetAttributeInnerText("span", "pop_max_label", "id");

            //
            if (serverTime == timePicker0.Value)
            {
                SendKeys.Send("{m}");
            }

        }

        public DateTime ParseServerTime(string time) {
            try
            {
                DateTime parsedTime = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);
                return parsedTime;
            }
            catch (FormatException ex)
            {
                return DateTime.MinValue;
            }
        }

        public string GetAttributeInnerText(string tagName, string idName, string attribute) { // Place Static
           
            var pageElements = WebInstance.Document.GetElementsByTagName(tagName);
            foreach (HtmlElement element in pageElements)
            {
                if (element.GetAttribute(attribute) == idName) // id Exists
                {
                    return element.InnerText;
                }
            }
            return idName + ": Not Found";
        }

        public string GetAttributeInnerTextMatch(string tagName, string matchString)
        { // Place Static
            var pageElements = WebInstance.Document.GetElementsByTagName(tagName);
            foreach (HtmlElement element in pageElements)
            {
                // there is no identifier
                if (element.InnerText.Contains(matchString))
                {
                    return element.InnerText;
                }
                else
                {
                    return "Nothing Matches (" + matchString + "); No Identifier Found!";
                }
            }
            return matchString + ": Not Found";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Timer Refresh = new Timer();
            Refresh.Interval = (500); // 1 secs
            Refresh.Tick += new EventHandler(Update);
            Refresh.Start();

            LogMessage("Main Form Loaded");

            CurrentAccount.username = username.Text;
            CurrentAccount.password = password.Text;
            CurrentAccount.world = world.Value;
        }

        public void LogMessage(string Message) {
            logBox.Items.Insert(0, "(Local Time: " + DateTime.Now.ToString("HH:mm:ss tt") + "): " + Message);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string indexWord = "TribalWars.updateGameData";
            string js_player_info = GetAttributeInnerTextMatch("head", indexWord);

            string processedString = ReturnSelectiveRange(js_player_info, indexWord, ')');

            LogMessage(processedString);

            //string sum;
            //for (int i = 0; i < processedString.Length; i++)
            //{

            //}

            List<string> processedList;


        } 

        private void button2_Click(object sender, EventArgs e)
        {
            LogMessage("Village Number: " + test());
        }

        public void Upgrade() {
            //WebInstance.Navigate("https://pt62.tribalwars.com.pt/game.php?" + )
        }

        public string ReturnSelectiveRange(string uss, string startWord, char endChar)
        {
            int startIndex = uss.IndexOf(startWord);
            string selection = "";
            

            for (int i = startIndex + startWord.Length; i < uss.Length; i++)
            {
                if (uss[i].Equals(endChar)) // StartSeparator
                {
                    selection += uss[i]; //String Concat Char  
                    return selection;
                }
                else
                {
                    selection += uss[i]; //String Concat Char  
                }
            }
            return "-1";
        }

        public string test() {
            string text = "randomGiberish?dasd&dfas@village=14526&dasdasda";

            int startindex = text.IndexOf("village=");

            string villageNumber = " ";

            for (int i = startindex + 8; i < text.Length; i++)
            {
                if (text[i].Equals('&')) // End Separator
                {
                    return villageNumber;
                }
                else
                {
                    villageNumber += text[i]; //String Concat Char                
                }
            }
            return "-1";
        }

        public void Logout() {
            WebInstance.Navigate("https://www.tribalwars.com.pt/page/logout");
            LogMessage("Logged out!");
        }

        public void Login() {
            WebInstance.Document.GetElementById("user").SetAttribute("value", username.Text);
            WebInstance.Document.GetElementById("password").SetAttribute("value", password.Text);
            var links = WebInstance.Document.GetElementsByTagName("a");
            foreach (HtmlElement link in links)
            {
                if (link.GetAttribute("className") == "btn-login")
                {
                    link.InvokeMember("Click");
                }
            }

            LogMessage("Login Form Filled! ");
        }

        public void SelectWorld()
        {
            WebInstance.Navigate("https://www.tribalwars.com.pt/page/play/pt" + CurrentAccount.world);
            LogMessage("World Selected = " + CurrentAccount.world);
        }

        public bool LookForID(string tagName, string idName) // tagName ex: Body, Div, Paragraph etc...
        {
            var bodyElements = WebInstance.Document.GetElementsByTagName(tagName);
            foreach (HtmlElement element in bodyElements)
            {
                if (element.GetAttribute("id") == idName) // id Exists
                {
                    return true;
                }
            }
            return false;
        }
        

        public bool AccountAuthentication(Account acc) {
            if (acc.username == username.Text)
            {
                return true;
            }
            return false;
        }

        public void CheckCurrentPage() {
            var bodyElements = webBrowser1.Document.GetElementsByTagName("body");

            foreach (HtmlElement element in bodyElements)
            {
                if (LookForID("body", "home")) // HomePage
                {

                    if (element.GetAttribute("className").Contains("has-portalbar") && !element.GetAttribute("className").Contains("logged-in"))
                    {
                        LogMessage("Detected Login Form! 0");
                        Login();
                    }
                    else
                    {
                        if (element.GetAttribute("className").Contains("logged-in")) // IS LOGGED IN
                        {
                            if (AccountAuthentication(CurrentAccount))
                            {
                                LogMessage("Selecting World!");
                                SelectWorld();
                            }
                            else
                            {
                                Logout();
                            }
                        }
                    }
                    
                    LogMessage("HomePage " + "ID = " + element.GetAttribute("id"));
                }
                else
                {
                    if (element.GetAttribute("id") == "ds_body") // LoggedIn
                    {

                    }
                    else
                    {
                        LogMessage("Unknown Page, Redirecting to TribalWars HomePage in 1 secs...");
                        System.Threading.Thread.Sleep(1000);
                        WebInstance.Navigate("https://www.tribalwars.com.pt");
                    }
                }
            }
        }

        private void WebInstance_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // logged-in
            documentCompleted = true;
            CheckCurrentPage();
        }

        private void WebInstance_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            
        }
        private void WebInstance_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            documentCompleted = false;
        }
    }
}
