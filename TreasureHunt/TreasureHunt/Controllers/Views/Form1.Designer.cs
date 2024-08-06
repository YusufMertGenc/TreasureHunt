using System.Drawing;
using System.Windows.Forms;

namespace TreasureHuntGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPlayer1 = new System.Windows.Forms.GroupBox();
            this.Xcoordinate1 = new System.Windows.Forms.Label();
            this.Score1 = new System.Windows.Forms.Label();
            this.Health1 = new System.Windows.Forms.Label();
            this.YCoordinate1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoundNumber = new System.Windows.Forms.Label();
            this.groupPlayer2 = new System.Windows.Forms.GroupBox();
            this.Score2 = new System.Windows.Forms.Label();
            this.Health2 = new System.Windows.Forms.Label();
            this.YCoordinate2 = new System.Windows.Forms.Label();
            this.XCoordinate2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gameName1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupPlayer1.SuspendLayout();
            this.groupPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.CadetBlue;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.groupPlayer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupPlayer2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RoundNumber, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameName1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.70711F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.98326F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.10739F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1484, 717);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupPlayer1
            // 
            this.groupPlayer1.BackColor = System.Drawing.Color.YellowGreen;
            this.groupPlayer1.Controls.Add(this.Xcoordinate1);
            this.groupPlayer1.Controls.Add(this.Score1);
            this.groupPlayer1.Controls.Add(this.Health1);
            this.groupPlayer1.Controls.Add(this.YCoordinate1);
            this.groupPlayer1.Controls.Add(this.label2);
            this.groupPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPlayer1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPlayer1.Location = new System.Drawing.Point(3, 216);
            this.groupPlayer1.Name = "groupPlayer1";
            this.groupPlayer1.Size = new System.Drawing.Size(488, 252);
            this.groupPlayer1.TabIndex = 0;
            this.groupPlayer1.TabStop = false;
            this.groupPlayer1.Text = "Player 1";
            // 
            // Xcoordinate1
            // 
            this.Xcoordinate1.AutoSize = true;
            this.Xcoordinate1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xcoordinate1.Location = new System.Drawing.Point(84, 59);
            this.Xcoordinate1.Name = "Xcoordinate1";
            this.Xcoordinate1.Size = new System.Drawing.Size(45, 31);
            this.Xcoordinate1.TabIndex = 4;
            this.Xcoordinate1.Text = "X:";
            this.Xcoordinate1.Click += new System.EventHandler(this.label10_Click);
            this.Xcoordinate1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Xcoordinate1_MouseClick);
            // 
            // Score1
            // 
            this.Score1.AutoSize = true;
            this.Score1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Score1.Location = new System.Drawing.Point(246, 146);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(88, 28);
            this.Score1.TabIndex = 3;
            this.Score1.Text = "Score: 0";
            // 
            // Health1
            // 
            this.Health1.AutoSize = true;
            this.Health1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Health1.Location = new System.Drawing.Point(60, 146);
            this.Health1.Name = "Health1";
            this.Health1.Size = new System.Drawing.Size(95, 28);
            this.Health1.TabIndex = 2;
            this.Health1.Text = "Health: 0";
            // 
            // YCoordinate1
            // 
            this.YCoordinate1.AutoSize = true;
            this.YCoordinate1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YCoordinate1.Location = new System.Drawing.Point(266, 59);
            this.YCoordinate1.Name = "YCoordinate1";
            this.YCoordinate1.Size = new System.Drawing.Size(44, 31);
            this.YCoordinate1.TabIndex = 1;
            this.YCoordinate1.Text = "Y:";
            this.YCoordinate1.Click += new System.EventHandler(this.YCoordinate1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 0;
            // 
            // RoundNumber
            // 
            this.RoundNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoundNumber.AutoSize = true;
            this.RoundNumber.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundNumber.Location = new System.Drawing.Point(598, 499);
            this.RoundNumber.Name = "RoundNumber";
            this.RoundNumber.Size = new System.Drawing.Size(286, 81);
            this.RoundNumber.TabIndex = 1;
            this.RoundNumber.Text = "Round 0/15";
            // 
            // groupPlayer2
            // 
            this.groupPlayer2.BackColor = System.Drawing.Color.DarkCyan;
            this.groupPlayer2.Controls.Add(this.Score2);
            this.groupPlayer2.Controls.Add(this.Health2);
            this.groupPlayer2.Controls.Add(this.YCoordinate2);
            this.groupPlayer2.Controls.Add(this.XCoordinate2);
            this.groupPlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPlayer2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPlayer2.Location = new System.Drawing.Point(991, 216);
            this.groupPlayer2.Name = "groupPlayer2";
            this.groupPlayer2.Size = new System.Drawing.Size(490, 252);
            this.groupPlayer2.TabIndex = 3;
            this.groupPlayer2.TabStop = false;
            this.groupPlayer2.Text = "Player 2";
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score2.Location = new System.Drawing.Point(272, 146);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(88, 28);
            this.Score2.TabIndex = 5;
            this.Score2.Text = "Score: 0";
            // 
            // Health2
            // 
            this.Health2.AutoSize = true;
            this.Health2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health2.Location = new System.Drawing.Point(56, 146);
            this.Health2.Name = "Health2";
            this.Health2.Size = new System.Drawing.Size(95, 28);
            this.Health2.TabIndex = 7;
            this.Health2.Text = "Health: 0";
            // 
            // YCoordinate2
            // 
            this.YCoordinate2.AutoSize = true;
            this.YCoordinate2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YCoordinate2.Location = new System.Drawing.Point(292, 59);
            this.YCoordinate2.Name = "YCoordinate2";
            this.YCoordinate2.Size = new System.Drawing.Size(44, 31);
            this.YCoordinate2.TabIndex = 1;
            this.YCoordinate2.Text = "Y:";
            this.YCoordinate2.Click += new System.EventHandler(this.YCoordinate2_Click);
            // 
            // XCoordinate2
            // 
            this.XCoordinate2.AutoSize = true;
            this.XCoordinate2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XCoordinate2.Location = new System.Drawing.Point(81, 59);
            this.XCoordinate2.Name = "XCoordinate2";
            this.XCoordinate2.Size = new System.Drawing.Size(45, 31);
            this.XCoordinate2.TabIndex = 0;
            this.XCoordinate2.Text = "X:";
            this.XCoordinate2.Click += new System.EventHandler(this.XCoordinate2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGreen;
            this.dataGridView1.Location = new System.Drawing.Point(497, 219);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(488, 245);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // gameName1
            // 
            this.gameName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameName1.AutoSize = true;
            this.gameName1.Font = new System.Drawing.Font("Playbill", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName1.Location = new System.Drawing.Point(515, 46);
            this.gameName1.Name = "gameName1";
            this.gameName1.Size = new System.Drawing.Size(451, 121);
            this.gameName1.TabIndex = 5;
            this.gameName1.Text = "Treasure Hunt";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1484, 717);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Treasure Hunt Game";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupPlayer1.ResumeLayout(false);
            this.groupPlayer1.PerformLayout();
            this.groupPlayer2.ResumeLayout(false);
            this.groupPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupPlayer1;
        private System.Windows.Forms.Label RoundNumber;
        private System.Windows.Forms.Label Score1;
        private System.Windows.Forms.Label Health1;
        private System.Windows.Forms.Label YCoordinate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupPlayer2;
        private System.Windows.Forms.Label Score2;
        private System.Windows.Forms.Label Health2;
        private System.Windows.Forms.Label YCoordinate2;
        private System.Windows.Forms.Label XCoordinate2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Xcoordinate1;
        private Label gameName1;
    }
}
