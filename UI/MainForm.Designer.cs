namespace FarmManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            AnimalTypeLabel = new Label();
            AgePickLabel = new Label();
            GenderPickLabel = new Label();
            AnimalTypeComboBox = new ComboBox();
            AgeComboBox = new ComboBox();
            GenderPickComboBox = new ComboBox();
            AddButton = new Button();
            SidePanel = new Panel();
            panel4 = new Panel();
            ExitButton = new Button();
            progressTimer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            circularProgressBar3 = new CircularProgressBar();
            circularProgressBar2 = new CircularProgressBar();
            label5 = new Label();
            circularProgressBar1 = new CircularProgressBar();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            tabPage2 = new TabPage();
            SidePanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // AnimalTypeLabel
            // 
            AnimalTypeLabel.AutoSize = true;
            AnimalTypeLabel.Location = new Point(12, 18);
            AnimalTypeLabel.Name = "AnimalTypeLabel";
            AnimalTypeLabel.Size = new Size(42, 19);
            AnimalTypeLabel.TabIndex = 0;
            AnimalTypeLabel.Text = "Type";
            // 
            // AgePickLabel
            // 
            AgePickLabel.AutoSize = true;
            AgePickLabel.Location = new Point(12, 79);
            AgePickLabel.Name = "AgePickLabel";
            AgePickLabel.Size = new Size(37, 19);
            AgePickLabel.TabIndex = 1;
            AgePickLabel.Text = "Age";
            // 
            // GenderPickLabel
            // 
            GenderPickLabel.AutoSize = true;
            GenderPickLabel.Location = new Point(12, 144);
            GenderPickLabel.Name = "GenderPickLabel";
            GenderPickLabel.Size = new Size(61, 19);
            GenderPickLabel.TabIndex = 2;
            GenderPickLabel.Text = "Gender";
            // 
            // AnimalTypeComboBox
            // 
            AnimalTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AnimalTypeComboBox.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnimalTypeComboBox.FormattingEnabled = true;
            AnimalTypeComboBox.Items.AddRange(new object[] { "Cow", "Chicken", "Sheep" });
            AnimalTypeComboBox.Location = new Point(12, 40);
            AnimalTypeComboBox.Name = "AnimalTypeComboBox";
            AnimalTypeComboBox.Size = new Size(81, 27);
            AnimalTypeComboBox.TabIndex = 3;
            // 
            // AgeComboBox
            // 
            AgeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AgeComboBox.FormattingEnabled = true;
            AgeComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            AgeComboBox.Location = new Point(12, 101);
            AgeComboBox.Name = "AgeComboBox";
            AgeComboBox.Size = new Size(81, 27);
            AgeComboBox.TabIndex = 4;
            // 
            // GenderPickComboBox
            // 
            GenderPickComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderPickComboBox.FormattingEnabled = true;
            GenderPickComboBox.Items.AddRange(new object[] { "Female", "Male" });
            GenderPickComboBox.Location = new Point(12, 166);
            GenderPickComboBox.Name = "GenderPickComboBox";
            GenderPickComboBox.Size = new Size(81, 27);
            GenderPickComboBox.TabIndex = 5;
            // 
            // AddButton
            // 
            AddButton.ForeColor = SystemColors.ControlText;
            AddButton.Location = new Point(12, 220);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(81, 29);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SidePanel
            // 
            SidePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SidePanel.BackColor = Color.RoyalBlue;
            SidePanel.Controls.Add(panel4);
            SidePanel.Controls.Add(ExitButton);
            SidePanel.Controls.Add(AddButton);
            SidePanel.Controls.Add(AgeComboBox);
            SidePanel.Controls.Add(GenderPickComboBox);
            SidePanel.Controls.Add(AnimalTypeLabel);
            SidePanel.Controls.Add(AgePickLabel);
            SidePanel.Controls.Add(AnimalTypeComboBox);
            SidePanel.Controls.Add(GenderPickLabel);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SidePanel.ForeColor = SystemColors.HighlightText;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(105, 479);
            SidePanel.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Location = new Point(103, 439);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 20);
            panel4.TabIndex = 14;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.RoyalBlue;
            ExitButton.Dock = DockStyle.Bottom;
            ExitButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ButtonHighlight;
            ExitButton.Location = new Point(0, 450);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(105, 29);
            ExitButton.TabIndex = 9;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // progressTimer
            // 
            progressTimer.Interval = 1000;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel5, 1, 2);
            tableLayoutPanel1.Controls.Add(tabControl1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(105, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(785, 479);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(392, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(393, 25);
            panel2.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(149, 1);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(97, 22);
            label2.TabIndex = 2;
            label2.Text = "Production";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 25);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(159, 1);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(73, 22);
            label1.TabIndex = 1;
            label1.Text = "Animals";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 25);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(4, 2, 0, 0);
            flowLayoutPanel1.Size = new Size(392, 429);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ScrollBar;
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 454);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(392, 25);
            panel3.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 2);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 1;
            label3.Text = "Total: ";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ScrollBar;
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(392, 454);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(393, 25);
            panel5.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 2);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 1;
            label4.Text = "Total: ";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(395, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(387, 423);
            tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(379, 390);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.4675941F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.6186628F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0641174F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.8496246F));
            tableLayoutPanel2.Controls.Add(pictureBox2, 2, 1);
            tableLayoutPanel2.Controls.Add(circularProgressBar3, 0, 2);
            tableLayoutPanel2.Controls.Add(circularProgressBar2, 0, 1);
            tableLayoutPanel2.Controls.Add(label5, 1, 0);
            tableLayoutPanel2.Controls.Add(circularProgressBar1, 0, 0);
            tableLayoutPanel2.Controls.Add(label6, 1, 1);
            tableLayoutPanel2.Controls.Add(label7, 1, 2);
            tableLayoutPanel2.Controls.Add(pictureBox1, 2, 0);
            tableLayoutPanel2.Controls.Add(pictureBox3, 2, 2);
            tableLayoutPanel2.Controls.Add(label8, 3, 0);
            tableLayoutPanel2.Controls.Add(label9, 3, 1);
            tableLayoutPanel2.Controls.Add(label10, 3, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33482F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3348122F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33037F));
            tableLayoutPanel2.Size = new Size(373, 384);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left;
            pictureBox2.Image = Properties.Resources.meat;
            pictureBox2.Location = new Point(208, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(98, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // circularProgressBar3
            // 
            circularProgressBar3.Anchor = AnchorStyles.None;
            circularProgressBar3.BackColor = SystemColors.Control;
            circularProgressBar3.BarColor1 = Color.SteelBlue;
            circularProgressBar3.BarColor2 = Color.Aquamarine;
            circularProgressBar3.BarWidth = 14F;
            circularProgressBar3.Font = new Font("Segoe UI", 15F);
            circularProgressBar3.ForeColor = Color.DimGray;
            circularProgressBar3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            circularProgressBar3.LineColor = Color.DimGray;
            circularProgressBar3.LineWidth = 1;
            circularProgressBar3.Location = new Point(11, 259);
            circularProgressBar3.Maximum = 100L;
            circularProgressBar3.MinimumSize = new Size(100, 100);
            circularProgressBar3.Name = "circularProgressBar3";
            circularProgressBar3.ProgressShape = CircularProgressBar._ProgressShape.Flat;
            circularProgressBar3.Size = new Size(125, 125);
            circularProgressBar3.TabIndex = 7;
            circularProgressBar3.Text = null;
            circularProgressBar3.TextMode = CircularProgressBar._TextMode.Percentage;
            circularProgressBar3.Value = 57L;
            // 
            // circularProgressBar2
            // 
            circularProgressBar2.Anchor = AnchorStyles.None;
            circularProgressBar2.BackColor = SystemColors.Control;
            circularProgressBar2.BarColor1 = Color.SteelBlue;
            circularProgressBar2.BarColor2 = Color.Aquamarine;
            circularProgressBar2.BarWidth = 14F;
            circularProgressBar2.Font = new Font("Segoe UI", 15F);
            circularProgressBar2.ForeColor = Color.DimGray;
            circularProgressBar2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            circularProgressBar2.LineColor = Color.DimGray;
            circularProgressBar2.LineWidth = 1;
            circularProgressBar2.Location = new Point(11, 131);
            circularProgressBar2.Maximum = 100L;
            circularProgressBar2.MinimumSize = new Size(100, 100);
            circularProgressBar2.Name = "circularProgressBar2";
            circularProgressBar2.ProgressShape = CircularProgressBar._ProgressShape.Flat;
            circularProgressBar2.Size = new Size(125, 125);
            circularProgressBar2.TabIndex = 4;
            circularProgressBar2.Text = null;
            circularProgressBar2.TextMode = CircularProgressBar._TextMode.Percentage;
            circularProgressBar2.Value = 57L;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(150, 53);
            label5.Name = "label5";
            label5.Size = new Size(43, 22);
            label5.TabIndex = 5;
            label5.Text = "Milk";
            // 
            // circularProgressBar1
            // 
            circularProgressBar1.Anchor = AnchorStyles.None;
            circularProgressBar1.BackColor = SystemColors.Control;
            circularProgressBar1.BarColor1 = Color.SteelBlue;
            circularProgressBar1.BarColor2 = Color.Turquoise;
            circularProgressBar1.BarWidth = 14F;
            circularProgressBar1.Font = new Font("Segoe UI", 15F);
            circularProgressBar1.ForeColor = Color.DimGray;
            circularProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            circularProgressBar1.LineColor = Color.DimGray;
            circularProgressBar1.LineWidth = 1;
            circularProgressBar1.Location = new Point(11, 3);
            circularProgressBar1.Maximum = 100L;
            circularProgressBar1.MinimumSize = new Size(100, 100);
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.ProgressShape = CircularProgressBar._ProgressShape.Flat;
            circularProgressBar1.Size = new Size(125, 125);
            circularProgressBar1.TabIndex = 3;
            circularProgressBar1.Text = null;
            circularProgressBar1.TextMode = CircularProgressBar._TextMode.Percentage;
            circularProgressBar1.Value = 57L;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(150, 181);
            label6.Name = "label6";
            label6.Size = new Size(51, 22);
            label6.TabIndex = 6;
            label6.Text = "Meat";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(150, 310);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 8;
            label7.Text = "Egg";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.milk1;
            pictureBox1.Location = new Point(208, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Left;
            pictureBox3.Image = Properties.Resources.egg;
            pictureBox3.Location = new Point(208, 270);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(98, 99);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(341, 54);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 12;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(341, 182);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 13;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(341, 310);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 14;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(379, 390);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(890, 479);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(SidePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Farm Manager";
            Load += MainForm_Load;
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label AnimalTypeLabel;
        private Label AgePickLabel;
        private Label GenderPickLabel;
        private ComboBox AnimalTypeComboBox;
        private ComboBox AgeComboBox;
        private ComboBox GenderPickComboBox;
        private Button AddButton;
        private Panel SidePanel;
        private Button ExitButton;
        public System.Windows.Forms.Timer progressTimer;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private CircularProgressBar circularProgressBar1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private CircularProgressBar circularProgressBar2;
        private Label label5;
        private Label label6;
        private CircularProgressBar circularProgressBar3;
        private Label label7;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
        private Label label10;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
