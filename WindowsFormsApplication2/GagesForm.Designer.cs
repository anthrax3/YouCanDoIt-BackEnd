namespace WindowsFormsApplication2
{
    partial class GagesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPackGages = new System.Windows.Forms.ComboBox();
            this.checkBoxMan = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.listBoxGages = new System.Windows.Forms.ListBox();
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Nouvelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Sauvegarder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Gage";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(410, 79);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(389, 20);
            this.textBoxLabel.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Gages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Packs Gages";
            // 
            // comboBoxPackGages
            // 
            this.comboBoxPackGages.FormattingEnabled = true;
            this.comboBoxPackGages.Location = new System.Drawing.Point(12, 34);
            this.comboBoxPackGages.Name = "comboBoxPackGages";
            this.comboBoxPackGages.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPackGages.TabIndex = 17;
            this.comboBoxPackGages.SelectedIndexChanged += new System.EventHandler(this.comboBoxPackGages_SelectedIndexChanged);
            // 
            // checkBoxMan
            // 
            this.checkBoxMan.AutoSize = true;
            this.checkBoxMan.Location = new System.Drawing.Point(410, 105);
            this.checkBoxMan.Name = "checkBoxMan";
            this.checkBoxMan.Size = new System.Drawing.Size(62, 17);
            this.checkBoxMan.TabIndex = 34;
            this.checkBoxMan.Text = "Homme";
            this.checkBoxMan.UseVisualStyleBackColor = true;
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Location = new System.Drawing.Point(410, 128);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(60, 17);
            this.checkBoxFemale.TabIndex = 35;
            this.checkBoxFemale.Text = "Femme";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            // 
            // listBoxGages
            // 
            this.listBoxGages.FormattingEnabled = true;
            this.listBoxGages.Location = new System.Drawing.Point(12, 108);
            this.listBoxGages.Name = "listBoxGages";
            this.listBoxGages.Size = new System.Drawing.Size(287, 199);
            this.listBoxGages.TabIndex = 36;
            this.listBoxGages.SelectedIndexChanged += new System.EventHandler(this.listBoxGages_SelectedIndexChanged);
            // 
            // numericUpDownDuration
            // 
            this.numericUpDownDuration.Location = new System.Drawing.Point(452, 153);
            this.numericUpDownDuration.Name = "numericUpDownDuration";
            this.numericUpDownDuration.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownDuration.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Durée";
            // 
            // GagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 347);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownDuration);
            this.Controls.Add(this.listBoxGages);
            this.Controls.Add(this.checkBoxFemale);
            this.Controls.Add(this.checkBoxMan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPackGages);
            this.Name = "GagesForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GagesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPackGages;
        private System.Windows.Forms.CheckBox checkBoxMan;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.ListBox listBoxGages;
        private System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private System.Windows.Forms.Label label4;
    }
}