using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Link_2
{
    public partial class Form3 : Form
    {
        private Boolean txtNoteChange;       // 내용 변경 확인
        private string finds;           //찾기 문자열

        private Form1 form1;

        private static Form2 s_form2 = new Form2();

        public static Form2 form2 { get { return s_form2; } }

        public Form3()
        {
            InitializeComponent();
        }
        //열기
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(txtNoteChange == true)
            {
                var msg = Text + " 파일 내용이 변경 되었습니다. \r\n" +
                    "변경된 내용을 저장하시겠습니까?";
                var dir = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if(dir == DialogResult.Yes)
                {
                    textSave();
                    textOpen();
                }
            }
            else
            {
                textOpen();
            }
        }

        private void textOpen()
        {
            var dir = openFileDialog1.ShowDialog();
            if(dir == DialogResult.OK)
            {
                var str = openFileDialog1.FileName;
                var sr = new StreamReader(str, System.Text.Encoding.Default);
                txtNote.Text = sr.ReadToEnd();
                sr.Close();

                var f = new FileInfo(str);
                Text = f.Name;
                txtNoteChange = false;
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textSave();
        }

        private void textSave()
        {

            if(Text == "메모장")
            {
                DialogResult dialogResult = saveFileDialog1.ShowDialog();
                if(dialogResult != DialogResult.Cancel)
                {
                    string str = saveFileDialog1.FileName;

                    StreamWriter sw = new StreamWriter(str, false, System.Text.Encoding.Default);
                    sw.Write(txtNote.Text);
                    sw.Flush();
                    sw.Close();

                    FileInfo fi = new FileInfo(str);
                    Text = fi.Name;
                    txtNoteChange = false;
                }
            }
            else
            {
                string str = Text;
                StreamWriter sw = new StreamWriter(str, false, System.Text.Encoding.Default);

                sw.Write(txtNote.Text);
                sw.Flush();
                sw.Close();

                Text = str;
                txtNoteChange = false;
            }
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            txtNoteChange = true;
        }

        private void 붙혀넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Paste();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //요거 조건문 맞는지 다시 확인
            if (txtNoteChange == true)
            {
                var msg = Text + " 파일 내용이 변경 되었습니다. \r\n" +
                    "변경된 내용을 저장하시겠습니까?";
                var dir = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dir == DialogResult.Yes)
                {
                    textSave();
                    txtNote.ResetText();
                    Text = "메모장";
                    txtNoteChange = false;
                }
                else if (dir == DialogResult.No)
                {
                    txtNote.ResetText();
                    Text = "메모장";
                    txtNoteChange = false;
                }
                else if (dir == DialogResult.Cancel) {return;}
                else {return;}
            }
            else
            {
                txtNote.ResetText();
                Text = "메모장";
                txtNoteChange = false;
            }
        }

        private void 다름이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dir = saveFileDialog1.ShowDialog();
            if(dir == DialogResult.Yes)
            {
                var str = saveFileDialog1.FileName;
                var sw = new StreamWriter(str, false, System.Text.Encoding.Default);
                sw.Write(txtNote.Text);
                sw.Flush();
                sw.Close();

                var fileInfo = new FileInfo(str);
                this.Text = fileInfo.Name;
                txtNoteChange = false;
            }
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "닫을꺼?";
            var q = MessageBox.Show(text, "A",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Application.Exit();
        }

        private void 자동줄바꿈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.WordWrap = !(txtNote.WordWrap);
            자동줄바꿈ToolStripMenuItem.Checked = txtNote.WordWrap;
        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dir = fontDialog1.ShowDialog();
            if(dir == DialogResult.OK)
            {
                txtNote.Font = fontDialog1.Font;
            }
        }

        private void 찾기FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(form1 == null || !form1.Visible))
            {
                form1.Focus();
                return;
            }

            form1 = new Form1();

            if(txtNote.SelectionLength == 0) 
            {
                MessageBox.Show("단어를 선택하세요");
            }
            else
            {
                form1.txtWord.Text = txtNote.SelectedText;
            }

            form1.btnOK.Click += new System.EventHandler(btnOK_Click);

            form1.Show();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var updown = -1;
            var str = txtNote.Text;
            var findWord = form1.txtWord.Text;

            if (form1.chkBox.Checked)
            {
                str = str.ToUpper();
                findWord = findWord.ToUpper();
            }
            if (form1.rbtnUp.Checked)
            {
                if(txtNote.SelectionStart != 0)
                {
                    updown = str.LastIndexOf(findWord, txtNote.SelectionStart - 1);
                }
            }
            else
            {
                updown = str.IndexOf(findWord, txtNote.SelectionStart + txtNote.SelectionLength);
            }
            if(updown == -1)
            {
                MessageBox.Show("더 이상 찾는 문자열이 없습니다", "찾기", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtNote.Select(updown, findWord.Length);
            findWord = form1.txtWord.Text;
            txtNote.Focus();
            txtNote.ScrollToCaret();
        }

        private void 실행취소UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Undo();
                
        }

        private void 잘라내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Cut();
        }

        private void 복사CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Copy();
        }

        private void 삭제LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.SelectedText = "";
        }

        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.SelectAll();
        }

        private void 시간날짜DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToShortTimeString();
            var day = DateTime.Now.ToShortDateString();
            txtNote.AppendText("\n" + time + " , " + day);
        }

        private void 메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }
    }
}
