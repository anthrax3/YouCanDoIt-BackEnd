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
    public partial class PacksListForm : Form
    {
        private Pack innerPack;

        public PacksListForm()
        {
            InitializeComponent();

            List<Pack> packsG = ModelPackList.load("pack_gage");
            List<Pack> packsQ = ModelPackList.load("pack_question");

            foreach (Pack p in packsG)
                listItemGages.Items.Add(p);
            foreach (Pack p in packsQ)
                listItemQuestions.Items.Add(p);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listItemGages_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.innerPack = (Pack)listItemGages.SelectedItem;
            this.populateFields((Pack)listItemGages.SelectedItem);
        }

        private void listItemQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.innerPack = (Pack)listItemQuestions.SelectedItem;
            this.populateFields((Pack)listItemQuestions.SelectedItem);
        }

        private void populateFields(Pack pack)
        {
            textBoxTitle.Text = pack.Name;
            textBoxDescription.Text = pack.Description;
            labelId.Text = "Identifiant : " + pack.Id;
            checkBoxFree.Checked = pack.IsFree;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.innerPack.Name = textBoxTitle.Text;
            this.innerPack.Description = textBoxDescription.Text;
            this.innerPack.IsFree = checkBoxFree.Checked;
            if (this.innerPack.Save())
                MessageBox.Show("L'objet à bien été sauvegardé");
            else
                MessageBox.Show("Erreur durant la sauvegarde, veuillez tenter de nouveau");
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "Entrez le nom du pack de gages";
            textBoxDescription.Text = "";
            checkBoxFree.Checked = false;
            innerPack = new Pack("pack_gage");
        }

        private void buttonNewPQ_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "Entrez le nom du pack de questions";
            textBoxDescription.Text = "";
            checkBoxFree.Checked = false;
            innerPack = new Pack("pack_question");
        }
    }
}
