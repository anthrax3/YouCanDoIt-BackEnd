using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApplication2
{
    class Gage
    {
        string label;
        int duration;
        int forSex;
        int level;
        int id;
        int idInnerPack;

        public Gage(string label, int duration, int forSex, int level, int idpack, int id)
        {
            this.label = label;
            this.duration = duration;
            this.forSex = forSex;
            this.level = level;
            this.id = id;
            idInnerPack = idpack;
        }

        public Gage(int idpack)
        {
            label = "";
            duration = 4;
            forSex = 2;
            level = 0;
            id = 0;
            idInnerPack = idpack;
        }

        public Gage(string label, int duration, int forSex, int level, int idpack)
        {
            this.label = label;
            this.duration = duration;
            this.forSex = forSex;
            this.level = level;
            id = 0;
            idInnerPack = idpack;
        }

        public string Label
        {
            get { return label; }
            set { label = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public int ForSex
        {
            get { return forSex; }
            set { forSex = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdInnerPack
        {
            get { return idInnerPack; }
            set { idInnerPack = value; }
        }

        public bool Save()
        {
            //save to database
            Hashtable vars = new Hashtable();
            vars.Add("label", label);
            vars.Add("duration", duration);
            vars.Add("for_sex", forSex);
            vars.Add("id_pack_gage", idInnerPack);
            if(level != 0)
                vars.Add("level", level);
            if(id != 0)
                return DBConnect.getInstance().Update("gage", vars, "id_gage" + " = " + id);
            return DBConnect.getInstance().Insert("gage", vars);
        }

        public override string ToString()
        {
            return label;
        }
    }
}
