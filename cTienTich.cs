using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game3
{
    public class cTienTich
    {
        public static void LoadAnhAnToan(PictureBox picBox, string duongDanAnh)
        {
            try
            {
                picBox.Image = Image.FromFile(duongDanAnh);
           
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi load ảnh tại {duongDanAnh}: {ex.Message}");
                picBox.Image = null;
            }
        }
        public static void PhatAmThanhAnToan(string duongDanAmThanh)
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer(duongDanAmThanh))
                {
                    player.Play();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi load âm thanh tại {duongDanAmThanh}: {ex.Message}");
            }
        }
    }
}