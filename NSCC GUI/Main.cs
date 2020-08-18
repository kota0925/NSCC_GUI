using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace NSCC_GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void original_button_Click(object sender, EventArgs e)
        {
            if (original_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                original_textBox.Text = original_folderBrowserDialog.SelectedPath;
            }
        }

        private void copyTo_button_Click(object sender, EventArgs e)
        {
            if (copyTo_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                copyTo_textBox.Text = copyTo_folderBrowserDialog.SelectedPath;
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            // フォルダアクセスチェック
            if (!Directory.Exists(original_textBox.Text))
            {
                MessageBox.Show("コピー元のフォルダが存在しないか、アクセスできません。", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(copyTo_textBox.Text))
            {
                MessageBox.Show("コピー先のフォルダが存在しないか、アクセスできません。", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // コントロール設定
            enableControls(false);

            // コピー実行
            startCopy();
        }


        private void enableControls(bool enable)
        {
            if (original_groupBox.InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    original_groupBox.Enabled = enable;
                    copyTo_groupBox.Enabled = enable;
                    start_button.Enabled = enable;
                    options_groupBox.Enabled = enable;
                });
            }
            else
            {
                original_groupBox.Enabled = enable;
                copyTo_button.Enabled = enable;
                start_button.Enabled = enable;
                options_groupBox.Enabled = enable;
            }
        }

        private void appendLogs(string data)
        {
            Invoke((MethodInvoker)delegate
            {
                logs_textBox.AppendText(data + "\r\n");
            });
        }


        private async Task startCopy()
        {
            // フォルダ内のファイル取得
            IEnumerable<string> files = Directory.EnumerateFiles(original_textBox.Text, "*", SearchOption.AllDirectories);
            var sw = new System.Diagnostics.Stopwatch();

            // プログレスバー初期化
            Invoke((MethodInvoker)delegate
            {
                logs_progressBar.Value = 0;
                logs_progressBar.Maximum = files.Count();
            });

            // フォルダ内にファイルが存在しない場合
            if (logs_progressBar.Maximum < 1)
            {
                MessageBox.Show(original_textBox.Text + " フォルダ内にファイルが見つかりませんでした。", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // ファイルコピー
            foreach (string path in files)
            {
                string copyToPath = Path.Combine(copyTo_textBox.Text, Path.GetFileName(path));
                try
                {
                    Invoke((MethodInvoker)delegate
                    {
                        logs_progressBar.Value++;
                    });
                    // ファイルコピー
                    sw.Start();
                    File.Copy(path, copyToPath, fileExist_checkBox.Checked);
                    sw.Stop();

                    // ログ出力
                    if (showCopyTo_checkBox.Checked)
                        appendLogs("["+ sw.ElapsedMilliseconds + "ms]: "+ path);
                    else
                        appendLogs("[" + sw.ElapsedMilliseconds + "ms]: " + copyToPath);
                } 
                catch (Exception e)
                {
                    appendLogs("[Error]: " + e.Message);
                }
            }

            MessageBox.Show(logs_progressBar.Maximum + "個のファイルの操作が完了しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            enableControls(true);
        }

        private void original_groupBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (Directory.Exists(fileName[0]))
                original_textBox.Text = fileName[0];
        }

        private void original_groupBox_DragEnter(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void copyTo_groupBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (Directory.Exists(fileName[0]))
                copyTo_textBox.Text = fileName[0];
        }

        private void copyTo_groupBox_DragEnter(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
