﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSLVortex
{
    public partial class frmDesc : Form
    {
        public Request req;
        public Response res;


        public frmDesc()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            txtReq.Text = req.ToString();
            txtRes.Text = res.ToString();
        }

        private void txtReq_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
