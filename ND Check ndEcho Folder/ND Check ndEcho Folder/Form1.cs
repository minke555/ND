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
        private String authorizationCode = "";
        private String baseLoginUrl = "https://au.netdocuments.com/neWeb2/OAuth.aspx"; //https://au.netdocuments.com/neWeb2/mobile/login.aspx?ie7warn=N
        private String baseApiUrl = "https://api.au.netdocuments.com"; //https://api.eu.netdocuments.com
        private String clientID = "AP-HE7KWGHN"; // insert your own client ID here
        private String clientSecret = "fM5kFT3OoQ4cefrbnx6Y9hZ0Ga81BZ63MgpqpTVdB9lC8U9M"; // insert your own client secret here
        private String scope = "full";
        private String responseType = "code";
        private String redirectURI = "https://localhost/"; // insert your own redirectURI here.  Note that this sample will not work with some redirect URIs as it is written.
        private String accessToken = "";
        private String refreshToken = "";
    }

    }

}

