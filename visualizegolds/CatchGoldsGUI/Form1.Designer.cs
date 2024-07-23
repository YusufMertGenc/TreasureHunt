namespace CatchGoldsGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtXPlayer1;
        private System.Windows.Forms.TextBox txtYPlayer1;
        private System.Windows.Forms.TextBox txtXPlayer2;
        private System.Windows.Forms.TextBox txtYPlayer2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPlayer1Health;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblPlayer2Health;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.DataGridView dataGridView1;

        private void InitializeComponent()
        {
            this.txtXPlayer1 = new System.Windows.Forms.TextBox();
            this.txtYPlayer1 = new System.Windows.Forms.TextBox();
            this.txtXPlayer2 = new System.Windows.Forms.TextBox();
            this.txtYPlayer2 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPlayer1Health = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblPlayer2Health = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            // 
            // txtXPlayer1
            // 
            this.txtXPlayer1.Location = new System.Drawing.Point(12, 12);
            this.txtXPlayer1.Name = "txtXPlayer1";
            this.txtXPlayer1.Size = new System.Drawing.Size(100, 20);
            this.txtXPlayer1.TabIndex = 0;

            // 
            // txtYPlayer1
            // 
            this.txtYPlayer1.Location = new System.Drawing.Point(118, 12);
            this.txtYPlayer1.Name = "txtYPlayer1";
            this.txtYPlayer1.Size = new System.Drawing.Size(100, 20);
            this.txtYPlayer1.TabIndex = 1;

            // 
            // txtXPlayer2
            // 
            this.txtXPlayer2.Location = new System.Drawing.Point(12, 38);
            this.txtXPlayer2.Name = "txtXPlayer2";
            this.txtXPlayer2.Size = new System.Drawing.Size(100, 20);
            this.txtXPlayer2.TabIndex = 2;

            // 
            // txtYPlayer2
            // 
            this.txtYPlayer2.Location = new System.Drawing.Point(118, 38);
            this.txtYPlayer2.Name = "txtYPlayer2";
            this.txtYPlayer2.Size = new System.Drawing.Size(100, 20);
            this.txtYPlayer2.TabIndex = 3;

            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 64);
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
            this.lblPlayer1Health.Location = new System.Drawing.Point(12, 90);
            this.lblPlayer1Health.Name = "lblPlayer1Health";
            this.lblPlayer1Health.Size = new System.Drawing.Size(100, 13);
            this.lblPlayer1Health.TabIndex = 5;
            this.lblPlayer1Health.Text = "Player 1 Health: 0";

            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Location = new System.Drawing.Point(12, 104);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(90, 13);
            this.lblPlayer1Score.TabIndex = 6;
            this.lblPlayer1Score.Text = "Player 1 Score: 0";

            // 
            // lblPlayer2Health
            // 
            this.lblPlayer2Health.AutoSize = true;
            this.lblPlayer2Health.Location = new System.Drawing.Point(12, 118);
            this.lblPlayer2Health.Name = "lblPlayer2Health";
            this.lblPlayer2Health.Size = new System.Drawing.Size(100, 13);
            this.lblPlayer2Health.TabIndex = 7;
            this.lblPlayer2Health.Text = "Player 2 Health: 0";

            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Location = new System.Drawing.Point(12, 132);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(90, 13);
            this.lblPlayer2Score.TabIndex = 8;
            this.lblPlayer2Score.Text = "Player 2 Score: 0";

            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(224, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 400);
            this.dataGridView1.TabIndex = 9;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.lblPlayer2Health);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.lblPlayer1Health);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtYPlayer2);
            this.Controls.Add(this.txtXPlayer2);
            this.Controls.Add(this.txtYPlayer1);
            this.Controls.Add(this.txtXPlayer1);
            this.Name = "Form1";
            this.Text = "Catch Golds Game";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        }
    }
}

