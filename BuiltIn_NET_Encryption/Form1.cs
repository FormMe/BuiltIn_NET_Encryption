using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuiltIn_NET_Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Firebrick);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)12.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        #region SymmetricEncryptDecrypt
        private SymmetricEncryptDecryptManager symCryptoManager = new SymmetricEncryptDecryptManager();
        private FileManager symFileManager = new FileManager();
        private void шифроватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(symFileManager.encrypFile))
                    throw new Exception("Выберите файл шифрования");
                if (string.IsNullOrEmpty(symFileManager.decrypFile))
                    throw new Exception("Выберите файл дешифрования");
                if (symCryptoManager.Key == null)
                    throw new Exception("Выберите ключ");
                if (symCryptoManager.IV == null)
                    throw new Exception("Выберите вектор инициализации");
                if (SymAlgComboBox.SelectedIndex == -1)
                    throw new Exception("Выберите алгоритм");

                symCryptoManager.type = (SymmetricAlgorithmType)SymAlgComboBox.SelectedIndex;
                symCryptoManager.EncryptFile(symFileManager.encrypFile, symFileManager.decrypFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption failed! " + ex.Message, "Error");
            }
        }
        private void дешифроватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(symFileManager.decrypFile))
                    throw new Exception("Выберите файл дешифрования");
                if (string.IsNullOrEmpty(symFileManager.encrypFile))
                    throw new Exception("Выберите расшифрованный файл");
                if (symCryptoManager.Key == null)
                    throw new Exception("Выберите ключ");
                if (symCryptoManager.IV == null)
                    throw new Exception("Выберите вектор инициализации");
                if (SymAlgComboBox.SelectedIndex == -1)
                    throw new Exception("Выберите алгоритм");

                symCryptoManager.type = (SymmetricAlgorithmType)SymAlgComboBox.SelectedIndex;
                symCryptoManager.DecryptFile(symFileManager.decrypFile, symFileManager.decrypedFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption failed! " + ex.Message, "Error");
            }
        }

        private void ключToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var file = FileManager.SetFile();
            if (!string.IsNullOrEmpty(file))
                symCryptoManager.Key = Encoding.Unicode.GetBytes(File.ReadAllText(file));
        }

        private void векторИнициализацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var file = FileManager.SetFile();
            if (!string.IsNullOrEmpty(file))
                symCryptoManager.IV = Encoding.Unicode.GetBytes(File.ReadAllText(file));
        }

        private void файлШифрованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            symFileManager.encrypFile = FileManager.SetFile();
        }

        private void файлДешифрованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            symFileManager.decrypFile = FileManager.SetFile();
        }

        private void расшифрованыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            symFileManager.decrypedFile = FileManager.SetFile();
        }


        #endregion


        #region AsymmetricEncryptDecrypt

        AsymmetricEncryptDecryptManager asymManager = new AsymmetricEncryptDecryptManager();
        FileManager asymFileManager = new FileManager();

        private void GenKeys_click(object sender, EventArgs e)
        {
            try
            {
                int keySize;
                int.TryParse(keySize_numericUpDown.Text, out keySize);
                if (keySize % 8 != 0)
                    throw new Exception("Размер ключа должен быть кратен 8");
                asymManager.GenerateKeys(keySize);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                throw;
            }
        }
        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(asymFileManager.encrypFile))
                    throw new Exception("Выберите файл шифрования");
                if (string.IsNullOrEmpty(asymFileManager.decrypFile))
                    throw new Exception("Выберите файл дешифрования");
                if (asymManager.publicKey == null)
                    throw new Exception("Сгенерируйте ключи");
                asymManager.EncryptFile(asymFileManager.encrypFile, asymFileManager.decrypFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                throw;
            }
        }
        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(asymFileManager.decrypFile))
                    throw new Exception("Выберите файл шифрования");
                if (string.IsNullOrEmpty(asymFileManager.decrypedFile))
                    throw new Exception("Выберите файл дешифрования");
                if (asymManager.privateKey == null)
                    throw new Exception("Сгенерируйте ключи");
                asymManager.DecryptFile(asymFileManager.decrypFile, asymFileManager.decrypedFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                throw;
            }

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            asymFileManager.encrypFile = FileManager.SetFile();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            asymFileManager.decrypFile = FileManager.SetFile();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            asymFileManager.decrypedFile = FileManager.SetFile();
        }

        private void isOAEP_CheckedChanged(object sender, EventArgs e)
        {
            asymManager.DoOAEPPadding = checkBox1.Checked;
        }
        #endregion

    }
}
