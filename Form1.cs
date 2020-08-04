using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using CefSharp;
using CefSharp.WinForms;


namespace asistent_virtual
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
                InitializeComponent();
            meniu1.alegere = vremeUC1;
            meniu1.alegere2 = userControl11;
            userControl11.alegere = meniu1;
            userControl11.alegere2 = vremeUC1;
            vremeUC1.alegere = meniu1;
            vremeUC1.alegere2 = userControl11;

        }

       
        #region Conversii
        public static string Conversie_ora(double sec, double fus, int mod)
        {
            sec = sec + fus;
            TimeSpan ora_in_sec = TimeSpan.FromSeconds(sec);
            DateTime baza = new DateTime(1970, 1, 1);
            DateTime datetime = baza.Add(ora_in_sec);


            if (mod == 1)
            {

                return datetime.ToString("hh:mm");

            }
            else
            {

                return datetime.ToString("dd dddd");
            }

        }


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            meniu1.Visible = true;
            vremeUC1.Visible = false;
            userControl11.Visible = false;
        }

        private void vremeUC1_Load(object sender, EventArgs e)
        {

        }
    }
}

