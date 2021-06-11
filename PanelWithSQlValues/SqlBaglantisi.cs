using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PanelWithSQlValues
{
    public class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=GoruntuIsleme; Integrated security=True;");
            SqlConnection.Open();
            return SqlConnection;
        }
    }
}
