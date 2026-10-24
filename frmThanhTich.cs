using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Game3
{
    public partial class frmThanhTich : Form
    {
        public frmThanhTich()
        {
            InitializeComponent();
        }
        private void frmThanhTich_Load(object sender, EventArgs e)
        {
              
            dgvThanhTich.ColumnCount = 5;
            dgvThanhTich.Columns[0].Name = "Hạng";
            dgvThanhTich.Columns[1].Name = "Tên Người Chơi";
            dgvThanhTich.Columns[2].Name = "Cấp Độ";
            dgvThanhTich.Columns[3].Name = "Thời Gian";
            dgvThanhTich.Columns[4].Name = "Ngày Chơi";

            dgvThanhTich.Rows.Clear();

            List<cThanhTich> dsThanhTich = cThanhTich.DocDanhSachThanhTich();

            cThanhTich.SapXepDanhSach(dsThanhTich);

            for (int i = 0; i < dsThanhTich.Count; i++)
            {
                cThanhTich tt = dsThanhTich[i];

                int phut = tt.ThoiGian / 60;
                int giay = tt.ThoiGian % 60;
                string thoiGianHienThi = $"{phut:D2}:{giay:D2}"; 

                string ngayHienThi = tt.NgayChoi.ToString("dd/MM/yyyy");

                dgvThanhTich.Rows.Add(
                    "#" + (i + 1),      
                    tt.Ten,              
                    tt.CapDo,            
                    thoiGianHienThi,     
                    ngayHienThi          
                );
            }
        }
    }
}
