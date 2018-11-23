using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace droppath
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> sepCharTable = new Dictionary<string, string>()
        {
            {"[Space]", " " },
            {"[Tab]", "\t" },
            {"[Comma]", "," },
            {"[Colon]", ":" },
            {"[Semicolon]", ";" },
            {"[CRLF]", "\r\n" },
            {"[LF]", "\n" },
        };

        // https://dobon.net/vb/dotnet/file/getabsolutepath.html
        [DllImport("shlwapi.dll",
            CharSet = CharSet.Auto)]
        private static extern bool PathRelativePathTo(
            [Out] StringBuilder pszPath,
            [In] string pszFrom,
            [In] System.IO.FileAttributes dwAttrFrom,
            [In] string pszTo,
            [In] System.IO.FileAttributes dwAttrTo
        );

        /// <summary>
        /// 絶対パスから相対パスを取得します。
        /// </summary>
        /// <param name="basePath">基準とするフォルダのパス。</param>
        /// <param name="absolutePath">相対パス。</param>
        /// <returns>絶対パス。</returns>
        private static string GetRelativePath(string basePath, string absolutePath)
        {
            StringBuilder sb = new StringBuilder(260);
            bool res = PathRelativePathTo(sb,
                basePath, System.IO.FileAttributes.Directory,
                absolutePath, System.IO.FileAttributes.Normal);
            if (!res)
            {
                throw new Exception("相対パスの取得に失敗しました。");
            }
            return sb.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
        }

        private void textBoxFiles_DragDrop(object sender, DragEventArgs e)
        {
            // ドロップされたファイルを改行区切りでテキストボックスに入れる
            // 最終行にも改行を入れる
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            textBoxFiles.Text = string.Concat(files.Select(s => s + Environment.NewLine));
        }

        private string convPath(string absPath)
        {
            string path = absPath;
            string baseDirectory = textBoxBaseDirectory.Text;
            if (checkBoxRelativePath.Checked && baseDirectory.Length > 0)
            {
                // 相対パスに変換
                try
                {
                    path = GetRelativePath(baseDirectory, path);
                    if (path.StartsWith(".\\"))
                    {
                        // .\の削除
                        path = path.Substring(2);
                    }
                }
                catch (Exception)
                {
                    // ドライブが違うと失敗する
                }
            }

            if (checkBoxQuote.Checked)
            {
                path = "\"" + path + "\"";
            }
            return path;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            // パスを必要なら変換し、区切り文字でつないでクリップボードにコピー
            string sepChar = comboBoxSepChar.Text;
            if (sepCharTable.ContainsKey(sepChar))
            {
                sepChar = sepCharTable[sepChar];
            }

            string[] files = textBoxFiles.Text.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => convPath(s)).ToArray();

            string concatPath = string.Join(sepChar, files);

            Clipboard.SetText(concatPath);
        }

        private void buttonCdCopy_Click(object sender, EventArgs e)
        {
            string baseDirectory = textBoxBaseDirectory.Text;
            if (baseDirectory.Length > 0)
            {
                Clipboard.SetText("cd " + baseDirectory);
            }
        }

        private void textBoxBaseDirectory_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (files.Length > 0)
            {
                textBoxBaseDirectory.Text = files[0];
            }
        }

        private void textBoxBaseDirectory_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
        }

        private void textBoxBaseDirectory_TextChanged(object sender, EventArgs e)
        {
            checkBoxRelativePath.Checked = true;
        }
    }
}
