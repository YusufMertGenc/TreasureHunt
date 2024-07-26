using System.Runtime.CompilerServices;

namespace CatchGoldsGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Xcoordinate1 = new System.Windows.Forms.Label();
            this.Score1 = new System.Windows.Forms.Label();
            this.Health1 = new System.Windows.Forms.Label();
            this.YCoordinate1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoundNumber = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Score2 = new System.Windows.Forms.Label();
            this.Health2 = new System.Windows.Forms.Label();
            this.YCoordinate2 = new System.Windows.Forms.Label();
            this.XCoordinate2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RoundNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.70711F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.98326F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.10739F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1484, 717);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.Xcoordinate1);
            this.groupBox1.Controls.Add(this.Score1);
            this.groupBox1.Controls.Add(this.Health1);
            this.groupBox1.Controls.Add(this.YCoordinate1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(101, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1";
            // 
            // Xcoordinate1
            // 
            this.Xcoordinate1.AutoSize = true;
            this.Xcoordinate1.Location = new System.Drawing.Point(27, 36);
            this.Xcoordinate1.Name = "Xcoordinate1";
            this.Xcoordinate1.Size = new System.Drawing.Size(85, 16);
            this.Xcoordinate1.TabIndex = 4;
            this.Xcoordinate1.Text = "X-Coordinate";
            this.Xcoordinate1.Click += new System.EventHandler(this.label10_Click);
            this.Xcoordinate1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Xcoordinate1_MouseClick);
            // 
            // Score1
            // 
            this.Score1.AutoSize = true;
            this.Score1.Location = new System.Drawing.Point(147, 84);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(108, 16);
            this.Score1.TabIndex = 3;
            this.Score1.Text = "Player 1 Score: 0";
            // 
            // Health1
            // 
            this.Health1.AutoSize = true;
            this.Health1.Location = new System.Drawing.Point(34, 84);
            this.Health1.Name = "Health1";
            this.Health1.Size = new System.Drawing.Size(111, 16);
            this.Health1.TabIndex = 2;
            this.Health1.Text = "Player 1 Health: 0";
            // 
            // YCoordinate1
            // 
            this.YCoordinate1.AutoSize = true;
            this.YCoordinate1.Location = new System.Drawing.Point(147, 36);
            this.YCoordinate1.Name = "YCoordinate1";
            this.YCoordinate1.Size = new System.Drawing.Size(86, 16);
            this.YCoordinate1.TabIndex = 1;
            this.YCoordinate1.Text = "Y-Coordinate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 0;
            // 
            // RoundNumber
            // 
            this.RoundNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoundNumber.AutoSize = true;
            this.RoundNumber.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RoundNumber.Location = new System.Drawing.Point(635, 82);
            this.RoundNumber.Name = "RoundNumber";
            this.RoundNumber.Size = new System.Drawing.Size(211, 49);
            this.RoundNumber.TabIndex = 1;
            this.RoundNumber.Text = "Round 0/12";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(494, 471);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(494, 137);
            this.button1.TabIndex = 2;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.Score2);
            this.groupBox2.Controls.Add(this.Health2);
            this.groupBox2.Controls.Add(this.YCoordinate2);
            this.groupBox2.Controls.Add(this.XCoordinate2);
            this.groupBox2.Location = new System.Drawing.Point(1090, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 146);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 2";
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.Location = new System.Drawing.Point(147, 84);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(108, 16);
            this.Score2.TabIndex = 5;
            this.Score2.Text = "Player 2 Score: 0";
            // 
            // Health2
            // 
            this.Health2.AutoSize = true;
            this.Health2.Location = new System.Drawing.Point(34, 84);
            this.Health2.Name = "Health2";
            this.Health2.Size = new System.Drawing.Size(111, 16);
            this.Health2.TabIndex = 4;
            this.Health2.Text = "Player 2 Health: 0";
            // 
            // YCoordinate2
            // 
            this.YCoordinate2.AutoSize = true;
            this.YCoordinate2.Location = new System.Drawing.Point(147, 36);
            this.YCoordinate2.Name = "YCoordinate2";
            this.YCoordinate2.Size = new System.Drawing.Size(86, 16);
            this.YCoordinate2.TabIndex = 1;
            this.YCoordinate2.Text = "Y-Coordinate";
            // 
            // XCoordinate2
            // 
            this.XCoordinate2.AutoSize = true;
            this.XCoordinate2.Location = new System.Drawing.Point(34, 36);
            this.XCoordinate2.Name = "XCoordinate2";
            this.XCoordinate2.Size = new System.Drawing.Size(85, 16);
            this.XCoordinate2.TabIndex = 0;
            this.XCoordinate2.Text = "X-Coordinate";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(497, 216);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(488, 252);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1484, 717);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Catch Golds Game";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label RoundNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Score1;
        private System.Windows.Forms.Label Health1;
        private System.Windows.Forms.Label YCoordinate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Score2;
        private System.Windows.Forms.Label Health2;
        private System.Windows.Forms.Label YCoordinate2;
        private System.Windows.Forms.Label XCoordinate2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Xcoordinate1;
    }

}

