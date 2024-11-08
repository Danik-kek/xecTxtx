namespace xecTxtx
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            фвToolStripMenuItem = new ToolStripMenuItem();
            фывToolStripMenuItem = new ToolStripMenuItem();
            фывToolStripMenuItem1 = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            фыаToolStripMenuItem = new ToolStripMenuItem();
            ediToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            insertToolStripMenuItem = new ToolStripMenuItem();
            pToolBar = new Panel();
            bExit = new Button();
            bHelp = new Button();
            bPaste = new Button();
            bCopy = new Button();
            bCut = new Button();
            bFileClose = new Button();
            bFileSave = new Button();
            bFileOpen = new Button();
            bFileNew = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            toolTip1 = new ToolTip(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            rtbText = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFD = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            pToolBar.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, фыаToolStripMenuItem, ediToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { фвToolStripMenuItem, фывToolStripMenuItem, фывToolStripMenuItem1, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // фвToolStripMenuItem
            // 
            фвToolStripMenuItem.Name = "фвToolStripMenuItem";
            фвToolStripMenuItem.Size = new Size(180, 22);
            фвToolStripMenuItem.Text = "&New Ctrl+N";
            фвToolStripMenuItem.Click += фвToolStripMenuItem_Click;
            // 
            // фывToolStripMenuItem
            // 
            фывToolStripMenuItem.Name = "фывToolStripMenuItem";
            фывToolStripMenuItem.Size = new Size(180, 22);
            фывToolStripMenuItem.Text = "&Open Ctrl+O";
            фывToolStripMenuItem.Click += фывToolStripMenuItem_Click;
            // 
            // фывToolStripMenuItem1
            // 
            фывToolStripMenuItem1.Name = "фывToolStripMenuItem1";
            фывToolStripMenuItem1.Size = new Size(180, 22);
            фывToolStripMenuItem1.Text = "&Save Ctrl+S";
            фывToolStripMenuItem1.Click += фывToolStripMenuItem1_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // фыаToolStripMenuItem
            // 
            фыаToolStripMenuItem.Name = "фыаToolStripMenuItem";
            фыаToolStripMenuItem.Size = new Size(44, 20);
            фыаToolStripMenuItem.Text = "Viwe";
            // 
            // ediToolStripMenuItem
            // 
            ediToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, insertToolStripMenuItem });
            ediToolStripMenuItem.Name = "ediToolStripMenuItem";
            ediToolStripMenuItem.Size = new Size(56, 20);
            ediToolStripMenuItem.Text = "Editing";
            ediToolStripMenuItem.Click += ediToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(140, 22);
            cutToolStripMenuItem.Text = "&Cut Ctrl+X";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(140, 22);
            copyToolStripMenuItem.Text = "&Copy Ctrl+C";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(140, 22);
            insertToolStripMenuItem.Text = "&Paste Ctrl+V";
            insertToolStripMenuItem.Click += insertToolStripMenuItem_Click;
            // 
            // pToolBar
            // 
            pToolBar.Controls.Add(bExit);
            pToolBar.Controls.Add(bHelp);
            pToolBar.Controls.Add(bPaste);
            pToolBar.Controls.Add(bCopy);
            pToolBar.Controls.Add(bCut);
            pToolBar.Controls.Add(bFileClose);
            pToolBar.Controls.Add(bFileSave);
            pToolBar.Controls.Add(bFileOpen);
            pToolBar.Controls.Add(bFileNew);
            pToolBar.Dock = DockStyle.Top;
            pToolBar.Location = new Point(0, 24);
            pToolBar.Name = "pToolBar";
            pToolBar.Size = new Size(800, 57);
            pToolBar.TabIndex = 1;
            // 
            // bExit
            // 
            bExit.Location = new Point(668, 19);
            bExit.Name = "bExit";
            bExit.Size = new Size(25, 25);
            bExit.TabIndex = 8;
            bExit.Text = "X";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // bHelp
            // 
            bHelp.Location = new Point(575, 19);
            bHelp.Name = "bHelp";
            bHelp.Size = new Size(25, 25);
            bHelp.TabIndex = 7;
            bHelp.Text = "?";
            bHelp.UseVisualStyleBackColor = true;
            bHelp.Click += bHelp_Click;
            // 
            // bPaste
            // 
            bPaste.Location = new Point(395, 19);
            bPaste.Name = "bPaste";
            bPaste.Size = new Size(25, 25);
            bPaste.TabIndex = 6;
            bPaste.Text = "pha";
            bPaste.UseVisualStyleBackColor = true;
            bPaste.Click += bPaste_Click;
            // 
            // bCopy
            // 
            bCopy.Location = new Point(364, 19);
            bCopy.Name = "bCopy";
            bCopy.Size = new Size(25, 25);
            bCopy.TabIndex = 5;
            bCopy.Text = "коп";
            bCopy.UseVisualStyleBackColor = true;
            bCopy.Click += bCopy_Click;
            // 
            // bCut
            // 
            bCut.Location = new Point(333, 19);
            bCut.Name = "bCut";
            bCut.Size = new Size(25, 25);
            bCut.TabIndex = 4;
            bCut.Text = "cut";
            bCut.UseVisualStyleBackColor = true;
            bCut.Click += bCut_Click;
            // 
            // bFileClose
            // 
            bFileClose.Location = new Point(123, 19);
            bFileClose.Name = "bFileClose";
            bFileClose.Size = new Size(25, 25);
            bFileClose.TabIndex = 3;
            bFileClose.Text = "зак";
            bFileClose.UseVisualStyleBackColor = true;
            bFileClose.Click += bFileClose_Click;
            // 
            // bFileSave
            // 
            bFileSave.Location = new Point(92, 19);
            bFileSave.Name = "bFileSave";
            bFileSave.Size = new Size(25, 25);
            bFileSave.TabIndex = 2;
            bFileSave.Text = "Sв";
            bFileSave.UseVisualStyleBackColor = true;
            bFileSave.Click += bFileSave_Click;
            // 
            // bFileOpen
            // 
            bFileOpen.Location = new Point(61, 19);
            bFileOpen.Name = "bFileOpen";
            bFileOpen.Size = new Size(25, 25);
            bFileOpen.TabIndex = 1;
            bFileOpen.Text = "O";
            bFileOpen.UseVisualStyleBackColor = true;
            bFileOpen.Click += bFileOpen_Click;
            // 
            // bFileNew
            // 
            bFileNew.Image = (Image)resources.GetObject("bFileNew.Image");
            bFileNew.Location = new Point(30, 19);
            bFileNew.Name = "bFileNew";
            bFileNew.Size = new Size(25, 25);
            bFileNew.TabIndex = 0;
            bFileNew.UseVisualStyleBackColor = true;
            bFileNew.Click += bFileNew_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.GripStyle = ToolStripGripStyle.Visible;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "st";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(25, 17);
            toolStripStatusLabel1.Text = "too";
            // 
            // rtbText
            // 
            rtbText.Location = new Point(30, 101);
            rtbText.Name = "rtbText";
            rtbText.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbText.Size = new Size(570, 236);
            rtbText.TabIndex = 3;
            rtbText.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "RTF файлы | *.rtf";
            // 
            // saveFD
            // 
            saveFD.Filter = "RTF файлы | *.rtf";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbText);
            Controls.Add(statusStrip1);
            Controls.Add(pToolBar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pToolBar.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem фвToolStripMenuItem;
        private ToolStripMenuItem фывToolStripMenuItem;
        private ToolStripMenuItem фывToolStripMenuItem1;
        private ToolStripMenuItem фыаToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem ediToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem insertToolStripMenuItem;
        private Panel pToolBar;
        private Button bFileNew;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button bExit;
        private Button bHelp;
        private Button bPaste;
        private Button bCopy;
        private Button bCut;
        private Button bFileClose;
        private Button bFileSave;
        private Button bFileOpen;
        private ToolTip toolTip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private RichTextBox rtbText;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFD;
    }
}
