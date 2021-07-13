namespace LAB4
{
    partial class AddWord
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
            this.textBoxNewWord = new System.Windows.Forms.TextBox();
            this.textBoxMeanings = new System.Windows.Forms.TextBox();
            this.buttonAddToDictionary = new System.Windows.Forms.Button();
            this.labelTabInstruction = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.comboBoxPartOfSpeech = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNewWord
            // 
            this.textBoxNewWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewWord.Location = new System.Drawing.Point(40, 39);
            this.textBoxNewWord.Name = "textBoxNewWord";
            this.textBoxNewWord.Size = new System.Drawing.Size(195, 30);
            this.textBoxNewWord.TabIndex = 0;
            this.textBoxNewWord.Text = "Enter new word";
            // 
            // textBoxMeanings
            // 
            this.textBoxMeanings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMeanings.Location = new System.Drawing.Point(40, 104);
            this.textBoxMeanings.Name = "textBoxMeanings";
            this.textBoxMeanings.Size = new System.Drawing.Size(395, 30);
            this.textBoxMeanings.TabIndex = 1;
            this.textBoxMeanings.Text = "Enter meaning";
            // 
            // buttonAddToDictionary
            // 
            this.buttonAddToDictionary.Location = new System.Drawing.Point(111, 155);
            this.buttonAddToDictionary.Name = "buttonAddToDictionary";
            this.buttonAddToDictionary.Size = new System.Drawing.Size(248, 33);
            this.buttonAddToDictionary.TabIndex = 2;
            this.buttonAddToDictionary.Text = "Add to dictionary";
            this.buttonAddToDictionary.UseVisualStyleBackColor = true;
            this.buttonAddToDictionary.Click += new System.EventHandler(this.buttonAddToDictionary_Click);
            // 
            // labelTabInstruction
            // 
            this.labelTabInstruction.AutoSize = true;
            this.labelTabInstruction.Location = new System.Drawing.Point(37, 232);
            this.labelTabInstruction.Name = "labelTabInstruction";
            this.labelTabInstruction.Size = new System.Drawing.Size(242, 13);
            this.labelTabInstruction.TabIndex = 3;
            this.labelTabInstruction.Text = "Use tab to toggle between text boxes and buttons";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(37, 215);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(75, 13);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "Add new word";
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
            this.comboBoxPartOfSpeech.Location = new System.Drawing.Point(279, 39);
            this.comboBoxPartOfSpeech.Name = "comboBoxPartOfSpeech";
            this.comboBoxPartOfSpeech.Size = new System.Drawing.Size(156, 33);
            this.comboBoxPartOfSpeech.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Part of speech";
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPartOfSpeech);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.labelTabInstruction);
            this.Controls.Add(this.buttonAddToDictionary);
            this.Controls.Add(this.textBoxMeanings);
            this.Controls.Add(this.textBoxNewWord);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddWord";
            this.Text = "AddWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewWord;
        private System.Windows.Forms.TextBox textBoxMeanings;
        private System.Windows.Forms.Button buttonAddToDictionary;
        private System.Windows.Forms.Label labelTabInstruction;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ComboBox comboBoxPartOfSpeech;
        private System.Windows.Forms.Label label1;
    }
}