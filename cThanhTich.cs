using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Game3
{
    public class cThanhTich
    {
        public string Ten { get; set; }
        public string CapDo { get; set; }
        public int ThoiGian { get; set; }
        public DateTime NgayChoi { get; set; }

        public cThanhTich(string ten, string capDo, int thoiGian, DateTime ngayChoi)
        {
            this.Ten = ten;
            this.CapDo = capDo;
            this.ThoiGian = thoiGian;
            this.NgayChoi = ngayChoi;
        }

        public cThanhTich() { }
        public string ToSaveString()
        {
            return $"{Ten}|{CapDo}|{ThoiGian}|{NgayChoi.ToString("dd/MM/yyyy HH:mm")}";
        }


        public static void GhiThanhTich(cThanhTich nguoiChoiMoi)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("thanhtichs.txt", true))
                {
                    sw.WriteLine(nguoiChoiMoi.ToSaveString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi ghi file thành tích: " + ex.Message);
            }
        }
    
    public static List<cThanhTich> DocDanhSachThanhTich()
        {
            List<cThanhTich> danhSach = new List<cThanhTich>();

            try
            {

                if (!File.Exists("thanhtichs.txt"))
                {
                    return danhSach;
                }
                using (StreamReader sr = new StreamReader("thanhtichs.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 4)
                        {
                            int thoiGian;
                            DateTime ngayChoi;

                            bool isTimeValid = int.TryParse(parts[2], out thoiGian);
                            bool isDateValid = DateTime.TryParse(parts[3], out ngayChoi);
                            if (isTimeValid && isDateValid)
                            {
                                cThanhTich tt = new cThanhTich(parts[0], parts[1], thoiGian, ngayChoi);
                                danhSach.Add(tt);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi đọc file thành tích: " + ex.Message);
            }
            return danhSach;
        }
        private static int LayTrongSoCapDo(string capDo)
        {
            string cd = capDo.ToLower().Trim();

            if (cd == "khó" || cd == "kho") return 1;
            if (cd == "trung bình" || cd == "trung binh") return 2;
            if (cd == "dễ" || cd == "de") return 3;

            return 4;
        }

        public static void SapXepDanhSach(List<cThanhTich> danhSach)
        {

            danhSach.Sort((a, b) =>
            {
                int uuTienA = LayTrongSoCapDo(a.CapDo);
                int uuTienB = LayTrongSoCapDo(b.CapDo);

                if (uuTienA != uuTienB)
                {
                    return uuTienA.CompareTo(uuTienB);
                }
                else
                {
                    return a.ThoiGian.CompareTo(b.ThoiGian);
                }
            });
        }
    }
}
    