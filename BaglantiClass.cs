using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OtoparkAppV1._0
{
    public class BaglantiClass
    {
     public SqlConnection con()
        {
            SqlConnection con = new SqlConnection("Data Source = CIHAD-ASUS\\CIHAD; Initial Catalog = otoparkdb; Integrated Security = True");
            con.Open();
            return con;
        }
    }
}
