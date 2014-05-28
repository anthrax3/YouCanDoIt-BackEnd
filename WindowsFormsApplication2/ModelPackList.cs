using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApplication2
{
    class ModelPackList
    {
        public static List<Pack> load(string type)
        {
            List<Hashtable> res = DBConnect.getInstance().Select("SELECT * FROM "+type);
            List<Pack> packs = new List<Pack>();
            foreach (Hashtable entry in res)
                packs.Add(new Pack((string)entry["title"], (string)entry["description"], int.Parse((string)entry["id_" + type]), Convert.ToBoolean((string)entry["is_free"]), type));
            return packs;
        }
    }
}
