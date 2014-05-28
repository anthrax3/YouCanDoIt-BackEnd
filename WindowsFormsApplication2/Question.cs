using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Question
    {
        private string question;
        private string reponseA;
        private string reponseB;
        private string reponseC;
        private string reponseD;
        private int goodAnswer;
        private int id;
        private int idInnerPack;

        public Question(string question, string reponseA, string reponseB, string reponseC, string reponseD, int goodAnswer, int id, int idInnerPack)
        {
            this.question = question;
            this.reponseA = reponseA;
            this.reponseB = reponseB;
            this.reponseC = reponseC;
            this.reponseD = reponseD;
            this.goodAnswer = goodAnswer;
            this.id = id;
            this.idInnerPack = idInnerPack;
        }

        public Question(string question, string reponseA, string reponseB, string reponseC, string reponseD, int goodAnswer, int idInnerPack)
        {
            this.question = question;
            this.reponseA = reponseA;
            this.reponseB = reponseB;
            this.reponseC = reponseC;
            this.reponseD = reponseD;
            this.goodAnswer = goodAnswer;
            id = 0;
            this.idInnerPack = idInnerPack;
        }

        public Question(int idInnerPack)
        {
            question = "";
            reponseA = "";
            reponseB = "";
            reponseC = "";
            reponseD = "";
            goodAnswer = 0;
            id = 0;
            this.idInnerPack = idInnerPack;
        }

        public string GetQuestion
        {
            get { return question; }
            set { question = value; }
        }

        public string ReponseA
        {
            get { return reponseA; }
            set { reponseA = value; }
        }

        public string ReponseB
        {
            get { return reponseB; }
            set { reponseB = value; }
        }

        public string ReponseC
        {
            get { return reponseC; }
            set { reponseC = value; }
        }

        public string ReponseD
        {
            get { return reponseD; }
            set { reponseD = value; }
        }

        public int GoodAnswer
        {
            get { return goodAnswer; }
            set { goodAnswer = value; }
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
            vars.Add("question", question);
            vars.Add("answer_a", reponseA);
            vars.Add("answer_b", reponseB);
            vars.Add("answer_c", reponseC);
            vars.Add("answer_d", reponseD);
            vars.Add("good_answer", goodAnswer);
            vars.Add("id_pack_question", idInnerPack);
            if (id != 0)
                return DBConnect.getInstance().Update("question", vars, "id_question" + " = " + id);
            return DBConnect.getInstance().Insert("question", vars);
        }

        public override string ToString()
        {
            return question;
        }
    }
}
