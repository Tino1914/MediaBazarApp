﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Data_Adder
{
    public partial class ProgressForm : Form
    {
        public ProgressForm(string reason)
        {
            InitializeComponent();
            lblTask.Text = reason;
        }
    }
}
