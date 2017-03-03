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
            this.SymAlgComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SymAlgMenuStrip = new System.Windows.Forms.MenuStrip();
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
            this.keySize_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AsymAlgMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DigSigMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.HashMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SymAlgMenuStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keySize_numericUpDown)).BeginInit();
            this.AsymAlgMenuStrip.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.DigSigMenuStrip.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.HashMenuStrip.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.SymAlgMenuStrip);
            this.tabPage1.Location = new System.Drawing.Point(204, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(268, 154);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Симетричное шифрование";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите алгоритм";
            // 
            // SymAlgMenuStrip
            // 
            this.SymAlgMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.шифроватьToolStripMenuItem,
            this.дешифроватьToolStripMenuItem});
            this.SymAlgMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.SymAlgMenuStrip.Name = "SymAlgMenuStrip";
            this.SymAlgMenuStrip.Size = new System.Drawing.Size(262, 24);
            this.SymAlgMenuStrip.TabIndex = 0;
            this.SymAlgMenuStrip.Text = "menuStrip2";
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
            this.tabPage2.Controls.Add(this.keySize_numericUpDown);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.AsymAlgMenuStrip);
            this.tabPage2.Location = new System.Drawing.Point(204, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(268, 154);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Асиметричное шифрование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // keySize_numericUpDown
            // 
            this.keySize_numericUpDown.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.keySize_numericUpDown.Location = new System.Drawing.Point(6, 71);
            this.keySize_numericUpDown.Maximum = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            this.keySize_numericUpDown.Minimum = new decimal(new int[] {
            384,
            0,
            0,
            0});
            this.keySize_numericUpDown.Name = "keySize_numericUpDown";
            this.keySize_numericUpDown.Size = new System.Drawing.Size(140, 20);
            this.keySize_numericUpDown.TabIndex = 7;
            this.keySize_numericUpDown.Value = new decimal(new int[] {
            384,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Длина ключа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Алгоритм RSA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сгенерировать ключи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenKeys_click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 124);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Optimal Asymmetric Encryption Padding";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.isOAEP_CheckedChanged);
            // 
            // AsymAlgMenuStrip
            // 
            this.AsymAlgMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem18,
            this.toolStripMenuItem19});
            this.AsymAlgMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.AsymAlgMenuStrip.Name = "AsymAlgMenuStrip";
            this.AsymAlgMenuStrip.Size = new System.Drawing.Size(262, 24);
            this.AsymAlgMenuStrip.TabIndex = 1;
            this.AsymAlgMenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem5.Text = "Выбрать файл";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem15.Text = "Файл шифрования";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.toolStripMenuItem15_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem16.Text = "Файл дешифрования";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.toolStripMenuItem16_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem17.Text = "Расшифрованый файл";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.toolStripMenuItem17_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(83, 20);
            this.toolStripMenuItem18.Text = "Шифровать";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.toolStripMenuItem18_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(97, 20);
            this.toolStripMenuItem19.Text = "Дешифровать";
            this.toolStripMenuItem19.Click += new System.EventHandler(this.toolStripMenuItem19_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DigSigMenuStrip);
            this.tabPage3.Location = new System.Drawing.Point(204, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(268, 154);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Цифрования подпись";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DigSigMenuStrip
            // 
            this.DigSigMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.DigSigMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.DigSigMenuStrip.Name = "DigSigMenuStrip";
            this.DigSigMenuStrip.Size = new System.Drawing.Size(262, 24);
            this.DigSigMenuStrip.TabIndex = 2;
            this.DigSigMenuStrip.Text = "menuStrip3";
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
            this.tabPage4.Controls.Add(this.HashMenuStrip);
            this.tabPage4.Location = new System.Drawing.Point(204, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(268, 154);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Хэширование";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // HashMenuStrip
            // 
            this.HashMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11,
            this.toolStripMenuItem14});
            this.HashMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.HashMenuStrip.Name = "HashMenuStrip";
            this.HashMenuStrip.Size = new System.Drawing.Size(262, 24);
            this.HashMenuStrip.TabIndex = 2;
            this.HashMenuStrip.Text = "menuStrip4";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 162);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.SymAlgMenuStrip.ResumeLayout(false);
            this.SymAlgMenuStrip.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keySize_numericUpDown)).EndInit();
            this.AsymAlgMenuStrip.ResumeLayout(false);
            this.AsymAlgMenuStrip.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.DigSigMenuStrip.ResumeLayout(false);
            this.DigSigMenuStrip.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.HashMenuStrip.ResumeLayout(false);
            this.HashMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip SymAlgMenuStrip;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыШифрованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectFileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem шифроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дешифроватьToolStripMenuItem;
        private System.Windows.Forms.MenuStrip DigSigMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.MenuStrip HashMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ключToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem векторИнициализацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлШифрованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлДешифрованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расшифрованыйФайлToolStripMenuItem;
        private ComboBox SymAlgComboBox;
        private MenuStrip AsymAlgMenuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripMenuItem toolStripMenuItem17;
        private ToolStripMenuItem toolStripMenuItem18;
        private ToolStripMenuItem toolStripMenuItem19;
        private CheckBox checkBox1;
        private Button button1;
        private NumericUpDown keySize_numericUpDown;
        private Label label3;
        private Label label2;
    }
}

