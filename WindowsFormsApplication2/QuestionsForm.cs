using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class QuestionsForm : Form
    {
        private Question innerQuestion;

        public QuestionsForm()
        {
            InitializeComponent();
            List<Pack> packs = ModelPackList.load("pack_question");
            foreach (Pack p in packs)
                comboBoxQuestions.Items.Add(p);
        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {

        }

        private void listViewQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Question> questions = ModalQuestionsList.load(((Pack)comboBoxQuestions.SelectedItem).Id);
            populateListViewQuestions(questions);
        }

        private void populateListViewQuestions(List<Question> questions)
        {
            listBoxQuestions.Items.Clear();
            foreach (Question question in questions)
                listBoxQuestions.Items.Add(question);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBoxQuestion.Text);
            innerQuestion.GetQuestion = textBoxQuestion.Text;
            innerQuestion.ReponseA = textBoxReponseA.Text;
            innerQuestion.ReponseB = textBoxReponseB.Text;
            innerQuestion.ReponseC = textBoxReponseC.Text;
            innerQuestion.ReponseD = textBoxReponseD.Text;
            innerQuestion.GoodAnswer = GoodAnswerSelected();
            if (innerQuestion.Save())
                MessageBox.Show("La question à bien été sauvegardée");
            else
                MessageBox.Show("Erreur durant la sauvegarde, veuillez tenter de nouveau");
        }

        private int GoodAnswerSelected()
        {
            if (checkBoxRA.Checked)
                return 1;
            if (checkBoxRB.Checked)
                return 2;
            if (checkBoxRC.Checked)
                return 3;
            if (checkBoxRD.Checked)
                return 4;
            return 0;
        }

        private void populateFields(Question question)
        {
            textBoxQuestion.Text = question.GetQuestion;
            textBoxReponseA.Text = question.ReponseA;
            textBoxReponseB.Text = question.ReponseB;
            textBoxReponseC.Text = question.ReponseC;
            textBoxReponseD.Text = question.ReponseD;
            checkBoxRA.Checked = (question.GoodAnswer == 1);
            checkBoxRB.Checked = (question.GoodAnswer == 2);
            checkBoxRC.Checked = (question.GoodAnswer == 3);
            checkBoxRD.Checked = (question.GoodAnswer == 4);
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            innerQuestion = (Question)listBoxQuestions.SelectedItem;
            populateFields(innerQuestion);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxQuestion.Text = "Entrez ici la question";
            textBoxReponseA.Text = textBoxReponseB.Text = textBoxReponseC.Text = textBoxReponseD.Text = "";
            checkBoxRA.Checked = checkBoxRB.Checked = checkBoxRC.Checked = checkBoxRD.Checked = false;
            innerQuestion = new Question(((Pack)comboBoxQuestions.SelectedItem).Id);
        }
    }
}
