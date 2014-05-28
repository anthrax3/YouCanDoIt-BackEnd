using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class ModalGagesList
    {
        public static List<Gage> load(int idPack)
        {
            List<Hashtable> res = DBConnect.getInstance().Select("SELECT label, for_sex, duration, level, id_gage, id_pack_gage FROM gage WHERE id_pack_gage = " + idPack);
            List<Gage> gages = new List<Gage>();
            foreach (Hashtable entry in res)
                gages.Add(new Gage(
                            (string)entry["label"],
                            int.Parse((string)entry["duration"]),
                            int.Parse((string)entry["for_sex"]),
                            int.Parse((string)entry["level"]),
                            int.Parse((string)entry["id_pack_gage"]),
                            int.Parse((string)entry["id_gage"])
                            )
                        );
            return gages;
        }
    }
}
