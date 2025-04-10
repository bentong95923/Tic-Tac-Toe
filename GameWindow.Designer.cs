namespace TicTacToe
{
    partial class GameWindow
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            ComputerMoves = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(32, 22);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 0;
            label1.Text = "Player";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(942, 22);
            label2.Name = "label2";
            label2.Size = new Size(32, 28);
            label2.TabIndex = 1;
            label2.Text = "AI";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(199, 173);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayerClick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(3, 182);
            button2.Name = "button2";
            button2.Size = new Size(199, 173);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += PlayerClick;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F);
            button3.Location = new Point(3, 361);
            button3.Name = "button3";
            button3.Size = new Size(199, 175);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlayerClick;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F);
            button4.Location = new Point(208, 3);
            button4.Name = "button4";
            button4.Size = new Size(199, 173);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayerClick;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 20F);
            button5.Location = new Point(208, 182);
            button5.Name = "button5";
            button5.Size = new Size(199, 173);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = true;
            button5.Click += PlayerClick;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 20F);
            button6.Location = new Point(208, 361);
            button6.Name = "button6";
            button6.Size = new Size(199, 175);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = true;
            button6.Click += PlayerClick;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 20F);
            button7.Location = new Point(413, 3);
            button7.Name = "button7";
            button7.Size = new Size(200, 173);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            button7.Click += PlayerClick;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 20F);
            button8.Location = new Point(413, 182);
            button8.Name = "button8";
            button8.Size = new Size(200, 173);
            button8.TabIndex = 9;
            button8.UseVisualStyleBackColor = true;
            button8.Click += PlayerClick;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 20F);
            button9.Location = new Point(413, 361);
            button9.Name = "button9";
            button9.Size = new Size(200, 175);
            button9.TabIndex = 10;
            button9.UseVisualStyleBackColor = true;
            button9.Click += PlayerClick;
            // 
            // button10
            // 
            button10.Location = new Point(32, 104);
            button10.Name = "button10";
            button10.Size = new Size(100, 42);
            button10.TabIndex = 11;
            button10.Text = "Restart";
            button10.UseVisualStyleBackColor = true;
            button10.Click += RestartGame;
            // 
            // ComputerMoves
            // 
            ComputerMoves.Interval = 1000;
            ComputerMoves.Tick += ComputerMove;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(32, 50);
            label3.Name = "label3";
            label3.Size = new Size(91, 28);
            label3.TabIndex = 12;
            label3.Text = "Wins - 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(883, 50);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 13;
            label4.Text = "Wins - 0";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 2);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button4, 1, 0);
            tableLayoutPanel1.Controls.Add(button9, 2, 2);
            tableLayoutPanel1.Controls.Add(button7, 2, 0);
            tableLayoutPanel1.Controls.Add(button6, 1, 2);
            tableLayoutPanel1.Controls.Add(button8, 2, 1);
            tableLayoutPanel1.Controls.Add(button5, 1, 1);
            tableLayoutPanel1.Location = new Point(194, 66);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(616, 539);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1008, 729);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button10);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GameWindow";
            Text = "Tic Tac Toe";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer ComputerMoves;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
