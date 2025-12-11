namespace Wordle
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            tableLayoutPanel1 = new TableLayoutPanel();
            btnQuit = new Button();
            btnNavodila = new Button();
            btnStats = new Button();
            btnInfinite = new Button();
            Title = new Label();
            btnDaily = new Button();
            labelKreator = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Window;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnQuit, 1, 6);
            tableLayoutPanel1.Controls.Add(btnNavodila, 1, 4);
            tableLayoutPanel1.Controls.Add(btnStats, 1, 5);
            tableLayoutPanel1.Controls.Add(btnInfinite, 1, 3);
            tableLayoutPanel1.Controls.Add(Title, 1, 1);
            tableLayoutPanel1.Controls.Add(btnDaily, 1, 2);
            tableLayoutPanel1.Controls.Add(labelKreator, 1, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(384, 511);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.LightGray;
            btnQuit.Dock = DockStyle.Fill;
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnQuit.ForeColor = SystemColors.ControlText;
            btnQuit.Location = new Point(70, 368);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(244, 44);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "QUIT";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnNavodila
            // 
            btnNavodila.BackColor = Color.LimeGreen;
            btnNavodila.Dock = DockStyle.Fill;
            btnNavodila.FlatStyle = FlatStyle.Flat;
            btnNavodila.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnNavodila.ForeColor = SystemColors.ControlText;
            btnNavodila.Location = new Point(70, 268);
            btnNavodila.Name = "btnNavodila";
            btnNavodila.Size = new Size(244, 44);
            btnNavodila.TabIndex = 5;
            btnNavodila.Text = "HOW TO PLAY";
            btnNavodila.UseVisualStyleBackColor = false;
            btnNavodila.Click += btnNavodila_Click;
            // 
            // btnStats
            // 
            btnStats.BackColor = Color.LimeGreen;
            btnStats.Dock = DockStyle.Fill;
            btnStats.FlatStyle = FlatStyle.Flat;
            btnStats.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnStats.ForeColor = SystemColors.ControlText;
            btnStats.Location = new Point(70, 318);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(244, 44);
            btnStats.TabIndex = 4;
            btnStats.Text = "STATS";
            btnStats.UseVisualStyleBackColor = false;
            btnStats.Click += btnStats_Click;
            // 
            // btnInfinite
            // 
            btnInfinite.BackColor = Color.LimeGreen;
            btnInfinite.Dock = DockStyle.Fill;
            btnInfinite.FlatStyle = FlatStyle.Flat;
            btnInfinite.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnInfinite.ForeColor = SystemColors.ControlText;
            btnInfinite.Location = new Point(70, 218);
            btnInfinite.Name = "btnInfinite";
            btnInfinite.Size = new Size(244, 44);
            btnInfinite.TabIndex = 3;
            btnInfinite.Text = "INFINITE";
            btnInfinite.UseVisualStyleBackColor = false;
            btnInfinite.Click += btnInfinite_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Title.Location = new Point(70, 95);
            Title.Name = "Title";
            Title.Size = new Size(244, 70);
            Title.TabIndex = 1;
            Title.Text = "WORDLE";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDaily
            // 
            btnDaily.BackColor = Color.Yellow;
            btnDaily.Dock = DockStyle.Fill;
            btnDaily.FlatStyle = FlatStyle.Flat;
            btnDaily.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnDaily.ForeColor = SystemColors.ControlText;
            btnDaily.Location = new Point(70, 168);
            btnDaily.Name = "btnDaily";
            btnDaily.Size = new Size(244, 44);
            btnDaily.TabIndex = 2;
            btnDaily.Text = "DAILY";
            btnDaily.UseVisualStyleBackColor = false;
            btnDaily.Click += btnDaily_Click;
            // 
            // labelKreator
            // 
            labelKreator.Anchor = AnchorStyles.Bottom;
            labelKreator.AutoSize = true;
            labelKreator.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelKreator.Location = new Point(136, 494);
            labelKreator.Name = "labelKreator";
            labelKreator.Size = new Size(111, 17);
            labelKreator.TabIndex = 6;
            labelKreator.Text = "BY: JOŠT GARTNER";
            labelKreator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 511);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(400, 550);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Title;
        private Button btnDaily;
        private Button btnInfinite;
        private Button btnStats;
        private Button btnNavodila;
        private Label labelKreator;
        private Button btnQuit;
    }
}