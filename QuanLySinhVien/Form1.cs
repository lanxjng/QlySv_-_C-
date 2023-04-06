using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        QLSV [] sv= new QLSV[100];
        int n;

        private void Add_Click(object sender, EventArgs e)
        {
            sv[n] = new QLSV(txtMasv.Text, txtHoten.Text, txtNgaysinh.Value,float.Parse(txtDk1.Text),float.Parse(txtDk2.Text));
            sv[n].show(ListView1,sv[n],n);
            txtMasv.Clear(); 
            txtHoten.Clear();
            txtDk1.Clear();
            txtDk2.Clear();
            n++;
        }

        private void ListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var itm = e.Item;
            txtMasv.Text = itm.SubItems[1].Text;
            txtHoten.Text = itm.SubItems[2].Text;
            txtDk1.Text = itm.SubItems[4].Text;
            txtDk2.Text = itm.SubItems[5].Text;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            QLSV sv1 = new QLSV(txtMasv.Text, txtHoten.Text, txtNgaysinh.Value, float.Parse(txtDk1.Text), float.Parse(txtDk2.Text));
            sv1.Update(sv,txtMasv.Text,n,sv1);
            sv1.showList(ListView1,sv,n);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            QLSV sv2 = new QLSV(txtMasv.Text, txtHoten.Text, txtNgaysinh.Value, float.Parse(txtDk1.Text), float.Parse(txtDk2.Text));
            n = sv2.Delete(sv,txtMasv.Text,n);
            sv2.showList(ListView1,sv,n);
        }
        
         
    }
}
