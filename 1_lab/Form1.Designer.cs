namespace _1_lab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt1 = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.mc = new System.Windows.Forms.MonthCalendar();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.rbenable = new System.Windows.Forms.RadioButton();
            this.cbXYcoord = new System.Windows.Forms.CheckBox();
            this.Xcoord = new System.Windows.Forms.Label();
            this.Ycoord = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lbIndex = new System.Windows.Forms.Label();
            this.lbText = new System.Windows.Forms.Label();
            this.cBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cBoxlist = new System.Windows.Forms.ComboBox();
            this.tBox1 = new System.Windows.Forms.TextBox();
            this.tBoxlist = new System.Windows.Forms.TextBox();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.rTBox = new System.Windows.Forms.RichTextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.rbneenable = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.tBoxSurname = new System.Windows.Forms.TextBox();
            this.btadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(81, 27);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "Зарядка";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(81, 96);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(80, 17);
            this.cb1.TabIndex = 3;
            this.cb1.Text = "CheckItOut";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // mc
            // 
            this.mc.Location = new System.Drawing.Point(81, 125);
            this.mc.MaxSelectionCount = 1;
            this.mc.Name = "mc";
            this.mc.TabIndex = 11;
            this.mc.TabStop = false;
            this.mc.TodayDate = new System.DateTime(2019, 9, 10, 0, 0, 0, 0);
            this.mc.Visible = false;
            this.mc.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mc_DateChanged);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(81, 63);
            this.pb1.Maximum = 31;
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 23);
            this.pb1.TabIndex = 14;
            // 
            // rbenable
            // 
            this.rbenable.AutoSize = true;
            this.rbenable.Checked = true;
            this.rbenable.Location = new System.Drawing.Point(662, 73);
            this.rbenable.Name = "rbenable";
            this.rbenable.Size = new System.Drawing.Size(58, 17);
            this.rbenable.TabIndex = 15;
            this.rbenable.TabStop = true;
            this.rbenable.Text = "Enable";
            this.rbenable.UseVisualStyleBackColor = true;
            this.rbenable.CheckedChanged += new System.EventHandler(this.rbenable_CheckedChanged);
            // 
            // cbXYcoord
            // 
            this.cbXYcoord.AutoSize = true;
            this.cbXYcoord.Location = new System.Drawing.Point(79, 299);
            this.cbXYcoord.Name = "cbXYcoord";
            this.cbXYcoord.Size = new System.Drawing.Size(76, 17);
            this.cbXYcoord.TabIndex = 18;
            this.cbXYcoord.Text = "Visible X,Y";
            this.cbXYcoord.UseVisualStyleBackColor = true;
            this.cbXYcoord.CheckedChanged += new System.EventHandler(this.cbXYcoord_CheckedChanged);
            // 
            // Xcoord
            // 
            this.Xcoord.AutoSize = true;
            this.Xcoord.Location = new System.Drawing.Point(81, 323);
            this.Xcoord.Name = "Xcoord";
            this.Xcoord.Size = new System.Drawing.Size(35, 13);
            this.Xcoord.TabIndex = 19;
            this.Xcoord.Text = "label1";
            this.Xcoord.Visible = false;
            // 
            // Ycoord
            // 
            this.Ycoord.AutoSize = true;
            this.Ycoord.Location = new System.Drawing.Point(81, 340);
            this.Ycoord.Name = "Ycoord";
            this.Ycoord.Size = new System.Drawing.Size(35, 13);
            this.Ycoord.TabIndex = 20;
            this.Ycoord.Text = "label2";
            this.Ycoord.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.checkedListBox1.Location = new System.Drawing.Point(79, 441);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(166, 79);
            this.checkedListBox1.TabIndex = 21;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.checkedListBox1.DoubleClick += new System.EventHandler(this.checkedListBox1_DoubleClick);
            // 
            // lbIndex
            // 
            this.lbIndex.AutoSize = true;
            this.lbIndex.Location = new System.Drawing.Point(78, 556);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(33, 13);
            this.lbIndex.TabIndex = 22;
            this.lbIndex.Text = "Index";
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(133, 556);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(28, 13);
            this.lbText.TabIndex = 23;
            this.lbText.Text = "Text";
            // 
            // cBox1
            // 
            this.cBox1.FormattingEnabled = true;
            this.cBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBox1.Location = new System.Drawing.Point(270, 441);
            this.cBox1.Name = "cBox1";
            this.cBox1.Size = new System.Drawing.Size(121, 21);
            this.cBox1.TabIndex = 24;
            this.cBox1.Text = "Index";
            this.cBox1.SelectedIndexChanged += new System.EventHandler(this.cBoxС_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(314, 109);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 95);
            this.listBox1.TabIndex = 25;
            // 
            // cBoxlist
            // 
            this.cBoxlist.FormattingEnabled = true;
            this.cBoxlist.Items.AddRange(new object[] {
            "1"});
            this.cBoxlist.Location = new System.Drawing.Point(314, 63);
            this.cBoxlist.Name = "cBoxlist";
            this.cBoxlist.Size = new System.Drawing.Size(121, 21);
            this.cBoxlist.TabIndex = 26;
            this.cBoxlist.Text = "AddToListBox1";
            this.cBoxlist.SelectedIndexChanged += new System.EventHandler(this.cBoxlist_SelectedIndexChanged);
            // 
            // tBox1
            // 
            this.tBox1.Location = new System.Drawing.Point(270, 468);
            this.tBox1.Name = "tBox1";
            this.tBox1.Size = new System.Drawing.Size(100, 20);
            this.tBox1.TabIndex = 27;
            this.tBox1.Text = "TextForCheckedLB";
            // 
            // tBoxlist
            // 
            this.tBoxlist.Location = new System.Drawing.Point(314, 27);
            this.tBoxlist.Name = "tBoxlist";
            this.tBoxlist.Size = new System.Drawing.Size(100, 20);
            this.tBoxlist.TabIndex = 28;
            this.tBoxlist.Text = "AddToComboBox";
            this.tBoxlist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxlist_KeyDown);
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(642, 125);
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(120, 20);
            this.nud.TabIndex = 31;
            this.nud.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // rTBox
            // 
            this.rTBox.Location = new System.Drawing.Point(642, 163);
            this.rTBox.Name = "rTBox";
            this.rTBox.Size = new System.Drawing.Size(100, 96);
            this.rTBox.TabIndex = 32;
            this.rTBox.Text = "";
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(560, 283);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(219, 193);
            this.picBox.TabIndex = 33;
            this.picBox.TabStop = false;
            this.picBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseClick);
            // 
            // rbneenable
            // 
            this.rbneenable.AutoSize = true;
            this.rbneenable.Location = new System.Drawing.Point(662, 96);
            this.rbneenable.Name = "rbneenable";
            this.rbneenable.Size = new System.Drawing.Size(72, 17);
            this.rbneenable.TabIndex = 34;
            this.rbneenable.Text = "NeEnable";
            this.rbneenable.UseVisualStyleBackColor = true;
            this.rbneenable.CheckedChanged += new System.EventHandler(this.rbneenable_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name1,
            this.Surname});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(877, 255);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(214, 133);
            this.listView1.TabIndex = 35;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Name1
            // 
            this.Name1.Text = "NameNormalno";
            this.Name1.Width = 92;
            // 
            // Surname
            // 
            this.Surname.Text = "SurnameNormalno";
            this.Surname.Width = 108;
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(877, 184);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(100, 20);
            this.tBoxName.TabIndex = 36;
            this.tBoxName.Text = "Name";
            // 
            // tBoxSurname
            // 
            this.tBoxSurname.Location = new System.Drawing.Point(991, 184);
            this.tBoxSurname.Name = "tBoxSurname";
            this.tBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.tBoxSurname.TabIndex = 37;
            this.tBoxSurname.Text = "Surname";
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(942, 223);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 38;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 604);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.tBoxSurname);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.rbneenable);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.rTBox);
            this.Controls.Add(this.nud);
            this.Controls.Add(this.tBoxlist);
            this.Controls.Add(this.tBox1);
            this.Controls.Add(this.cBoxlist);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cBox1);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.lbIndex);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Ycoord);
            this.Controls.Add(this.Xcoord);
            this.Controls.Add(this.cbXYcoord);
            this.Controls.Add(this.rbenable);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.mc);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.bt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.MonthCalendar mc;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.RadioButton rbenable;
        private System.Windows.Forms.CheckBox cbXYcoord;
        private System.Windows.Forms.Label Xcoord;
        private System.Windows.Forms.Label Ycoord;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lbIndex;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.ComboBox cBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cBoxlist;
        private System.Windows.Forms.TextBox tBox1;
        private System.Windows.Forms.TextBox tBoxlist;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.RichTextBox rTBox;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.RadioButton rbneenable;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name1;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.TextBox tBoxSurname;
        private System.Windows.Forms.Button btadd;
    
}
}

