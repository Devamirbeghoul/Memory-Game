namespace Memory_Game
{
    partial class fmMemoryGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMemoryGame));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbMoves = new System.Windows.Forms.Label();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.btnRestart = new Guna.UI2.WinForms.Guna2Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.label1.Location = new System.Drawing.Point(226, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.label2.Location = new System.Drawing.Point(415, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Game";
            // 
            // lable5
            // 
            this.lable5.AutoSize = true;
            this.lable5.BackColor = System.Drawing.Color.Transparent;
            this.lable5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable5.ForeColor = System.Drawing.Color.White;
            this.lable5.Location = new System.Drawing.Point(760, 156);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(81, 31);
            this.lable5.TabIndex = 2;
            this.lable5.Text = "Time :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Moves :";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(847, 162);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(32, 23);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "60";
            // 
            // lbMoves
            // 
            this.lbMoves.AutoSize = true;
            this.lbMoves.BackColor = System.Drawing.Color.Transparent;
            this.lbMoves.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoves.ForeColor = System.Drawing.Color.White;
            this.lbMoves.Location = new System.Drawing.Point(117, 162);
            this.lbMoves.Name = "lbMoves";
            this.lbMoves.Size = new System.Drawing.Size(21, 23);
            this.lbMoves.TabIndex = 5;
            this.lbMoves.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.btnStart.BorderRadius = 20;
            this.btnStart.BorderThickness = 2;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(12, 615);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(170, 48);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.btnRestart.BorderRadius = 20;
            this.btnRestart.BorderThickness = 2;
            this.btnRestart.CheckedState.Parent = this.btnRestart;
            this.btnRestart.CustomImages.Parent = this.btnRestart;
            this.btnRestart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.btnRestart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.HoverState.Parent = this.btnRestart;
            this.btnRestart.Location = new System.Drawing.Point(709, 615);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.ShadowDecoration.Parent = this.btnRestart;
            this.btnRestart.Size = new System.Drawing.Size(170, 48);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "Restart";
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // fmMemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 675);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbMoves);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lable5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fmMemoryGame";
            this.Text = "Memory Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbMoves;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2Button btnRestart;
        private System.Windows.Forms.Timer GameTimer;
    }
}

