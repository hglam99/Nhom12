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
    public partial class Form1 : Form
    {
        BindingSource KhoList = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            LoadKho();
        }

        void LoadKho()
        {
            string query = "select * from KhoView where [Số lượng tồn] >0";

            dtgvStorage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvStorage.DataSource = KhoList;

            KhoList.DataSource = DataProvider.Instance.ExecuteQuery(query);

            string query2 = "select sum(Quantity) from InputInfo";
            labelSumInput.Text= DataProvider.Instance.ExecuteScalar(query2).ToString();

            string query3 = "select sum(Quantity) from OutputInfo";
            labelSumOutput.Text = DataProvider.Instance.ExecuteScalar(query3).ToString();

            int sumstock = Convert.ToInt32(labelSumInput.Text) - Convert.ToInt32(labelSumOutput.Text);
            labelSumStock.Text = sumstock.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text; 

            string query = string.Format("select * from KhoView where [ID] like N'%{0}%' or [Vật tư] like N'%{1}%' or [Đơn vị] like N'%{2}%'", keyword, keyword, keyword);

            dtgvStorage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvStorage.DataSource = KhoList;

            KhoList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void đơnViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUnit f = new FormUnit();
            f.Show();
        }

        private void nhaCungCâpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplier f = new FormSupplier();
            f.Show();
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer f = new FormCustomer();
            f.Show();
        }

        private void vâtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupply f = new FormSupply();
            f.Show();
        }

        private void ngươiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser f = new FormUser();
            f.Show();
        }

        private void nhâpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInput f = new FormInput();
            f.Show();
        }

        private void xuâtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOutput f = new FormOutput();
            f.Show();
        }
    }
}
