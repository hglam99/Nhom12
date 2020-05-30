﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanlyKho_PM1.DAO;

namespace AppQuanlyKho_PM1
{
    public partial class FormUser : Form
    {
        BindingSource pList = new BindingSource();
        public FormUser()
        {
            InitializeComponent();

            LoadUser();

        }

        void LoadUser()
        {
            string query = "select * from Users";

            dtgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvUser.DataSource = pList;

            pList.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
