namespace LAB4
{
    partial class SaveLoadForm
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
            this.labelSaveInfo = new System.Windows.Forms.Label();
            this.buttonXMLSave = new System.Windows.Forms.Button();
            this.buttonBINSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSaveInfo
            // 
            this.labelSaveInfo.AutoSize = true;
            this.labelSaveInfo.Location = new System.Drawing.Point(12, 18);
            this.labelSaveInfo.Name = "labelSaveInfo";
            this.labelSaveInfo.Size = new System.Drawing.Size(16, 13);
            this.labelSaveInfo.TabIndex = 0;
            this.labelSaveInfo.Text = "...";
            // 
            // buttonXMLSave
            // 
            this.buttonXMLSave.Location = new System.Drawing.Point(12, 45);
            this.buttonXMLSave.Name = "buttonXMLSave";
            this.buttonXMLSave.Size = new System.Drawing.Size(84, 42);
            this.buttonXMLSave.TabIndex = 1;
            this.buttonXMLSave.Text = "XML";
            this.buttonXMLSave.UseVisualStyleBackColor = true;
            this.buttonXMLSave.Click += new System.EventHandler(this.buttonXMLSave_Click);
            // 
            // buttonBINSave
            // 
            this.buttonBINSave.Location = new System.Drawing.Point(102, 45);
            this.buttonBINSave.Name = "buttonBINSave";
            this.buttonBINSave.Size = new System.Drawing.Size(84, 42);
            this.buttonBINSave.TabIndex = 2;
            this.buttonBINSave.Text = "BIN";
            this.buttonBINSave.UseVisualStyleBackColor = true;
            this.buttonBINSave.Click += new System.EventHandler(this.buttonBINSave_Click);
            // 
            // SaveLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 104);
            this.Controls.Add(this.buttonBINSave);
            this.Controls.Add(this.buttonXMLSave);
            this.Controls.Add(this.labelSaveInfo);
            this.Name = "SaveLoadForm";
            this.Text = "SaveLoadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSaveInfo;
        private System.Windows.Forms.Button buttonXMLSave;
        private System.Windows.Forms.Button buttonBINSave;
    }
}