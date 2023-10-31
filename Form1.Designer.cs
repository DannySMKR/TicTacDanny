namespace TicTacDanny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            B2 = new Button();
            A3 = new Button();
            B1 = new Button();
            A2 = new Button();
            A1 = new Button();
            B3 = new Button();
            C1 = new Button();
            C2 = new Button();
            C3 = new Button();
            label1 = new Label();
            P1label = new Label();
            P2label = new Label();
            winStreakLabel = new Label();
            SuspendLayout();
            // 
            // B2
            // 
            B2.BackColor = Color.Red;
            B2.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point);
            B2.Location = new Point(226, 227);
            B2.Name = "B2";
            B2.Size = new Size(45, 45);
            B2.TabIndex = 0;
            B2.UseVisualStyleBackColor = false;
            B2.Click += buttonClick;
            // 
            // A3
            // 
            A3.BackColor = Color.Red;
            A3.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point);
            A3.Location = new Point(294, 162);
            A3.Name = "A3";
            A3.Size = new Size(45, 45);
            A3.TabIndex = 1;
            A3.UseVisualStyleBackColor = false;
            A3.Click += buttonClick;
            // 
            // B1
            // 
            B1.BackColor = Color.Red;
            B1.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point);
            B1.Location = new Point(164, 227);
            B1.Name = "B1";
            B1.Size = new Size(45, 45);
            B1.TabIndex = 2;
            B1.UseVisualStyleBackColor = false;
            B1.Click += buttonClick;
            // 
            // A2
            // 
            A2.BackColor = Color.Red;
            A2.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point);
            A2.Location = new Point(226, 162);
            A2.Name = "A2";
            A2.Size = new Size(45, 45);
            A2.TabIndex = 3;
            A2.UseVisualStyleBackColor = false;
            A2.Click += buttonClick;
            // 
            // A1
            // 
            A1.BackColor = Color.Red;
            A1.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point);
            A1.Location = new Point(164, 162);
            A1.Name = "A1";
            A1.Size = new Size(45, 45);
            A1.TabIndex = 4;
            A1.UseVisualStyleBackColor = false;
            A1.Click += buttonClick;
            // 
            // B3
            // 
            B3.BackColor = Color.Red;
            B3.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point);
            B3.Location = new Point(294, 227);
            B3.Name = "B3";
            B3.Size = new Size(45, 45);
            B3.TabIndex = 5;
            B3.UseVisualStyleBackColor = false;
            B3.Click += buttonClick;
            // 
            // C1
            // 
            C1.BackColor = Color.Red;
            C1.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point);
            C1.Location = new Point(164, 300);
            C1.Name = "C1";
            C1.Size = new Size(45, 45);
            C1.TabIndex = 6;
            C1.UseVisualStyleBackColor = false;
            C1.Click += buttonClick;
            // 
            // C2
            // 
            C2.BackColor = Color.Red;
            C2.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point);
            C2.Location = new Point(227, 300);
            C2.Name = "C2";
            C2.Size = new Size(45, 45);
            C2.TabIndex = 7;
            C2.UseVisualStyleBackColor = false;
            C2.Click += buttonClick;
            // 
            // C3
            // 
            C3.BackColor = Color.Red;
            C3.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point);
            C3.Location = new Point(294, 300);
            C3.Name = "C3";
            C3.Size = new Size(45, 45);
            C3.TabIndex = 8;
            C3.UseVisualStyleBackColor = false;
            C3.Click += buttonClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 26);
            label1.TabIndex = 9;
            label1.Text = "MULTI PLAYER GAME";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // P1label
            // 
            P1label.AutoSize = true;
            P1label.BackColor = Color.FromArgb(255, 128, 128);
            P1label.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            P1label.Location = new Point(374, 0);
            P1label.Name = "P1label";
            P1label.Size = new Size(125, 21);
            P1label.TabIndex = 10;
            P1label.Text = "PLAYER 1: X";
            // 
            // P2label
            // 
            P2label.AutoSize = true;
            P2label.BackColor = Color.FromArgb(255, 128, 128);
            P2label.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            P2label.Location = new Point(374, 47);
            P2label.Name = "P2label";
            P2label.Size = new Size(125, 21);
            P2label.TabIndex = 11;
            P2label.Text = "PLAYER 2: O";
            // 
            // winStreakLabel
            // 
            winStreakLabel.AutoSize = true;
            winStreakLabel.Location = new Point(44, 438);
            winStreakLabel.Name = "winStreakLabel";
            winStreakLabel.Size = new Size(0, 20);
            winStreakLabel.TabIndex = 12;
            winStreakLabel.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(499, 489);
            Controls.Add(winStreakLabel);
            Controls.Add(P2label);
            Controls.Add(P1label);
            Controls.Add(label1);
            Controls.Add(C3);
            Controls.Add(C2);
            Controls.Add(C1);
            Controls.Add(B3);
            Controls.Add(A1);
            Controls.Add(A2);
            Controls.Add(B1);
            Controls.Add(A3);
            Controls.Add(B2);
            Name = "Form1";
            Text = "TicTacDanny";
            Load += Form1_Load;
            Click += buttonClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button B2;
        private Button A3;
        private Button B1;
        private Button A2;
        private Button A1;
        private Button B3;
        private Button C1;
        private Button C2;
        private Button C3;
        private Label label1;
        private Label P1label;
        private Label P2label;
        private Label winStreakLabel;
    }
}