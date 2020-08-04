using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using CefSharp;
using CefSharp.WinForms;



namespace asistent_virtual
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            
            

        }

        List<string> coddd = new List<string>();

        

        static string html1 = "google.ro";
        string rezultat = string.Empty;
        string adresa_baza = "https://youtu.be/";
        public dynamic alegere { get; set; }
        public dynamic alegere2 { get; set; }


        static private ChromiumWebBrowser Verificare()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                dynamic browser = new ChromiumWebBrowser(html1);
                return browser;
            }
            return null;
        }
        static ChromiumWebBrowser aux = Verificare();

        private void button4_Click(object sender, EventArgs e)
    {
        if (textBox1.Text == string.Empty)
        {
            label30.Text = "nu merge";

        }
        else
        {
            try
            {
                Run(textBox1.Text);
            }
            catch (AggregateException ex)
            {
                foreach (var m in ex.InnerExceptions)
                {
                    Console.WriteLine("Error: " + m.Message);
                }
            }



        }

    }
    private async Task Run(string cautare)
    {
        coddd.Clear();

        var youtubeService = new YouTubeService(new BaseClientService.Initializer()
        {
            ApiKey = "", //API pentru youtube
            ApplicationName = this.GetType().ToString()
        });

        var searchListRequest = youtubeService.Search.List("snippet");
        searchListRequest.Q = cautare; 
        searchListRequest.MaxResults = 4;


        var searchListResponse = await searchListRequest.ExecuteAsync();

        List<string> videos = new List<string>();
        List<string> channels = new List<string>();
        List<string> playlists = new List<string>();
        

        List<Label> rez = new List<Label> { label30, label31, label32 };

        int it;
        it = 0;
        foreach (var searchResult in searchListResponse.Items)
        {
            switch (searchResult.Id.Kind)
            {
                case "youtube#video":
                    videos.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.VideoId));
                    rez[it].Text = searchResult.Snippet.Title;
                    coddd.Add(searchResult.Id.VideoId);
                    it++;
                    break;
            }
        }

        


    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.Visible = false;
        alegere.Visible = true;
    }


    private void label30_Click(object sender, EventArgs e)
    {
        if (label30.Text == "...")
        {
            return;
        }

        rezultat = adresa_baza + coddd[0];
        
        aux.Load(rezultat);




    }


    private void label31_Click(object sender, EventArgs e)
    {
        if (label31.Text == "...")
        {
            return;
        }

        rezultat = adresa_baza + coddd[1];
        
        aux.Load(rezultat);

    }

    private void label32_Click(object sender, EventArgs e)
    {
        if (label32.Text == "...")
        {
            return;
        }


        rezultat = adresa_baza + coddd[2];
        aux.Load(rezultat);


    }
        
        public void UserControl1_Load(object sender, EventArgs e)
        {
            
            if (aux != null)
            {
                panel1.Controls.Add(aux);
            }
        
        
        }

    }
}
