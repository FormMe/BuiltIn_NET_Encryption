using System.Windows.Forms;

namespace BuiltIn_NET_Encryption
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыШифрованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ключToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.векторИнициализацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлШифрованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлДешифрованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расшифрованыйФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шифроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дешифроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.SymAlgComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.ItemSize = new System.Drawing.Size(25, 200);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(476, 162);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SymAlgComboBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.menuStrip2);
            this.tabPage1.Location = new System.Drawing.Point(204, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(268, 154);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Симетричное шифрование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите алгоритм";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.шифроватьToolStripMenuItem,
            this.дешифроватьToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(262, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыШифрованияToolStripMenuItem,
            this.SelectFileToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // параметрыШифрованияToolStripMenuItem
            // 
            this.параметрыШифрованияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ключToolStripMenuItem,
            this.векторИнициализацииToolStripMenuItem});
            this.параметрыШифрованияToolStripMenuItem.Name = "параметрыШифрованияToolStripMenuItem";
            this.параметрыШифрованияToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.параметрыШифрованияToolStripMenuItem.Text = "Параметры шифрования";
            // 
            // ключToolStripMenuItem
            // 
            this.ключToolStripMenuItem.Name = "ключToolStripMenuItem";
            this.ключToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ключToolStripMenuItem.Text = "Ключ";
            this.ключToolStripMenuItem.Click += new System.EventHandler(this.ключToolStripMenuItem_Click);
            // 
            // векторИнициализацииToolStripMenuItem
            // 
            this.векторИнициализацииToolStripMenuItem.Name = "векторИнициализацииToolStripMenuItem";
            this.векторИнициализацииToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.векторИнициализацииToolStripMenuItem.Text = "Вектор инициализации";
            this.векторИнициализацииToolStripMenuItem.Click += new System.EventHandler(this.векторИнициализацииToolStripMenuItem_Click);
            // 
            // SelectFileToolStripMenuItem
            // 
            this.SelectFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлШифрованияToolStripMenuItem,
            this.файлДешифрованияToolStripMenuItem,
            this.расшифрованыйФайлToolStripMenuItem});
            this.SelectFileToolStripMenuItem.Name = "SelectFileToolStripMenuItem";
            this.SelectFileToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.SelectFileToolStripMenuItem.Text = "Выбрать файл";
            // 
            // файлШифрованияToolStripMenuItem
            // 
            this.файлШифрованияToolStripMenuItem.Name = "файлШифрованияToolStripMenuItem";
            this.файлШифрованияToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.файлШифрованияToolStripMenuItem.Text = "Файл шифрования";
            this.файлШифрованияToolStripMenuItem.Click += new System.EventHandler(this.файлШифрованияToolStripMenuItem_Click);
            // 
            // файлДешифрованияToolStripMenuItem
            // 
            this.файлДешифрованияToolStripMenuItem.Name = "файлДешифрованияToolStripMenuItem";
            this.файлДешифрованияToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.файлДешифрованияToolStripMenuItem.Text = "Файл дешифрования";
            this.файлДешифрованияToolStripMenuItem.Click += new System.EventHandler(this.файлДешифрованияToolStripMenuItem_Click);
            // 
            // расшифрованыйФайлToolStripMenuItem
            // 
            this.расшифрованыйФайлToolStripMenuItem.Name = "расшифрованыйФайлToolStripMenuItem";
            this.расшифрованыйФайлToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.расшифрованыйФайлToolStripMenuItem.Text = "Расшифрованый файл";
            this.расшифрованыйФайлToolStripMenuItem.Click += new System.EventHandler(this.расшифрованыйФайлToolStripMenuItem_Click);
            // 
            // шифроватьToolStripMenuItem
            // 
            this.шифроватьToolStripMenuItem.Name = "шифроватьToolStripMenuItem";
            this.шифроватьToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.шифроватьToolStripMenuItem.Text = "Шифровать";
            this.шифроватьToolStripMenuItem.Click += new System.EventHandler(this.шифроватьToolStripMenuItem_Click);
            // 
            // дешифроватьToolStripMenuItem
            // 
            this.дешифроватьToolStripMenuItem.Name = "дешифроватьToolStripMenuItem";
            this.дешифроватьToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.дешифроватьToolStripMenuItem.Text = "Дешифровать";
            this.дешифроватьToolStripMenuItem.Click += new System.EventHandler(this.дешифроватьToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.menuStrip1);
            this.tabPage2.Location = new System.Drawing.Point(204, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(268, 154);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Асиметричное шифрование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(262, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.сохранитьToolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem2.Text = "Параметры шифрования";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem3.Text = "Выбрать файл";
            // 
            // сохранитьToolStripMenuItem2
            // 
            this.сохранитьToolStripMenuItem2.Name = "сохранитьToolStripMenuItem2";
            this.сохранитьToolStripMenuItem2.Size = new System.Drawing.Size(214, 22);
            this.сохранитьToolStripMenuItem2.Text = "Сохранить";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(83, 20);
            this.toolStripMenuItem4.Text = "Шифровать";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(97, 20);
            this.toolStripMenuItem5.Text = "Дешифровать";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.menuStrip3);
            this.tabPage3.Location = new System.Drawing.Point(204, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(268, 154);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Цифрования подпись";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.menuStrip3.Location = new System.Drawing.Point(3, 3);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(262, 24);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.сохранитьToolStripMenuItem3});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem6.Text = "Файл";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem7.Text = "Параметры подписи";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem8.Text = "Выбрать файл";
            // 
            // сохранитьToolStripMenuItem3
            // 
            this.сохранитьToolStripMenuItem3.Name = "сохранитьToolStripMenuItem3";
            this.сохранитьToolStripMenuItem3.Size = new System.Drawing.Size(188, 22);
            this.сохранитьToolStripMenuItem3.Text = "Сохранить";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(111, 20);
            this.toolStripMenuItem9.Text = "Создать подпись";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem10.Text = "Проверить";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.menuStrip4);
            this.tabPage4.Location = new System.Drawing.Point(204, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(268, 154);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Хэширование";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // menuStrip4
            // 
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11,
            this.toolStripMenuItem14});
            this.menuStrip4.Location = new System.Drawing.Point(3, 3);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(262, 24);
            this.menuStrip4.TabIndex = 2;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripMenuItem13});
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem11.Text = "Файл";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem12.Text = "Выбрать файл";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem13.Text = "Сохранить";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(105, 20);
            this.toolStripMenuItem14.Text = "Вычислить хэш";
            // 
            // SymAlgComboBox
            // 
            this.SymAlgComboBox.FormattingEnabled = true;
            this.SymAlgComboBox.Items.AddRange(new object[] {
            "AES",
            "Rijndael",
            "DES",
            "RC2",
            "TripleDES"});
            this.SymAlgComboBox.Location = new System.Drawing.Point(20, 57);
            this.SymAlgComboBox.Name = "SymAlgComboBox";
            this.SymAlgComboBox.Size = new System.Drawing.Size(121, 21);
            this.SymAlgComboBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 162);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыШифрованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectFileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem шифроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дешифроватьToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ключToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem векторИнициализацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлШифрованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлДешифрованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расшифрованыйФайлToolStripMenuItem;
        private ComboBox SymAlgComboBox;
    }
}

