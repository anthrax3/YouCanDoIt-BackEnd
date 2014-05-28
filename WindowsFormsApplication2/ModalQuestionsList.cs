using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApplication2
{
    class ModalQuestionsList
    {
        public static List<Question> load(int idPack)
        {
            List<Hashtable> res = DBConnect.getInstance().Select("SELECT question, answer_a, answer_b, answer_c, answer_d, good_answer, id_question, id_pack_question FROM question WHERE id_pack_question = " + idPack);
            List<Question> questions = new List<Question>();
            foreach (Hashtable entry in res)
                questions.Add(new Question(
                            (string)entry["question"],
                            (string)entry["answer_a"],
                            (string)entry["answer_b"],
                            (string)entry["answer_c"],
                            (string)entry["answer_d"],
                            int.Parse((string)entry["good_answer"]),
                            int.Parse((string)entry["id_question"]),
                            int.Parse((string)entry["id_pack_question"])
                            )
                        );
            return questions;
        }
    }
}
