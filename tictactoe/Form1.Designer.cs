namespace tictactoe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.newgame = new System.Windows.Forms.Button();
            this.scoreplayerX = new System.Windows.Forms.Label();
            this.scoreplayerO = new System.Windows.Forms.Label();
            this.Drawscore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 450);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 300);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 150);
            this.button7.TabIndex = 8;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(150, 300);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 150);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(300, 300);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 150);
            this.button9.TabIndex = 6;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 150);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(150, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 150);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(300, 149);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 150);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 150);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 150);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 150);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // newgame
            // 
            this.newgame.Location = new System.Drawing.Point(189, 478);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(92, 50);
            this.newgame.TabIndex = 1;
            this.newgame.Text = "newgame";
            this.newgame.UseVisualStyleBackColor = true;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // scoreplayerX
            // 
            this.scoreplayerX.AutoSize = true;
            this.scoreplayerX.Location = new System.Drawing.Point(32, 465);
            this.scoreplayerX.Name = "scoreplayerX";
            this.scoreplayerX.Size = new System.Drawing.Size(66, 16);
            this.scoreplayerX.TabIndex = 2;
            this.scoreplayerX.Text = "X_score =";
            this.scoreplayerX.Click += new System.EventHandler(this.label1_Click);
            // 
            // scoreplayerO
            // 
            this.scoreplayerO.AutoSize = true;
            this.scoreplayerO.Location = new System.Drawing.Point(32, 489);
            this.scoreplayerO.Name = "scoreplayerO";
            this.scoreplayerO.Size = new System.Drawing.Size(65, 16);
            this.scoreplayerO.TabIndex = 3;
            this.scoreplayerO.Text = "O_score=";
            this.scoreplayerO.Click += new System.EventHandler(this.label2_Click);
            // 
            // Drawscore
            // 
            this.Drawscore.AutoSize = true;
            this.Drawscore.Location = new System.Drawing.Point(33, 512);
            this.Drawscore.Name = "Drawscore";
            this.Drawscore.Size = new System.Drawing.Size(65, 16);
            this.Drawscore.TabIndex = 4;
            this.Drawscore.Text = "O_score=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 540);
            this.Controls.Add(this.Drawscore);
            this.Controls.Add(this.scoreplayerO);
            this.Controls.Add(this.scoreplayerX);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button newgame;
        private System.Windows.Forms.Label scoreplayerX;
        private System.Windows.Forms.Label scoreplayerO;
        private System.Windows.Forms.Label Drawscore;
    }
}

