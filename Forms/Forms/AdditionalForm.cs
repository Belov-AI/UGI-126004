﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class AdditionalForm : Form
    {
        public AdditionalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new OwnedForm();
            AddOwnedForm(form);
            //form.Owner = this;
            form.Show();
        }
    }
}
