using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ticariTakipSistemi
{
    class baglanti
    {
        public SqlConnection baglan()
        {
            SqlConnection bagla = new SqlConnection(@"Data Source=DESKTOP-D2CK8DS\SQLEXPRESS;Initial Catalog=TICARI_DBO;Integrated Security=True");
            bagla.Open();
            return bagla;
        }
    }
}
