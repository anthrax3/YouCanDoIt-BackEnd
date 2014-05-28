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
    public partial class GagesForm : Form
    {
        private Gage innerGage;

        public GagesForm()
        {
            InitializeComponent();
            List<Pack> packs = ModelPackList.load("pack_gage");
            foreach (Pack p in packs)
                comboBoxPackGages.Items.Add(p);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GagesForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxPackGages_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Gage> gages = ModalGagesList.load(((Pack)comboBoxPackGages.SelectedItem).Id);
            populateListViewGages(gages);
        }

        private void populateListViewGages(List<Gage> gages)
        {
            listBoxGages.Items.Clear();
            foreach (Gage gage in gages)
                listBoxGages.Items.Add(gage);
        }

        private void populateFields(Gage gage)
        {
            textBoxLabel.Text = gage.Label;
            checkBoxFemale.Checked = (gage.ForSex == 0 || gage.ForSex == 2);
            checkBoxMan.Checked = (gage.ForSex == 1 || gage.ForSex == 2);
            numericUpDownDuration.Value = innerGage.Duration;
        }

        private void listBoxGages_SelectedIndexChanged(object sender, EventArgs e)
        {
            innerGage = (Gage)listBoxGages.SelectedItem;
            populateFields(innerGage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            innerGage.Label = textBoxLabel.Text;
            if (checkBoxFemale.Checked && checkBoxMan.Checked)
                innerGage.ForSex = 2;
            else if (checkBoxMan.Checked)
                innerGage.ForSex = 1;
            else if (checkBoxFemale.Checked)
                innerGage.ForSex = 0;
            innerGage.Duration = (int)numericUpDownDuration.Value;
            if (innerGage.Save())
                MessageBox.Show("Le gage à bien été sauvegardé");
            else
                MessageBox.Show("Erreur durant la sauvegarde, veuillez tenter de nouveau");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxLabel.Text = "Entrez ici le gage";
            checkBoxFemale.Checked = true;
            checkBoxMan.Checked = true;
            numericUpDownDuration.Value = 4;
            innerGage = new Gage(((Pack)comboBoxPackGages.SelectedItem).Id);
        }
    }
}
