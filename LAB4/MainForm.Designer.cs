namespace LAB4
{
    partial class MainForm
    {
        
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonSpectate = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(20, 10);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 40);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add word";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.AddWord);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(20, 64);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(108, 40);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "Delete word";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonSpectate
            // 
            this.buttonSpectate.Location = new System.Drawing.Point(20, 117);
            this.buttonSpectate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSpectate.Name = "buttonSpectate";
            this.buttonSpectate.Size = new System.Drawing.Size(108, 40);
            this.buttonSpectate.TabIndex = 2;
            this.buttonSpectate.Text = "Learn words";
            this.buttonSpectate.UseVisualStyleBackColor = true;
            this.buttonSpectate.Click += new System.EventHandler(this.buttonSpectate_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Location = new System.Drawing.Point(20, 172);
            this.buttonStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(108, 40);
            this.buttonStatistics.TabIndex = 3;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(20, 226);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(108, 40);
            this.buttonTest.TabIndex = 4;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(235, 10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 40);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save dictionary";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(334, 10);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(93, 40);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load dictionary";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 298);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.buttonSpectate);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "It is never too late to learn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonSpectate;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
    }
}

