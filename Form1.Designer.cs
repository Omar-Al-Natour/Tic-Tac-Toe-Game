namespace Tic_Tac_Toe_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(70, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 44);
            this.label2.TabIndex = 19;
            this.label2.Text = "Turn";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnRestartGame.FlatAppearance.BorderSize = 2;
            this.btnRestartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRestartGame.Location = new System.Drawing.Point(41, 457);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(188, 34);
            this.btnRestartGame.TabIndex = 20;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = true;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Red;
            this.lblTurn.Location = new System.Drawing.Point(72, 223);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(111, 31);
            this.lblTurn.TabIndex = 21;
            this.lblTurn.Tag = "";
            this.lblTurn.Text = "Player1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(50, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 42);
            this.label3.TabIndex = 22;
            this.label3.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(51, 352);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(160, 31);
            this.lblWinner.TabIndex = 23;
            this.lblWinner.Tag = "";
            this.lblWinner.Text = "In Progress";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.angry_8832565;
            this.pictureBox9.Location = new System.Drawing.Point(57, 18);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(141, 126);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.pb3.Location = new System.Drawing.Point(720, 94);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(83, 79);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 17;
            this.pb3.TabStop = false;
            this.pb3.Tag = "?";
            this.pb3.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb5
            // 
            this.pb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.pb5.Location = new System.Drawing.Point(580, 220);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(83, 79);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 16;
            this.pb5.TabStop = false;
            this.pb5.Tag = "?";
            this.pb5.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb6
            // 
            this.pb6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.pb6.Location = new System.Drawing.Point(720, 220);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(83, 79);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb6.TabIndex = 15;
            this.pb6.TabStop = false;
            this.pb6.Tag = "?";
            this.pb6.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb8
            // 
            this.pb8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.pb8.Location = new System.Drawing.Point(580, 352);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(83, 79);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb8.TabIndex = 14;
            this.pb8.TabStop = false;
            this.pb8.Tag = "?";
            this.pb8.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb9
            // 
            this.pb9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.pb9.Location = new System.Drawing.Point(720, 352);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(83, 79);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb9.TabIndex = 13;
            this.pb9.TabStop = false;
            this.pb9.Tag = "?";
            this.pb9.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb7
            // 
            this.pb7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.pb7.Location = new System.Drawing.Point(440, 352);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(83, 79);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb7.TabIndex = 12;
            this.pb7.TabStop = false;
            this.pb7.Tag = "?";
            this.pb7.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb4
            // 
            this.pb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.pb4.Location = new System.Drawing.Point(440, 223);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(83, 79);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 11;
            this.pb4.TabStop = false;
            this.pb4.Tag = "?";
            this.pb4.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb1
            // 
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.pb1.Location = new System.Drawing.Point(440, 94);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(83, 79);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 10;
            this.pb1.TabStop = false;
            this.pb1.Tag = "?";
            this.pb1.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb2
            // 
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.pb2.Location = new System.Drawing.Point(580, 94);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(83, 79);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            this.pb2.Tag = "?";
            this.pb2.Click += new System.EventHandler(this.pb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(903, 519);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawTheFrams);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWinner;
    }
}

