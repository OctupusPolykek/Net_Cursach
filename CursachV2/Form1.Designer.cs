namespace CursachV2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запаролитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеЗаписейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеЗаписейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайсЛистВTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddRecord = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AppAc = new System.Windows.Forms.Button();
            this.AppAb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ReloadBtn = new System.Windows.Forms.Button();
            this.ShowInfoCheck = new System.Windows.Forms.CheckBox();
            this.файлНа20ЗаписейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.редактированиеЗаписейToolStripMenuItem,
            this.выводToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.сохранитьToolStripMenuItem,
            this.создатьToolStripMenuItem,
            this.запаролитьToolStripMenuItem,
            this.файлНа20ЗаписейToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem2.Text = "Создать";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.создатьToolStripMenuItem.Text = "Загрузить";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // запаролитьToolStripMenuItem
            // 
            this.запаролитьToolStripMenuItem.Name = "запаролитьToolStripMenuItem";
            this.запаролитьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.запаролитьToolStripMenuItem.Text = "Запаролить";
            this.запаролитьToolStripMenuItem.Click += new System.EventHandler(this.запаролитьToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // редактированиеЗаписейToolStripMenuItem
            // 
            this.редактированиеЗаписейToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редToolStripMenuItem,
            this.удалениеЗаписейToolStripMenuItem});
            this.редактированиеЗаписейToolStripMenuItem.Name = "редактированиеЗаписейToolStripMenuItem";
            this.редактированиеЗаписейToolStripMenuItem.Size = new System.Drawing.Size(146, 21);
            this.редактированиеЗаписейToolStripMenuItem.Text = "Редактирование файла";
            // 
            // редToolStripMenuItem
            // 
            this.редToolStripMenuItem.Name = "редToolStripMenuItem";
            this.редToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.редToolStripMenuItem.Text = "Редактирование записей";
            this.редToolStripMenuItem.Click += new System.EventHandler(this.редToolStripMenuItem_Click);
            // 
            // удалениеЗаписейToolStripMenuItem
            // 
            this.удалениеЗаписейToolStripMenuItem.Name = "удалениеЗаписейToolStripMenuItem";
            this.удалениеЗаписейToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.удалениеЗаписейToolStripMenuItem.Text = "Удаление записей";
            this.удалениеЗаписейToolStripMenuItem.Click += new System.EventHandler(this.удалениеЗаписейToolStripMenuItem_Click);
            // 
            // выводToolStripMenuItem
            // 
            this.выводToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прайсЛистВTxtToolStripMenuItem});
            this.выводToolStripMenuItem.Name = "выводToolStripMenuItem";
            this.выводToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.выводToolStripMenuItem.Text = "Вывод";
            // 
            // прайсЛистВTxtToolStripMenuItem
            // 
            this.прайсЛистВTxtToolStripMenuItem.Name = "прайсЛистВTxtToolStripMenuItem";
            this.прайсЛистВTxtToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.прайсЛистВTxtToolStripMenuItem.Text = "Прайс лист в txt";
            this.прайсЛистВTxtToolStripMenuItem.Click += new System.EventHandler(this.прайсЛистВTxtToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(169, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(676, 381);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "№";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Наименование";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фирма";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Номер магазина";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Минимальная партия";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // AddRecord
            // 
            this.AddRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRecord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddRecord.Location = new System.Drawing.Point(12, 60);
            this.AddRecord.Name = "AddRecord";
            this.AddRecord.Size = new System.Drawing.Size(151, 23);
            this.AddRecord.TabIndex = 0;
            this.AddRecord.Text = "Добавить  запись";
            this.AddRecord.UseVisualStyleBackColor = true;
            this.AddRecord.Click += new System.EventHandler(this.AddRecord_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AppAc);
            this.groupBox1.Controls.Add(this.AppAb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 150);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Приложение А";
            // 
            // AppAc
            // 
            this.AppAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppAc.Location = new System.Drawing.Point(7, 79);
            this.AppAc.Name = "AppAc";
            this.AppAc.Size = new System.Drawing.Size(138, 61);
            this.AppAc.TabIndex = 2;
            this.AppAc.Text = "Вывести наименования и количество всех товаров, хранящихся магазине";
            this.AppAc.UseVisualStyleBackColor = true;
            this.AppAc.Click += new System.EventHandler(this.AppAc_Click);
            // 
            // AppAb
            // 
            this.AppAb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppAb.Location = new System.Drawing.Point(7, 22);
            this.AppAb.Name = "AppAb";
            this.AppAb.Size = new System.Drawing.Size(138, 51);
            this.AppAb.TabIndex = 1;
            this.AppAb.Text = "Вывести наименование товаров с минимальной партией менее 5";
            this.AppAb.UseVisualStyleBackColor = true;
            this.AppAb.Click += new System.EventHandler(this.AppAb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(169, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Car shop:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 282);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(151, 125);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(12, 413);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ReloadBtn
            // 
            this.ReloadBtn.Location = new System.Drawing.Point(93, 413);
            this.ReloadBtn.Name = "ReloadBtn";
            this.ReloadBtn.Size = new System.Drawing.Size(70, 23);
            this.ReloadBtn.TabIndex = 12;
            this.ReloadBtn.Text = "Рестарт";
            this.ReloadBtn.UseVisualStyleBackColor = true;
            this.ReloadBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
            // 
            // ShowInfoCheck
            // 
            this.ShowInfoCheck.AutoSize = true;
            this.ShowInfoCheck.Checked = true;
            this.ShowInfoCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowInfoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowInfoCheck.Location = new System.Drawing.Point(679, 31);
            this.ShowInfoCheck.Name = "ShowInfoCheck";
            this.ShowInfoCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInfoCheck.Size = new System.Drawing.Size(166, 20);
            this.ShowInfoCheck.TabIndex = 13;
            this.ShowInfoCheck.Text = "Показать все записи";
            this.ShowInfoCheck.UseVisualStyleBackColor = true;
            this.ShowInfoCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // файлНа20ЗаписейToolStripMenuItem
            // 
            this.файлНа20ЗаписейToolStripMenuItem.Name = "файлНа20ЗаписейToolStripMenuItem";
            this.файлНа20ЗаписейToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.файлНа20ЗаписейToolStripMenuItem.Text = "Файл на 20 записей";
            this.файлНа20ЗаписейToolStripMenuItem.Click += new System.EventHandler(this.файлНа20ЗаписейToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.ShowInfoCheck);
            this.Controls.Add(this.ReloadBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddRecord);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddRecord;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеЗаписейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеЗаписейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AppAc;
        private System.Windows.Forms.Button AppAb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ReloadBtn;
        private System.Windows.Forms.ToolStripMenuItem запаролитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.CheckBox ShowInfoCheck;
        private System.Windows.Forms.ToolStripMenuItem выводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайсЛистВTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлНа20ЗаписейToolStripMenuItem;
    }
}

