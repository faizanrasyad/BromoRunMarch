using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoAirlineDesktop.Utils
{
    public class Konfirmasi
    {
        public static bool confirm()
        {
            var result = MessageBox.Show("Apakah anda yakin?", "Konfirmasi Aksi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
    }
}
