namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_main = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lbl_rollNo = new System.Windows.Forms.Label();
            this.pnl_forButtons = new System.Windows.Forms.Panel();
            this.btn_bold = new System.Windows.Forms.Label();
            this.btn_itallic = new System.Windows.Forms.Label();
            this.btn_underline = new System.Windows.Forms.Label();
            this.lbl_font = new System.Windows.Forms.Label();
            this.cbx_font = new System.Windows.Forms.ComboBox();
            this.cbx_size = new System.Windows.Forms.ComboBox();
            this.lbl_size = new System.Windows.Forms.Label();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.pnl_forButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.backColorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Fore &Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backColorToolStripMenuItem.Text = "&Back Color";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.backColorToolStripMenuItem_Click);
            // 
            // txt_main
            // 
            this.txt_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_main.Location = new System.Drawing.Point(0, 46);
            this.txt_main.Multiline = true;
            this.txt_main.Name = "txt_main";
            this.txt_main.Size = new System.Drawing.Size(800, 404);
            this.txt_main.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text Documents |*.txt";
            // 
            // lbl_rollNo
            // 
            this.lbl_rollNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_rollNo.AutoSize = true;
            this.lbl_rollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rollNo.Location = new System.Drawing.Point(713, 8);
            this.lbl_rollNo.Name = "lbl_rollNo";
            this.lbl_rollNo.Size = new System.Drawing.Size(81, 13);
            this.lbl_rollNo.TabIndex = 3;
            this.lbl_rollNo.Text = "2021 - CS - 122";
            // 
            // pnl_forButtons
            // 
            this.pnl_forButtons.Controls.Add(this.cbx_size);
            this.pnl_forButtons.Controls.Add(this.lbl_size);
            this.pnl_forButtons.Controls.Add(this.cbx_font);
            this.pnl_forButtons.Controls.Add(this.lbl_font);
            this.pnl_forButtons.Controls.Add(this.btn_underline);
            this.pnl_forButtons.Controls.Add(this.btn_itallic);
            this.pnl_forButtons.Controls.Add(this.btn_bold);
            this.pnl_forButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_forButtons.Location = new System.Drawing.Point(0, 24);
            this.pnl_forButtons.Name = "pnl_forButtons";
            this.pnl_forButtons.Size = new System.Drawing.Size(800, 24);
            this.pnl_forButtons.TabIndex = 4;
            // 
            // btn_bold
            // 
            this.btn_bold.AutoSize = true;
            this.btn_bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bold.Location = new System.Drawing.Point(13, 5);
            this.btn_bold.Name = "btn_bold";
            this.btn_bold.Size = new System.Drawing.Size(15, 13);
            this.btn_bold.TabIndex = 0;
            this.btn_bold.Text = "B";
            this.btn_bold.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_itallic
            // 
            this.btn_itallic.AutoSize = true;
            this.btn_itallic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_itallic.Location = new System.Drawing.Point(34, 5);
            this.btn_itallic.Name = "btn_itallic";
            this.btn_itallic.Size = new System.Drawing.Size(10, 13);
            this.btn_itallic.TabIndex = 1;
            this.btn_itallic.Text = "I";
            this.btn_itallic.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_underline
            // 
            this.btn_underline.AutoSize = true;
            this.btn_underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_underline.Location = new System.Drawing.Point(55, 5);
            this.btn_underline.Name = "btn_underline";
            this.btn_underline.Size = new System.Drawing.Size(15, 13);
            this.btn_underline.TabIndex = 2;
            this.btn_underline.Text = "U";
            this.btn_underline.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_font
            // 
            this.lbl_font.AutoSize = true;
            this.lbl_font.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_font.Location = new System.Drawing.Point(94, 5);
            this.lbl_font.Name = "lbl_font";
            this.lbl_font.Size = new System.Drawing.Size(60, 13);
            this.lbl_font.TabIndex = 3;
            this.lbl_font.Text = "Font Family";
            // 
            // cbx_font
            // 
            this.cbx_font.FormattingEnabled = true;
            this.cbx_font.Items.AddRange(new object[] {
            "Algerian",
            "Argon PERSONAL",
            "Arial",
            "Arial Rounded MT",
            "Bahnschrift",
            "Berlin Sans FB",
            "Blackadder ITC",
            "Bodoni MT Poster",
            "Bradley Hand ITC",
            "Broadway",
            "Calibri",
            "Californian FB",
            "Calisto MT",
            "Cascadia Code",
            "Century",
            "Chiller",
            "Comic Sans MS",
            "Dubai",
            "Edwardian Script ITC",
            "Elephant",
            "Footlight MT",
            "Forte",
            "Franklin Gothic",
            "Freestyle Script",
            "Gabriola",
            "Georgia",
            "Gill Sans",
            "Harlow Solid",
            "Informal Roman",
            "Ink Free",
            "Latin",
            "Matura MT Script Capitals",
            "Microsoft JhengHei",
            "Microsoft New Tai Lue",
            "Microsoft Uighur",
            "MingLiU_HKSCS-ExtB",
            "Mistral",
            "Modern No. 20",
            "Mongolian Baiti",
            "Monotype Corsiva",
            "Old English Text MT",
            "Palace Script MT",
            "Palatino Linotype",
            "Papyrus",
            "Perpetua",
            "Pristina",
            "Rage",
            "Script MT",
            "Segoe UI",
            "Snap ITC",
            "Vivaldi",
            "Vladimir Script",
            "Webdings"});
            this.cbx_font.Location = new System.Drawing.Point(161, 1);
            this.cbx_font.Name = "cbx_font";
            this.cbx_font.Size = new System.Drawing.Size(124, 21);
            this.cbx_font.TabIndex = 4;
            this.cbx_font.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbx_size
            // 
            this.cbx_size.FormattingEnabled = true;
            this.cbx_size.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "18",
            "20",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40",
            "42",
            "44",
            "46",
            "48",
            "50",
            "52",
            "54",
            "56",
            "58",
            "60",
            "62",
            "64",
            "66",
            "68",
            "70",
            "72"});
            this.cbx_size.Location = new System.Drawing.Point(358, 2);
            this.cbx_size.Name = "cbx_size";
            this.cbx_size.Size = new System.Drawing.Size(47, 21);
            this.cbx_size.TabIndex = 6;
            this.cbx_size.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.Location = new System.Drawing.Point(291, 7);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(51, 13);
            this.lbl_size.TabIndex = 5;
            this.lbl_size.Text = "Font Size";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myInfoToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // myInfoToolStripMenuItem
            // 
            this.myInfoToolStripMenuItem.Name = "myInfoToolStripMenuItem";
            this.myInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.myInfoToolStripMenuItem.Text = "MyInfo";
            this.myInfoToolStripMenuItem.Click += new System.EventHandler(this.myInfoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_forButtons);
            this.Controls.Add(this.lbl_rollNo);
            this.Controls.Add(this.txt_main);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Custom Notepad by M Faraz Ali";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.pnl_forButtons.ResumeLayout(false);
            this.pnl_forButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_main;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lbl_rollNo;
        private System.Windows.Forms.Panel pnl_forButtons;
        private System.Windows.Forms.Label btn_underline;
        private System.Windows.Forms.Label btn_itallic;
        private System.Windows.Forms.Label btn_bold;
        private System.Windows.Forms.ComboBox cbx_size;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.ComboBox cbx_font;
        private System.Windows.Forms.Label lbl_font;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myInfoToolStripMenuItem;
    }
}

