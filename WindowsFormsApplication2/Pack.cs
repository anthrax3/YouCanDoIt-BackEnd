using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApplication2
{
    class Pack
    {
        string name;
        string description;
        int id;
        bool isfree;
        string type;

        public Pack(string name, string description, int id, bool isfree, string type)
        {
            this.name = name;
            this.description = description;
            this.id = id;
            this.isfree = isfree;
            this.type = type;
        }

        public Pack(string type)
        {
            this.name = "";
            this.description = "";
            this.id = 0;
            this.isfree = true;
            this.type = type;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.description = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public bool IsFree
        {
            get
            {
                return this.isfree;
            }

            set
            {
                this.isfree = value;
            }
        }

        public override string ToString()
        {
            return this.name;
        }

        public bool Save()
        { 
            //save to database
            Hashtable vars = new Hashtable();
            vars.Add("title", name);
            vars.Add("description", description);
            vars.Add("is_free", (isfree ? "1" : "0"));
            if (this.Id != 0)
                return DBConnect.getInstance().Update(this.type, vars, "id_" + type + " = " + this.id);
            else
                return DBConnect.getInstance().Insert(this.type, vars);
        }
    }
}
