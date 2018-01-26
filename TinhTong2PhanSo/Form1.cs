using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTong2PhanSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public PhanSo ps;
        /*
         * Struct Phân Số
         */
        
        struct PhanSo
        {
            public int tu;
            public int mau;
        }

        PhanSo ps1;
        PhanSo ps2;
        
        /*
         * Hàm Nhập
         */

        private void Nhap(ref PhanSo ps1, ref PhanSo ps2)
        {
            // phan so 1

            string phanso1 = txtPhanSo1.Text;

            string[] tam1 = phanso1.Split("/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            if (tam1.Length > 1)
            {
                ps1.tu = int.Parse(tam1[0]);
                ps1.mau = int.Parse(tam1[1]);
            }

            //phan so 2

            string phanso2 = txtPhanSo2.Text;

            string[] tam2 = phanso2.Split("/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            ps2.tu = int.Parse(tam2[0]);

            ps2.mau = int.Parse(tam2[1]);
        }

        /*
         * Tính tổng
         */
        private PhanSo Cong(PhanSo ps1, PhanSo ps2)
        {

            PhanSo ketqua;

            ketqua.tu = (ps1.tu * ps2.mau) + (ps1.mau * ps2.tu);

            ketqua.mau = ps1.mau * ps2.mau;

            PhanSo kqrutgon =  RutGon(ketqua); 

            return kqrutgon;
        }
        
        /*
         * HAM UOC SO CHUNG
         */
        private int USChung(int a, int b)
        {
            int ketqua = 0;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            ketqua = a; 
            return ketqua;
        }

        /*
         * Hàm rút gon
         */

        private PhanSo RutGon(PhanSo ps1)
        {
            PhanSo ketqua;

            int uchung = USChung(ps1.tu,ps1.mau);

            ketqua.tu = ps1.tu /uchung;
            ketqua.mau = ps1.mau / uchung;

            return ketqua;
        }

        /*
         * Hàm xuất chuỗi
         */

         private string Xuat(PhanSo ps)
        {
            if(ps.tu == ps.mau)
            {
                return "1";
            }
            else
            {
                return ps.tu + "/" + ps.mau;
            }
        }

        /*
         * Ham tach chuoi
         */

        private void TachChuoi(ref PhanSo ps1, ref PhanSo ps2)
        {
            //phan so 1

            string[] a = { txtPhanSo1.Text };

            int i = 0;
            while (a[i] != "\0")
            {
                ps1.tu = int.Parse(a[i]);
                ps1.mau = int.Parse(a[i]);
                i++;
            }
        
            //phan so 2

        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            Nhap(ref ps1,ref ps2);

            PhanSo ketqua;

            ketqua = Cong(ps1, ps2);

            string final;

            final = Xuat(ketqua);

            lblKetQua.Text = final;
        }
    }
}
