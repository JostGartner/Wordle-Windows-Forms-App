namespace Wordle
{
    partial class FormNavodila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNavodila));
            tableLayoutPanel1 = new TableLayoutPanel();
            btnQuit = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelNavodila = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Window;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnQuit, 1, 8);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 7);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 6);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 5);
            tableLayoutPanel1.Controls.Add(label6, 2, 7);
            tableLayoutPanel1.Controls.Add(label5, 2, 6);
            tableLayoutPanel1.Controls.Add(label4, 2, 5);
            tableLayoutPanel1.Controls.Add(label3, 1, 4);
            tableLayoutPanel1.Controls.Add(label2, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 1, 2);
            tableLayoutPanel1.Controls.Add(labelNavodila, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
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
            tableLayoutPanel1.SetColumnSpan(btnQuit, 2);
            btnQuit.Dock = DockStyle.Fill;
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnQuit.ForeColor = SystemColors.ControlText;
            btnQuit.Location = new Point(70, 408);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(244, 44);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "BACK TO MENU";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Gray;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.CharacterCasing = CharacterCasing.Upper;
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox3.Location = new Point(70, 358);
            textBox3.MaxLength = 1;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(44, 44);
            textBox3.TabIndex = 9;
            textBox3.TabStop = false;
            textBox3.Text = "C";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Yellow;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.CharacterCasing = CharacterCasing.Upper;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox2.Location = new Point(70, 308);
            textBox2.MaxLength = 1;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(44, 44);
            textBox2.TabIndex = 8;
            textBox2.TabStop = false;
            textBox2.Text = "B";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 192, 0);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox1.Location = new Point(70, 258);
            textBox1.MaxLength = 1;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(44, 44);
            textBox1.TabIndex = 7;
            textBox1.TabStop = false;
            textBox1.Text = "A";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(120, 355);
            label6.Name = "label6";
            label6.Size = new Size(194, 50);
            label6.TabIndex = 6;
            label6.Text = "Letter is not part of the word.";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(120, 305);
            label5.Name = "label5";
            label5.Size = new Size(194, 50);
            label5.TabIndex = 5;
            label5.Text = "Letter is part of the word, but is in the wrong spot.";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(120, 255);
            label4.Name = "label4";
            label4.Size = new Size(194, 50);
            label4.TabIndex = 4;
            label4.Text = "Letter is in the correct spot.";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label3, 2);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(70, 205);
            label3.Name = "label3";
            label3.Size = new Size(244, 50);
            label3.TabIndex = 3;
            label3.Text = "After each guess, the color of the tiles will change:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 2);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(70, 155);
            label2.Name = "label2";
            label2.Size = new Size(244, 50);
            label2.TabIndex = 2;
            label2.Text = "Each guess must be a valid 5-letter word.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(70, 105);
            label1.Name = "label1";
            label1.Size = new Size(244, 50);
            label1.TabIndex = 1;
            label1.Text = "Guess the correct 5-letter word in 6 tries or less.";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNavodila
            // 
            labelNavodila.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(labelNavodila, 2);
            labelNavodila.Dock = DockStyle.Fill;
            labelNavodila.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelNavodila.Location = new Point(70, 55);
            labelNavodila.Name = "labelNavodila";
            labelNavodila.Size = new Size(244, 50);
            labelNavodila.TabIndex = 0;
            labelNavodila.Text = "HOW TO PLAY:";
            labelNavodila.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormNavodila
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 511);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(400, 550);
            Name = "FormNavodila";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructions";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelNavodila;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button btnQuit;
    }
}