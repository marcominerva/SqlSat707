using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindData
{
    public static class Northwind
    {
        public static DataTable LoadEmployeesFromDatabase()
        {
            using (var conn = new SqlConnection(""))
            {
                var query = "SELECT EmployeeID, LastName, FirstName, Title, LastName + ' ' + FirstName + ', ' + Title AS TitleFullName, " +
                            "BirthDate, HireDate FROM dbo.Employees ORDER BY LastName, FirstName";

                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    using (var da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;

                        var ds = new DataSet();
                        da.Fill(ds);

                        return ds.Tables[0];
                    }
                }
            }
        }
    }
}
