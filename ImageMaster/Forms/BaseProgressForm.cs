﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageMaster.Forms
{
    public partial class BaseProgressForm : Form
    {
        public BaseProgressForm()
        {
            InitializeComponent();
        }

        public string FormText
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
    }
}
