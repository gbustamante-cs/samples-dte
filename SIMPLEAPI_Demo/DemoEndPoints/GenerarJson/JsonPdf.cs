﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEndPoints.GenerarJson
{
    public partial class JsonPdf : Form
    {
        public JsonPdf()
        {
            InitializeComponent();
        }

        private async void JsonPdf_Load(object sender, EventArgs e)
        {
            string res = await jsonPdf();
            txt_jsonPdf.Text = res;
        }
        public async Task<string> jsonPdf()
        {
            string url = ConfigurationManager.AppSettings["url"] + ConfigurationManager.AppSettings["JsonPdf"];
            Helper h = new Helper();
             return await h.Json(url);
        }
    }
}