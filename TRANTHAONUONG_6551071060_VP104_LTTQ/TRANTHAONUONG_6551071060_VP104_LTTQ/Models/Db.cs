using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace TRANTHAONUONG_6551071060_VP104_LTTQ.Models
{
    internal class Db
    {
        internal static string ConnectionString =
        @"Server=LAPTOP-QO62JG1J\SQLEXPRESS;Database=DuLieu_NhanSu;Integrated Security=True;TrustServerCertificate=True";

        internal static SqlConnection GetConnection() => new(ConnectionString);
    }
}
