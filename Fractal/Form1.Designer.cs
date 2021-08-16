namespace Fractal
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
            this.components = new System.ComponentModel.Container();
            this.FracIcon = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fracBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fractalDataSet1 = new Fractal.FractalDataSet1();
            this.fracTableAdapter1 = new Fractal.FractalDataSet1TableAdapters.fracTableAdapter();
            this.fracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errortext = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ewrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.werToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cбросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fracBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fractalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortext)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FracIcon
            // 
            this.FracIcon.AccumBits = ((byte)(0));
            this.FracIcon.AutoCheckErrors = false;
            this.FracIcon.AutoFinish = false;
            this.FracIcon.AutoMakeCurrent = true;
            this.FracIcon.AutoSize = true;
            this.FracIcon.AutoSwapBuffers = true;
            this.FracIcon.BackColor = System.Drawing.Color.Black;
            this.FracIcon.ColorBits = ((byte)(32));
            this.FracIcon.DepthBits = ((byte)(16));
            this.FracIcon.Location = new System.Drawing.Point(12, 12);
            this.FracIcon.Name = "FracIcon";
            this.FracIcon.Size = new System.Drawing.Size(821, 611);
            this.FracIcon.StencilBits = ((byte)(0));
            this.FracIcon.TabIndex = 0;
            this.FracIcon.ClientSizeChanged += new System.EventHandler(this.FracIcon_ClientSizeChanged);
            // 
            // button1
            // 
            this.helpProvider1.SetHelpString(this.button1, "Activation");
            this.button1.Location = new System.Drawing.Point(839, 2);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(270, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "TAO OPENGL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.helpProvider1.SetHelpString(this.trackBar1, "Scale");
            this.trackBar1.Location = new System.Drawing.Point(941, 216);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.helpProvider1.SetShowHelp(this.trackBar1, true);
            this.trackBar1.Size = new System.Drawing.Size(45, 407);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.Track);
            this.trackBar1.ValueChanged += new System.EventHandler(this.Track);
            // 
            // trackBar2
            // 
            this.trackBar2.Enabled = false;
            this.helpProvider1.SetHelpString(this.trackBar2, "Y");
            this.trackBar2.Location = new System.Drawing.Point(890, 216);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.helpProvider1.SetShowHelp(this.trackBar2, true);
            this.trackBar2.Size = new System.Drawing.Size(45, 407);
            this.trackBar2.TabIndex = 3;
            this.trackBar2.Value = 20;
            this.trackBar2.Scroll += new System.EventHandler(this.Track);
            this.trackBar2.ValueChanged += new System.EventHandler(this.Track);
            // 
            // trackBar3
            // 
            this.trackBar3.Enabled = false;
            this.helpProvider1.SetHelpString(this.trackBar3, "Detail");
            this.trackBar3.Location = new System.Drawing.Point(1043, 216);
            this.trackBar3.Maximum = 7;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.helpProvider1.SetShowHelp(this.trackBar3, true);
            this.trackBar3.Size = new System.Drawing.Size(45, 407);
            this.trackBar3.TabIndex = 4;
            this.trackBar3.Value = 7;
            this.trackBar3.Scroll += new System.EventHandler(this.Track);
            this.trackBar3.ValueChanged += new System.EventHandler(this.Track);
            // 
            // trackBar4
            // 
            this.trackBar4.Enabled = false;
            this.helpProvider1.SetHelpString(this.trackBar4, "X");
            this.trackBar4.Location = new System.Drawing.Point(839, 216);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.helpProvider1.SetShowHelp(this.trackBar4, true);
            this.trackBar4.Size = new System.Drawing.Size(45, 407);
            this.trackBar4.TabIndex = 5;
            this.trackBar4.Value = 20;
            this.trackBar4.Scroll += new System.EventHandler(this.Track);
            this.trackBar4.ValueChanged += new System.EventHandler(this.Track);
            // 
            // trackBar5
            // 
            this.trackBar5.Enabled = false;
            this.helpProvider1.SetHelpString(this.trackBar5, "Rotate");
            this.trackBar5.Location = new System.Drawing.Point(992, 216);
            this.trackBar5.Maximum = 100;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.helpProvider1.SetShowHelp(this.trackBar5, true);
            this.trackBar5.Size = new System.Drawing.Size(45, 407);
            this.trackBar5.TabIndex = 6;
            this.trackBar5.Value = 1;
            this.trackBar5.Scroll += new System.EventHandler(this.Track);
            this.trackBar5.ValueChanged += new System.EventHandler(this.Track);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.helpProvider1.SetHelpString(this.button2, "Color");
            this.button2.Location = new System.Drawing.Point(839, 187);
            this.button2.Name = "button2";
            this.helpProvider1.SetShowHelp(this.button2, true);
            this.button2.Size = new System.Drawing.Size(270, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Цвет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.a1DataGridViewTextBoxColumn,
            this.a2DataGridViewTextBoxColumn,
            this.a3DataGridViewTextBoxColumn,
            this.a4DataGridViewTextBoxColumn,
            this.a5DataGridViewTextBoxColumn,
            this.rDataGridViewTextBoxColumn,
            this.gDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fracBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(839, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(270, 156);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // fracBindingSource1
            // 
            this.fracBindingSource1.DataMember = "frac";
            this.fracBindingSource1.DataSource = this.fractalDataSet1;
            // 
            // fractalDataSet1
            // 
            this.fractalDataSet1.DataSetName = "FractalDataSet1";
            this.fractalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fracTableAdapter1
            // 
            this.fracTableAdapter1.ClearBeforeFill = true;
            // 
            // errortext
            // 
            this.errortext.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ewToolStripMenuItem,
            this.ewrToolStripMenuItem,
            this.werToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1128, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(83, 826);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ewToolStripMenuItem
            // 
            this.ewToolStripMenuItem.Name = "ewToolStripMenuItem";
            this.ewToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
            this.ewToolStripMenuItem.Text = "Cохранить";
            this.ewToolStripMenuItem.Click += new System.EventHandler(this.ewToolStripMenuItem_Click);
            // 
            // ewrToolStripMenuItem
            // 
            this.ewrToolStripMenuItem.Name = "ewrToolStripMenuItem";
            this.ewrToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
            this.ewrToolStripMenuItem.Text = "Загрузить";
            this.ewrToolStripMenuItem.Click += new System.EventHandler(this.ewrToolStripMenuItem_Click);
            // 
            // werToolStripMenuItem
            // 
            this.werToolStripMenuItem.Name = "werToolStripMenuItem";
            this.werToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
            this.werToolStripMenuItem.Text = "Записать";
            this.werToolStripMenuItem.Click += new System.EventHandler(this.werToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 804);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1128, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabel1.Text = "ЦП";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel2.Text = "Оперативная память";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(840, 632);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.Track);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(890, 632);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown2.TabIndex = 15;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.Track);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(941, 632);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown3.TabIndex = 16;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.Track);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(992, 632);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown4.TabIndex = 17;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.Track);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(1043, 632);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown5.TabIndex = 18;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.Track);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cбросToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
            // 
            // cбросToolStripMenuItem
            // 
            this.cбросToolStripMenuItem.Name = "cбросToolStripMenuItem";
            this.cбросToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cбросToolStripMenuItem.Text = "Cброс";
            this.cбросToolStripMenuItem.Click += new System.EventHandler(this.cбросToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(13, 629);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button7);
            this.splitContainer1.Panel1.Controls.Add(this.button6);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(820, 172);
            this.splitContainer1.SplitterDistance = 117;
            this.splitContainer1.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(4, 124);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "Search";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(4, 94);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Refresh";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Forward";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(699, 172);
            this.webBrowser1.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.Frozen = true;
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // a1DataGridViewTextBoxColumn
            // 
            this.a1DataGridViewTextBoxColumn.DataPropertyName = "a1";
            this.a1DataGridViewTextBoxColumn.HeaderText = "a1";
            this.a1DataGridViewTextBoxColumn.Name = "a1DataGridViewTextBoxColumn";
            // 
            // a2DataGridViewTextBoxColumn
            // 
            this.a2DataGridViewTextBoxColumn.DataPropertyName = "a2";
            this.a2DataGridViewTextBoxColumn.HeaderText = "a2";
            this.a2DataGridViewTextBoxColumn.Name = "a2DataGridViewTextBoxColumn";
            // 
            // a3DataGridViewTextBoxColumn
            // 
            this.a3DataGridViewTextBoxColumn.DataPropertyName = "a3";
            this.a3DataGridViewTextBoxColumn.HeaderText = "a3";
            this.a3DataGridViewTextBoxColumn.Name = "a3DataGridViewTextBoxColumn";
            // 
            // a4DataGridViewTextBoxColumn
            // 
            this.a4DataGridViewTextBoxColumn.DataPropertyName = "a4";
            this.a4DataGridViewTextBoxColumn.HeaderText = "a4";
            this.a4DataGridViewTextBoxColumn.Name = "a4DataGridViewTextBoxColumn";
            // 
            // a5DataGridViewTextBoxColumn
            // 
            this.a5DataGridViewTextBoxColumn.DataPropertyName = "a5";
            this.a5DataGridViewTextBoxColumn.HeaderText = "a5";
            this.a5DataGridViewTextBoxColumn.Name = "a5DataGridViewTextBoxColumn";
            // 
            // rDataGridViewTextBoxColumn
            // 
            this.rDataGridViewTextBoxColumn.DataPropertyName = "r";
            this.rDataGridViewTextBoxColumn.HeaderText = "r";
            this.rDataGridViewTextBoxColumn.Name = "rDataGridViewTextBoxColumn";
            // 
            // gDataGridViewTextBoxColumn
            // 
            this.gDataGridViewTextBoxColumn.DataPropertyName = "g";
            this.gDataGridViewTextBoxColumn.HeaderText = "g";
            this.gDataGridViewTextBoxColumn.Name = "gDataGridViewTextBoxColumn";
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "b";
            this.bDataGridViewTextBoxColumn.HeaderText = "b";
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Fractal.Properties.Resources._5746a1af645a9154ebe79533;
            this.ClientSize = new System.Drawing.Size(1211, 826);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FracIcon);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fracBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fractalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortext)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl FracIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fracBindingSource;
        private FractalDataSet1 fractalDataSet1;
        private System.Windows.Forms.BindingSource fracBindingSource1;
        private FractalDataSet1TableAdapters.fracTableAdapter fracTableAdapter1;
        private System.Windows.Forms.ErrorProvider errortext;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ewrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem werToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cбросToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn a1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn a2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn a3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn a4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn a5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
    }
}

