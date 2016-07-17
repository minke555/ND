using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ND_Check_ndEcho_Folder
{
    public partial class Form1 : Form
    {

        public String authorizationCode = "";
        public String baseLoginUrl = "https://au.netdocuments.com/neWeb2/OAuth.aspx";
        public String baseApiUrl = "https://api.au.netdocuments.com";
        public String clientID = "AP-HE7KWGHN"; // insert your own client ID here
        public String clientSecret = "fM5kFT3OoQ4cefrbnx6Y9hZ0Ga81BZ63MgpqpTVdB9lC8U9M"; // insert your own client secret here
        public String scope = "full";
        public String responseType = "code";
        public String redirectURI = "https://localhost/"; // insert your own redirectURI here.  Note that this sample will not work with some redirect URIs as it is written.
        public String accessToken = "";
        public String refreshToken = "";
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Get registry Key for where to search for documents
            RegistryKey ndKey = Registry.CurrentUser.OpenSubKey(@"Software\NetVoyage\NetDocuments", false);
            String ndEchoFolder = (String)ndKey.GetValue("EchoingFolderPath");
            txtndEchoPath.Text = ndEchoFolder;
            // Now lets attempt to connect to ND
        

    }

    }

}

