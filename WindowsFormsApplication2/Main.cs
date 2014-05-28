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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PacksListForm packlist = new PacksListForm();
            packlist.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GagesForm gagesForm = new GagesForm();
            gagesForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuestionsForm questionsForm = new QuestionsForm();
            questionsForm.ShowDialog();
        }
    }
}
