using HRMDSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDSystem.BLL
{
    public class Dictionary
    {
        public class Add
        {
            private Guid id;
            private string name;
            private string depart;
            public Add(Guid i, string un, string depa)
            {
                id = i;
                name = un;
                depart = depa;
            }
            public bool AddResult()
            {
                DictionaryService deServ = new DictionaryService();
                bool f = deServ.Add(id, name, depart);
                return f;
            }
        }

        public class Delete
        {
            private Guid Id;
            public Delete(Guid id)
            {
                Id = id;
            }
            public bool DeleteResult()
            {
                DictionaryService deServ = new DictionaryService();
                bool f = deServ.Delete(Id);
                return f;
            }
        }

        public class Update
        {
            private Guid Id;
            private string Name;
            public Update(Guid id, string name)
            {
                Id = id;
                Name = name;
            }

            public bool UpdateResult(Guid Id, string Name)
            {
                DictionaryService deServ = new DictionaryService();
                bool f = deServ.Update(Id, Name);
                if (f)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
