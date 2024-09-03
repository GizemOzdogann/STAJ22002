namespace FarmManager.UI
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            LifeBar = new ProgressBar();
            ProductionBar = new ProgressBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(183, 125);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // LifeBar
            // 
            LifeBar.Anchor = AnchorStyles.Top;
            LifeBar.Location = new Point(19, 163);
            LifeBar.Name = "LifeBar";
            LifeBar.Size = new Size(143, 29);
            LifeBar.TabIndex = 1;
            // 
            // ProductionBar
            // 
            ProductionBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ProductionBar.Location = new Point(19, 207);
            ProductionBar.Name = "ProductionBar";
            ProductionBar.Size = new Size(143, 29);
            ProductionBar.Style = ProgressBarStyle.Continuous;
            ProductionBar.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(59, 128);
            label1.Name = "label1";
            label1.Size = new Size(58, 22);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // ListItem
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ControlLight;
            Controls.Add(label1);
            Controls.Add(ProductionBar);
            Controls.Add(LifeBar);
            Controls.Add(pictureBox);
            Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.WindowFrame;
            Name = "ListItem";
            Size = new Size(183, 249);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public ProgressBar LifeBar;
        public ProgressBar ProductionBar;
        public PictureBox pictureBox;
        public Label label1;
    }
}
