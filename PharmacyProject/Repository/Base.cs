using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class Base
    {
        public static IEnumerable<T> Read<T>(string procedure)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=database;User ID=user;Password=password"))
            {
                var value = con.Query<T>(procedure, commandType: CommandType.StoredProcedure);

                return value;
            }
        }

        public static IEnumerable<T> ReadById<T>(string procedure, object args)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=database;User ID=user;Password=password"))
            {
                var value = con.Query<T>(procedure, args, commandType: CommandType.StoredProcedure);

                return value;
            }
        }

        public static T Insert<T>(string procedure, object args)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=database;User ID=user;Password=password"))
            {
                var value = con.ExecuteScalar<T>(procedure, args, commandType: CommandType.StoredProcedure);

                return value;
            }
        }

        public static T Delete<T>(string procedure, object args)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=database;User ID=user;Password=password"))
            {
                var value = con.ExecuteScalar<T>(procedure, args, commandType: CommandType.StoredProcedure);

                return value;
            }
        }
    }
}
