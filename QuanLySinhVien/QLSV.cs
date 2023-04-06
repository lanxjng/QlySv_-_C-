using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    class QLSV
    {
        private string Masv;
        private string Hoten;
        private DateTime Ns;
        private float Dk1;
        private float Dk2;
        private float DTB;

        public QLSV()
        {
        }
        public QLSV(string Masv, string Hoten, DateTime Ns, float Dk1, float Dk2) {
            this.Masv = Masv;
            this.Hoten = Hoten;
            this.Ns = Ns;
            this.Dk1 = Dk1;
            this.Dk2 = Dk2;
            DTB = (this.Dk1+ this.Dk2)/2;
        
        }
        public int Delete(QLSV []sv, string Masv, int n)
        {
            int vt = 0;
            int i;
            for (i = 0; i < n; i++)
            {
                if (sv[i].Masv.Equals(Masv))
                {
                    vt = i; break;
                }
            }
            for (i = vt; i < n - 1; i++)
            {
                sv[i] = sv[i+1];
            }
            n--;
            return n;
        }

        public void Update(QLSV []sv, string Masv,int n, QLSV sv1)
        {
            int vt = 0;
            int i ;
            for(i = 0;i<n; i++)
            {
                if (sv[i].Masv.Equals(Masv))
                {
                    vt = i; break;
                }
            }
            sv[vt] = sv1;
        }

        public void show(ListView lv, QLSV sv, int i)
        {
            lv.Items.Add((i + 1).ToString());
            lv.Items[i].SubItems.Add(sv.Masv);
            lv.Items[i].SubItems.Add(sv.Hoten);
            lv.Items[i].SubItems.Add(sv.Ns.ToString());
            lv.Items[i].SubItems.Add(sv.Dk1.ToString());
            lv.Items[i].SubItems.Add(sv.Dk2.ToString());
            lv.Items[i].SubItems.Add(sv.DTB.ToString());

        }

        public void showList(ListView lv,QLSV []sv, int n)
        {
            lv.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                show(lv, sv[i], i);
            }
        }



    }
}
