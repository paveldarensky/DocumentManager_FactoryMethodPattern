namespace FabricMethod
{
    partial class Form_main
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
            this.textBox_DocumentInfo = new System.Windows.Forms.TextBox();
            this.listView_Documents = new System.Windows.Forms.ListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_DocumentInfo
            // 
            this.textBox_DocumentInfo.BackColor = System.Drawing.Color.White;
            this.textBox_DocumentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_DocumentInfo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_DocumentInfo.Location = new System.Drawing.Point(0, 0);
            this.textBox_DocumentInfo.Multiline = true;
            this.textBox_DocumentInfo.Name = "textBox_DocumentInfo";
            this.textBox_DocumentInfo.ReadOnly = true;
            this.textBox_DocumentInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_DocumentInfo.Size = new System.Drawing.Size(625, 450);
            this.textBox_DocumentInfo.TabIndex = 1;
            this.textBox_DocumentInfo.Text = "Выберите документ...";
            // 
            // listView_Documents
            // 
            this.listView_Documents.BackColor = System.Drawing.Color.White;
            this.listView_Documents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView_Documents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Documents.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_Documents.FullRowSelect = true;
            this.listView_Documents.HideSelection = false;
            this.listView_Documents.Location = new System.Drawing.Point(0, 0);
            this.listView_Documents.MultiSelect = false;
            this.listView_Documents.Name = "listView_Documents";
            this.listView_Documents.Size = new System.Drawing.Size(171, 450);
            this.listView_Documents.TabIndex = 2;
            this.listView_Documents.UseCompatibleStateImageBehavior = false;
            this.listView_Documents.SelectedIndexChanged += new System.EventHandler(this.listView_Documents_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView_Documents);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox_DocumentInfo);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 3;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form_main";
            this.Text = "Form_main";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_DocumentInfo;
        private System.Windows.Forms.ListView listView_Documents;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

