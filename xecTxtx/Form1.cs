namespace xecTxtx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Ù˚‚ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogINmenu = new OpenFileDialog();
            openFileDialogINmenu.Filter = "Text files (*.txt)|*.txt|ALL files (*.*)|*.*";
            if (openFileDialogINmenu.ShowDialog() == DialogResult.OK)
            {
                rtbText.LoadFile(openFileDialogINmenu.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void BFileClose_Click(object sender, EventArgs e)
        {
            rtbText.Clear();
        }


        private void ediToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bHelp_Click(object sender, EventArgs e)
        {
            WindowHelp formaHElp = new WindowHelp();
            formaHElp.Show();
        }

        private void bPaste_Click(object sender, EventArgs e)
        {
            rtbText.Paste();
        }

        private void bCut_Click(object sender, EventArgs e)
        {
            rtbText.Cut();
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            rtbText.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Copy();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Paste();
        }

        private void bFileNew_Click(object sender, EventArgs e)
        {
            rtbText.Clear();
        }

        private void bFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|ALL files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbText.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void bFileClose_Click(object sender, EventArgs e)
        {
            rtbText.Clear();
        }

        private void bFileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.text)| *.text|ALL files (*.*)|*.*";
            saveFileDialog.Title = "saved file ";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, rtbText.Text);
                    MessageBox.Show("save successful ", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("save ERROR " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Ù‚ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Clear();
        }

        private void Ù˚‚ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.text)| *.text|ALL files (*.*)|*.*";
            saveFileDialog.Title = "saved file ";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, rtbText.Text);
                    MessageBox.Show("save successful ", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("save ERROR " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.text)| *.text|ALL files (*.*)|*.*";
            saveFileDialog.Title = "saved file ";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, rtbText.Text);
                    MessageBox.Show("save successful ", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("save ERROR " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}