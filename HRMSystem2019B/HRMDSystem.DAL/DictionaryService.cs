using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDSystem.DAL
{
    public class DictionaryService
    {
        public bool Add(Guid id, string name, string depa)
        {
            string sql = "insert into Dictionary(Id, Name, Category) values(@Id, @Name, @Category)";
            SqlParameter[] paras =
            {
                new SqlParameter("@Id", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Category", depa)
            };
            return SqlHelper.ExcuteNonQuery(sql, paras) > 0;
        }

        public bool Delete(Guid Id)
        {
            string sql = "delete from Dictionary where Id = @Id";
            SqlParameter[] paras =
            {
                new SqlParameter("@Id", Id)
            };
            return SqlHelper.ExcuteNonQuery(sql, paras) > 0;
        }

        public bool Update(Guid Id, string Name)
        {
            string sql = "update Dictionary set Name = @Name where Id = @Id";
            SqlParameter[] paras =
            {
                new SqlParameter("@Id", Id),
                new SqlParameter("@Name", Name),
            };
            return SqlHelper.ExcuteNonQuery(sql, paras) > 0;
        }
    }
}
