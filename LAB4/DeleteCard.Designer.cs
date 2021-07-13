namespace LAB4
{
    partial class DeleteCard
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxPartOfSpeech = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 24);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(120, 13);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Enter the word to delete";
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDelete.Location = new System.Drawing.Point(12, 52);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(205, 30);
            this.textBoxDelete.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(131, 151);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(86, 33);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxPartOfSpeech
            // 
            this.comboBoxPartOfSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPartOfSpeech.FormattingEnabled = true;
            this.comboBoxPartOfSpeech.Items.AddRange(new object[] {
            "verb",
            "adjective",
            "noun",
            "pronoun",
            "adverb"});
            this.comboBoxPartOfSpeech.Location = new System.Drawing.Point(12, 97);
            this.comboBoxPartOfSpeech.Name = "comboBoxPartOfSpeech";
            this.comboBoxPartOfSpeech.Size = new System.Drawing.Size(205, 33);
            this.comboBoxPartOfSpeech.TabIndex = 3;
            // 
            // DeleteCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 201);
            this.Controls.Add(this.comboBoxPartOfSpeech);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxDelete);
            this.Controls.Add(this.infoLabel);
            this.Name = "DeleteCard";
            this.Text = "DeleteCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxPartOfSpeech;
    }
}