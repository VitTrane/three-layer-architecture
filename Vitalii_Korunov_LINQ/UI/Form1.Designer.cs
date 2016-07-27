namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.customersListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отфильтроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поОтчествуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюБанкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersListView
            // 
            this.customersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.customersListView.ContextMenuStrip = this.contextMenuStrip;
            this.customersListView.FullRowSelect = true;
            this.customersListView.Location = new System.Drawing.Point(12, 12);
            this.customersListView.MultiSelect = false;
            this.customersListView.Name = "customersListView";
            this.customersListView.Size = new System.Drawing.Size(485, 290);
            this.customersListView.TabIndex = 0;
            this.customersListView.UseCompatibleStateImageBehavior = false;
            this.customersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Фамилия";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Отчество";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Возраст";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Название банка";
            this.columnHeader5.Width = 118;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКлиентаToolStripMenuItem,
            this.редактироватьКлиентаToolStripMenuItem,
            this.удалитьКлиентаToolStripMenuItem,
            this.отфильтроватьToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(202, 92);
            // 
            // добавитьКлиентаToolStripMenuItem
            // 
            this.добавитьКлиентаToolStripMenuItem.Name = "добавитьКлиентаToolStripMenuItem";
            this.добавитьКлиентаToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.добавитьКлиентаToolStripMenuItem.Text = "Добавить клиента";
            this.добавитьКлиентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьКлиентаToolStripMenuItem_Click);
            // 
            // редактироватьКлиентаToolStripMenuItem
            // 
            this.редактироватьКлиентаToolStripMenuItem.Name = "редактироватьКлиентаToolStripMenuItem";
            this.редактироватьКлиентаToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.редактироватьКлиентаToolStripMenuItem.Text = "Редактировать клиента";
            this.редактироватьКлиентаToolStripMenuItem.Click += new System.EventHandler(this.редактироватьКлиентаToolStripMenuItem_Click);
            // 
            // удалитьКлиентаToolStripMenuItem
            // 
            this.удалитьКлиентаToolStripMenuItem.Name = "удалитьКлиентаToolStripMenuItem";
            this.удалитьКлиентаToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.удалитьКлиентаToolStripMenuItem.Text = "Удалить клиента";
            this.удалитьКлиентаToolStripMenuItem.Click += new System.EventHandler(this.удалитьКлиентаToolStripMenuItem_Click);
            // 
            // отфильтроватьToolStripMenuItem
            // 
            this.отфильтроватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поФамилииToolStripMenuItem,
            this.поИмениToolStripMenuItem,
            this.поОтчествуToolStripMenuItem,
            this.поНазваниюБанкаToolStripMenuItem,
            this.показатьВсеToolStripMenuItem});
            this.отфильтроватьToolStripMenuItem.Name = "отфильтроватьToolStripMenuItem";
            this.отфильтроватьToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.отфильтроватьToolStripMenuItem.Text = "Отфильтровать";
            // 
            // поФамилииToolStripMenuItem
            // 
            this.поФамилииToolStripMenuItem.Name = "поФамилииToolStripMenuItem";
            this.поФамилииToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.поФамилииToolStripMenuItem.Text = "По фамилии";
            this.поФамилииToolStripMenuItem.Click += new System.EventHandler(this.поФамилииToolStripMenuItem_Click);
            // 
            // поИмениToolStripMenuItem
            // 
            this.поИмениToolStripMenuItem.Name = "поИмениToolStripMenuItem";
            this.поИмениToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.поИмениToolStripMenuItem.Text = "По имени";
            this.поИмениToolStripMenuItem.Click += new System.EventHandler(this.поИмениToolStripMenuItem_Click);
            // 
            // поОтчествуToolStripMenuItem
            // 
            this.поОтчествуToolStripMenuItem.Name = "поОтчествуToolStripMenuItem";
            this.поОтчествуToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.поОтчествуToolStripMenuItem.Text = "По отчеству";
            this.поОтчествуToolStripMenuItem.Click += new System.EventHandler(this.поОтчествуToolStripMenuItem_Click);
            // 
            // поНазваниюБанкаToolStripMenuItem
            // 
            this.поНазваниюБанкаToolStripMenuItem.Name = "поНазваниюБанкаToolStripMenuItem";
            this.поНазваниюБанкаToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.поНазваниюБанкаToolStripMenuItem.Text = "По названию банка";
            this.поНазваниюБанкаToolStripMenuItem.Click += new System.EventHandler(this.поНазваниюБанкаToolStripMenuItem_Click);
            // 
            // показатьВсеToolStripMenuItem
            // 
            this.показатьВсеToolStripMenuItem.Name = "показатьВсеToolStripMenuItem";
            this.показатьВсеToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.показатьВсеToolStripMenuItem.Text = "Показать все";
            this.показатьВсеToolStripMenuItem.Click += new System.EventHandler(this.показатьВсеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 314);
            this.Controls.Add(this.customersListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView customersListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отфильтроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИмениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поОтчествуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюБанкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьВсеToolStripMenuItem;
    }
}

