namespace WindowsFormsApplication2
{
    partial class QuestionsForm
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
            this.comboBoxQuestions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReponseA = new System.Windows.Forms.TextBox();
            this.textBoxReponseB = new System.Windows.Forms.TextBox();
            this.textBoxReponseC = new System.Windows.Forms.TextBox();
            this.textBoxReponseD = new System.Windows.Forms.TextBox();
            this.checkBoxRA = new System.Windows.Forms.CheckBox();
            this.checkBoxRB = new System.Windows.Forms.CheckBox();
            this.checkBoxRC = new System.Windows.Forms.CheckBox();
            this.checkBoxRD = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxQuestions
            // 
            this.comboBoxQuestions.FormattingEnabled = true;
            this.comboBoxQuestions.Location = new System.Drawing.Point(12, 41);
            this.comboBoxQuestions.Name = "comboBoxQuestions";
            this.comboBoxQuestions.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQuestions.TabIndex = 0;
            this.comboBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuestions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Packs Questions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Questions";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(466, 42);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(389, 20);
            this.textBoxQuestion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Question";
            // 
            // textBoxReponseA
            // 
            this.textBoxReponseA.Location = new System.Drawing.Point(466, 111);
            this.textBoxReponseA.Name = "textBoxReponseA";
            this.textBoxReponseA.Size = new System.Drawing.Size(218, 20);
            this.textBoxReponseA.TabIndex = 6;
            // 
            // textBoxReponseB
            // 
            this.textBoxReponseB.Location = new System.Drawing.Point(466, 137);
            this.textBoxReponseB.Name = "textBoxReponseB";
            this.textBoxReponseB.Size = new System.Drawing.Size(218, 20);
            this.textBoxReponseB.TabIndex = 7;
            // 
            // textBoxReponseC
            // 
            this.textBoxReponseC.Location = new System.Drawing.Point(466, 163);
            this.textBoxReponseC.Name = "textBoxReponseC";
            this.textBoxReponseC.Size = new System.Drawing.Size(218, 20);
            this.textBoxReponseC.TabIndex = 8;
            // 
            // textBoxReponseD
            // 
            this.textBoxReponseD.Location = new System.Drawing.Point(466, 189);
            this.textBoxReponseD.Name = "textBoxReponseD";
            this.textBoxReponseD.Size = new System.Drawing.Size(218, 20);
            this.textBoxReponseD.TabIndex = 9;
            // 
            // checkBoxRA
            // 
            this.checkBoxRA.AutoSize = true;
            this.checkBoxRA.Location = new System.Drawing.Point(690, 114);
            this.checkBoxRA.Name = "checkBoxRA";
            this.checkBoxRA.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRA.TabIndex = 10;
            this.checkBoxRA.UseVisualStyleBackColor = true;
            // 
            // checkBoxRB
            // 
            this.checkBoxRB.AutoSize = true;
            this.checkBoxRB.Location = new System.Drawing.Point(690, 140);
            this.checkBoxRB.Name = "checkBoxRB";
            this.checkBoxRB.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRB.TabIndex = 11;
            this.checkBoxRB.UseVisualStyleBackColor = true;
            // 
            // checkBoxRC
            // 
            this.checkBoxRC.AutoSize = true;
            this.checkBoxRC.Location = new System.Drawing.Point(690, 166);
            this.checkBoxRC.Name = "checkBoxRC";
            this.checkBoxRC.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRC.TabIndex = 12;
            this.checkBoxRC.UseVisualStyleBackColor = true;
            // 
            // checkBoxRD
            // 
            this.checkBoxRD.AutoSize = true;
            this.checkBoxRD.Location = new System.Drawing.Point(690, 192);
            this.checkBoxRD.Name = "checkBoxRD";
            this.checkBoxRD.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRD.TabIndex = 13;
            this.checkBoxRD.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Réponses";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(466, 215);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 23);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Sauvegarder";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(557, 215);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(85, 23);
            this.buttonNew.TabIndex = 16;
            this.buttonNew.Text = "Nouvelle";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.Location = new System.Drawing.Point(12, 110);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(375, 251);
            this.listBoxQuestions.TabIndex = 17;
            this.listBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestions_SelectedIndexChanged);
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 381);
            this.Controls.Add(this.listBoxQuestions);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxRD);
            this.Controls.Add(this.checkBoxRC);
            this.Controls.Add(this.checkBoxRB);
            this.Controls.Add(this.checkBoxRA);
            this.Controls.Add(this.textBoxReponseD);
            this.Controls.Add(this.textBoxReponseC);
            this.Controls.Add(this.textBoxReponseB);
            this.Controls.Add(this.textBoxReponseA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxQuestions);
            this.Name = "QuestionsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QuestionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReponseA;
        private System.Windows.Forms.TextBox textBoxReponseB;
        private System.Windows.Forms.TextBox textBoxReponseC;
        private System.Windows.Forms.TextBox textBoxReponseD;
        private System.Windows.Forms.CheckBox checkBoxRA;
        private System.Windows.Forms.CheckBox checkBoxRB;
        private System.Windows.Forms.CheckBox checkBoxRC;
        private System.Windows.Forms.CheckBox checkBoxRD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ListBox listBoxQuestions;
    }
}