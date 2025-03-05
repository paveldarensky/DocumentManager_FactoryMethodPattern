namespace WithoutFabricMethod
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView_Documents = new System.Windows.Forms.ListView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Create_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Letter_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Order_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BusinessTripOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Inputs = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_OwnFields = new System.Windows.Forms.TableLayoutPanel();
            this.button_SaveDocument = new System.Windows.Forms.Button();
            this.tableLayoutPanel_DocumentForm = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Content = new System.Windows.Forms.TextBox();
            this.textBox_DateTimeCreateDocument = new System.Windows.Forms.TextBox();
            this.label_DocNum = new System.Windows.Forms.Label();
            this.label_DateTimeCreateDocument = new System.Windows.Forms.Label();
            this.label_Content = new System.Windows.Forms.Label();
            this.textBox_DocNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel_Inputs.SuspendLayout();
            this.tableLayoutPanel_DocumentForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_DocumentInfo
            // 
            this.textBox_DocumentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_DocumentInfo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_DocumentInfo.Location = new System.Drawing.Point(0, 0);
            this.textBox_DocumentInfo.Multiline = true;
            this.textBox_DocumentInfo.Name = "textBox_DocumentInfo";
            this.textBox_DocumentInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_DocumentInfo.Size = new System.Drawing.Size(610, 761);
            this.textBox_DocumentInfo.TabIndex = 1;
            this.textBox_DocumentInfo.Text = "Выберите документ...";
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
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_Inputs);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_DocumentInfo);
            this.splitContainer1.Size = new System.Drawing.Size(784, 761);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 2;
            // 
            // listView_Documents
            // 
            this.listView_Documents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView_Documents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Documents.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_Documents.HideSelection = false;
            this.listView_Documents.Location = new System.Drawing.Point(0, 27);
            this.listView_Documents.Name = "listView_Documents";
            this.listView_Documents.Size = new System.Drawing.Size(170, 734);
            this.listView_Documents.TabIndex = 0;
            this.listView_Documents.UseCompatibleStateImageBehavior = false;
            this.listView_Documents.SelectedIndexChanged += new System.EventHandler(this.listView_Documents_SelectedIndexChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create_ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(170, 27);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Create_ToolStripMenuItem
            // 
            this.Create_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Letter_ToolStripMenuItem,
            this.Order_ToolStripMenuItem,
            this.BusinessTripOrderToolStripMenuItem});
            this.Create_ToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create_ToolStripMenuItem.Name = "Create_ToolStripMenuItem";
            this.Create_ToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.Create_ToolStripMenuItem.Text = "Создать";
            // 
            // Letter_ToolStripMenuItem
            // 
            this.Letter_ToolStripMenuItem.Name = "Letter_ToolStripMenuItem";
            this.Letter_ToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.Letter_ToolStripMenuItem.Text = "Письмо";
            this.Letter_ToolStripMenuItem.Click += new System.EventHandler(this.Letter_ToolStripMenuItem_Click);
            // 
            // Order_ToolStripMenuItem
            // 
            this.Order_ToolStripMenuItem.Name = "Order_ToolStripMenuItem";
            this.Order_ToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.Order_ToolStripMenuItem.Text = "Приказ";
            this.Order_ToolStripMenuItem.Click += new System.EventHandler(this.Order_ToolStripMenuItem_Click);
            // 
            // BusinessTripOrderToolStripMenuItem
            // 
            this.BusinessTripOrderToolStripMenuItem.Name = "BusinessTripOrderToolStripMenuItem";
            this.BusinessTripOrderToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.BusinessTripOrderToolStripMenuItem.Text = "Распоряжение";
            this.BusinessTripOrderToolStripMenuItem.Click += new System.EventHandler(this.BusinessTripOrderToolStripMenuItem_Click);
            // 
            // panel_Inputs
            // 
            this.panel_Inputs.Controls.Add(this.tableLayoutPanel_OwnFields);
            this.panel_Inputs.Controls.Add(this.button_SaveDocument);
            this.panel_Inputs.Controls.Add(this.tableLayoutPanel_DocumentForm);
            this.panel_Inputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Inputs.Location = new System.Drawing.Point(0, 0);
            this.panel_Inputs.Name = "panel_Inputs";
            this.panel_Inputs.Size = new System.Drawing.Size(610, 761);
            this.panel_Inputs.TabIndex = 2;
            // 
            // tableLayoutPanel_OwnFields
            // 
            this.tableLayoutPanel_OwnFields.AutoSize = true;
            this.tableLayoutPanel_OwnFields.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_OwnFields.ColumnCount = 2;
            this.tableLayoutPanel_OwnFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_OwnFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_OwnFields.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel_OwnFields.Location = new System.Drawing.Point(36, 504);
            this.tableLayoutPanel_OwnFields.Name = "tableLayoutPanel_OwnFields";
            this.tableLayoutPanel_OwnFields.RowCount = 2;
            this.tableLayoutPanel_OwnFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_OwnFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_OwnFields.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel_OwnFields.TabIndex = 2;
            // 
            // button_SaveDocument
            // 
            this.button_SaveDocument.AutoSize = true;
            this.button_SaveDocument.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SaveDocument.Location = new System.Drawing.Point(477, 707);
            this.button_SaveDocument.Name = "button_SaveDocument";
            this.button_SaveDocument.Size = new System.Drawing.Size(114, 33);
            this.button_SaveDocument.TabIndex = 1;
            this.button_SaveDocument.Text = "Сохранить";
            this.button_SaveDocument.UseVisualStyleBackColor = true;
            this.button_SaveDocument.Click += new System.EventHandler(this.button_SaveDocument_Click);
            // 
            // tableLayoutPanel_DocumentForm
            // 
            this.tableLayoutPanel_DocumentForm.ColumnCount = 2;
            this.tableLayoutPanel_DocumentForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_DocumentForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_DocumentForm.Controls.Add(this.textBox_Content, 1, 2);
            this.tableLayoutPanel_DocumentForm.Controls.Add(this.textBox_DateTimeCreateDocument, 1, 1);
            this.tableLayoutPanel_DocumentForm.Controls.Add(this.label_DocNum, 0, 0);
            this.tableLayoutPanel_DocumentForm.Controls.Add(this.label_DateTimeCreateDocument, 0, 1);
            this.tableLayoutPanel_DocumentForm.Controls.Add(this.label_Content, 0, 2);
            this.tableLayoutPanel_DocumentForm.Controls.Add(this.textBox_DocNum, 1, 0);
            this.tableLayoutPanel_DocumentForm.Location = new System.Drawing.Point(17, 57);
            this.tableLayoutPanel_DocumentForm.Name = "tableLayoutPanel_DocumentForm";
            this.tableLayoutPanel_DocumentForm.RowCount = 3;
            this.tableLayoutPanel_DocumentForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_DocumentForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_DocumentForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_DocumentForm.Size = new System.Drawing.Size(586, 401);
            this.tableLayoutPanel_DocumentForm.TabIndex = 0;
            // 
            // textBox_Content
            // 
            this.textBox_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Content.Location = new System.Drawing.Point(192, 67);
            this.textBox_Content.Multiline = true;
            this.textBox_Content.Name = "textBox_Content";
            this.textBox_Content.Size = new System.Drawing.Size(391, 331);
            this.textBox_Content.TabIndex = 5;
            // 
            // textBox_DateTimeCreateDocument
            // 
            this.textBox_DateTimeCreateDocument.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_DateTimeCreateDocument.Location = new System.Drawing.Point(192, 35);
            this.textBox_DateTimeCreateDocument.Name = "textBox_DateTimeCreateDocument";
            this.textBox_DateTimeCreateDocument.ReadOnly = true;
            this.textBox_DateTimeCreateDocument.Size = new System.Drawing.Size(199, 26);
            this.textBox_DateTimeCreateDocument.TabIndex = 4;
            // 
            // label_DocNum
            // 
            this.label_DocNum.AutoSize = true;
            this.label_DocNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DocNum.Location = new System.Drawing.Point(3, 0);
            this.label_DocNum.Name = "label_DocNum";
            this.label_DocNum.Size = new System.Drawing.Size(130, 19);
            this.label_DocNum.TabIndex = 0;
            this.label_DocNum.Text = "Номер документа:";
            // 
            // label_DateTimeCreateDocument
            // 
            this.label_DateTimeCreateDocument.AutoSize = true;
            this.label_DateTimeCreateDocument.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DateTimeCreateDocument.Location = new System.Drawing.Point(3, 32);
            this.label_DateTimeCreateDocument.Name = "label_DateTimeCreateDocument";
            this.label_DateTimeCreateDocument.Size = new System.Drawing.Size(183, 19);
            this.label_DateTimeCreateDocument.TabIndex = 1;
            this.label_DateTimeCreateDocument.Text = "Дата создания документа:";
            // 
            // label_Content
            // 
            this.label_Content.AutoSize = true;
            this.label_Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Content.Location = new System.Drawing.Point(3, 64);
            this.label_Content.Name = "label_Content";
            this.label_Content.Size = new System.Drawing.Size(99, 19);
            this.label_Content.TabIndex = 2;
            this.label_Content.Text = "Содержимое:";
            // 
            // textBox_DocNum
            // 
            this.textBox_DocNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_DocNum.Location = new System.Drawing.Point(192, 3);
            this.textBox_DocNum.Name = "textBox_DocNum";
            this.textBox_DocNum.ReadOnly = true;
            this.textBox_DocNum.Size = new System.Drawing.Size(100, 26);
            this.textBox_DocNum.TabIndex = 3;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form_main";
            this.Text = "Form_main";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel_Inputs.ResumeLayout(false);
            this.panel_Inputs.PerformLayout();
            this.tableLayoutPanel_DocumentForm.ResumeLayout(false);
            this.tableLayoutPanel_DocumentForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_DocumentInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView_Documents;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Create_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Letter_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Order_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BusinessTripOrderToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Inputs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DocumentForm;
        private System.Windows.Forms.TextBox textBox_Content;
        private System.Windows.Forms.TextBox textBox_DateTimeCreateDocument;
        private System.Windows.Forms.Label label_DocNum;
        private System.Windows.Forms.Label label_DateTimeCreateDocument;
        private System.Windows.Forms.Label label_Content;
        private System.Windows.Forms.TextBox textBox_DocNum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_OwnFields;
        private System.Windows.Forms.Button button_SaveDocument;
    }
}

