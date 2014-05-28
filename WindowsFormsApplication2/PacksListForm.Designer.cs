namespace WindowsFormsApplication2
{
    partial class PacksListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listItemGages = new System.Windows.Forms.ComboBox();
            this.listItemQuestions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.checkBoxFree = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonNewPQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listes des packs";
            // 
            // listItemGages
            // 
            this.listItemGages.FormattingEnabled = true;
            this.listItemGages.Location = new System.Drawing.Point(44, 83);
            this.listItemGages.Name = "listItemGages";
            this.listItemGages.Size = new System.Drawing.Size(121, 21);
            this.listItemGages.TabIndex = 1;
            this.listItemGages.SelectedIndexChanged += new System.EventHandler(this.listItemGages_SelectedIndexChanged);
            // 
            // listItemQuestions
            // 
            this.listItemQuestions.FormattingEnabled = true;
            this.listItemQuestions.Location = new System.Drawing.Point(171, 83);
            this.listItemQuestions.Name = "listItemQuestions";
            this.listItemQuestions.Size = new System.Drawing.Size(121, 21);
            this.listItemQuestions.TabIndex = 2;
            this.listItemQuestions.SelectedIndexChanged += new System.EventHandler(this.listItemQuestions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Questions";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(44, 204);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(171, 20);
            this.textBoxTitle.TabIndex = 5;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(44, 230);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(248, 20);
            this.textBoxDescription.TabIndex = 6;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(44, 185);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(76, 13);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "Identifiant : XX";
            // 
            // checkBoxFree
            // 
            this.checkBoxFree.AutoSize = true;
            this.checkBoxFree.Location = new System.Drawing.Point(47, 256);
            this.checkBoxFree.Name = "checkBoxFree";
            this.checkBoxFree.Size = new System.Drawing.Size(57, 17);
            this.checkBoxFree.TabIndex = 8;
            this.checkBoxFree.Text = "Gratuit";
            this.checkBoxFree.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sauvegarder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(47, 309);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(81, 67);
            this.buttonNew.TabIndex = 10;
            this.buttonNew.Text = "Nouveau Pack Gages";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonNewPQ
            // 
            this.buttonNewPQ.Location = new System.Drawing.Point(211, 309);
            this.buttonNewPQ.Name = "buttonNewPQ";
            this.buttonNewPQ.Size = new System.Drawing.Size(81, 67);
            this.buttonNewPQ.TabIndex = 11;
            this.buttonNewPQ.Text = "Nouveau Pack Questions";
            this.buttonNewPQ.UseVisualStyleBackColor = true;
            this.buttonNewPQ.Click += new System.EventHandler(this.buttonNewPQ_Click);
            // 
            // PacksListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 407);
            this.Controls.Add(this.buttonNewPQ);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxFree);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listItemQuestions);
            this.Controls.Add(this.listItemGages);
            this.Controls.Add(this.label1);
            this.Name = "PacksListForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listItemGages;
        private System.Windows.Forms.ComboBox listItemQuestions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.CheckBox checkBoxFree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonNewPQ;
    }
}