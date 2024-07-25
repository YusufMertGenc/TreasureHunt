using System.Runtime.CompilerServices;

namespace CatchGoldsGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.ComboBox comboBox1Y;
        private System.Windows.Forms.ComboBox comboBox2X;
        private System.Windows.Forms.ComboBox comboBox2Y;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPlayer1Health;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblPlayer2Health;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.ComboBox comboBox1X;

        private void InitializeComponent()
        {
            this.comboBox1Y = new System.Windows.Forms.ComboBox();
            this.comboBox2X = new System.Windows.Forms.ComboBox();
            this.comboBox2Y = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPlayer1Health = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblPlayer2Health = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RoundNumber = new System.Windows.Forms.TextBox();
            this.comboBox1X = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1Y
            // 
            this.comboBox1Y.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1Y.Location = new System.Drawing.Point(306, 148);
            this.comboBox1Y.Name = "comboBox1Y";
            this.comboBox1Y.Size = new System.Drawing.Size(100, 24);
            this.comboBox1Y.TabIndex = 1;
            // 
            // comboBox2X
            // 
            this.comboBox2X.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBox2X.Location = new System.Drawing.Point(1127, 148);
            this.comboBox2X.Name = "comboBox2X";
            this.comboBox2X.Size = new System.Drawing.Size(100, 24);
            this.comboBox2X.TabIndex = 2;
            // 
            // comboBox2Y
            // 
            this.comboBox2Y.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBox2Y.Location = new System.Drawing.Point(1334, 148);
            this.comboBox2Y.Name = "comboBox2Y";
            this.comboBox2Y.Size = new System.Drawing.Size(100, 24);
            this.comboBox2Y.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(645, 105);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(206, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPlayer1Health
            // 
            this.lblPlayer1Health.AutoSize = true;
            this.lblPlayer1Health.Location = new System.Drawing.Point(104, 202);
            this.lblPlayer1Health.Name = "lblPlayer1Health";
            this.lblPlayer1Health.Size = new System.Drawing.Size(111, 16);
            this.lblPlayer1Health.TabIndex = 5;
            this.lblPlayer1Health.Text = "Player 1 Health: 0";
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Location = new System.Drawing.Point(303, 202);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(108, 16);
            this.lblPlayer1Score.TabIndex = 6;
            this.lblPlayer1Score.Text = "Player 1 Score: 0";
            // 
            // lblPlayer2Health
            // 
            this.lblPlayer2Health.AutoSize = true;
            this.lblPlayer2Health.Location = new System.Drawing.Point(1124, 202);
            this.lblPlayer2Health.Name = "lblPlayer2Health";
            this.lblPlayer2Health.Size = new System.Drawing.Size(111, 16);
            this.lblPlayer2Health.TabIndex = 7;
            this.lblPlayer2Health.Text = "Player 2 Health: 0";
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Location = new System.Drawing.Point(1331, 202);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(108, 16);
            this.lblPlayer2Score.TabIndex = 8;
            this.lblPlayer2Score.Text = "Player 2 Score: 0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(497, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(540, 235);
            this.dataGridView1.TabIndex = 9;
            // 
            // RoundNumber
            // 
            this.RoundNumber.Location = new System.Drawing.Point(673, 31);
            this.RoundNumber.Name = "RoundNumber";
            this.RoundNumber.Size = new System.Drawing.Size(133, 22);
            this.RoundNumber.TabIndex = 10;
            this.RoundNumber.Text = "RoundNumber";
            // 
            // comboBox1X
            // 
            this.comboBox1X.FormattingEnabled = true;
            this.comboBox1X.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1X.Location = new System.Drawing.Point(107, 146);
            this.comboBox1X.Name = "comboBox1X";
            this.comboBox1X.Size = new System.Drawing.Size(78, 24);
            this.comboBox1X.TabIndex = 11;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1484, 717);
            this.Controls.Add(this.RoundNumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.lblPlayer2Health);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.lblPlayer1Health);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comboBox2Y);
            this.Controls.Add(this.comboBox2X);
            this.Controls.Add(this.comboBox1Y);
            this.Controls.Add(this.comboBox1X);
            this.Name = "Form1";
            this.Text = "Catch Golds Game";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.TextBox RoundNumber;
    }
   
}

