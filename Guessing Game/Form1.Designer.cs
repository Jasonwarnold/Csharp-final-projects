
namespace Guessing_Game
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
            this.currGuessLbl = new System.Windows.Forms.Label();
            this.lastGuessLbl = new System.Windows.Forms.Label();
            this.lowHighLbl = new System.Windows.Forms.Label();
            this.guessCountLbl = new System.Windows.Forms.Label();
            this.guessNumTxtBox = new System.Windows.Forms.TextBox();
            this.guessInputTxtBox = new System.Windows.Forms.TextBox();
            this.lastGuessBox = new System.Windows.Forms.TextBox();
            this.RulesTxtBox = new System.Windows.Forms.TextBox();
            this.guessBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.hintLbl = new System.Windows.Forms.Label();
            this.hintTxtBox = new System.Windows.Forms.TextBox();
            this.bestLbl = new System.Windows.Forms.Label();
            this.bestTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currGuessLbl
            // 
            this.currGuessLbl.AutoSize = true;
            this.currGuessLbl.Location = new System.Drawing.Point(16, 208);
            this.currGuessLbl.Name = "currGuessLbl";
            this.currGuessLbl.Size = new System.Drawing.Size(74, 13);
            this.currGuessLbl.TabIndex = 0;
            this.currGuessLbl.Text = "Current Guess";
            // 
            // lastGuessLbl
            // 
            this.lastGuessLbl.AutoSize = true;
            this.lastGuessLbl.Location = new System.Drawing.Point(152, 208);
            this.lastGuessLbl.Name = "lastGuessLbl";
            this.lastGuessLbl.Size = new System.Drawing.Size(60, 13);
            this.lastGuessLbl.TabIndex = 1;
            this.lastGuessLbl.Text = "Last Guess";
            // 
            // lowHighLbl
            // 
            this.lowHighLbl.AutoSize = true;
            this.lowHighLbl.Location = new System.Drawing.Point(96, 168);
            this.lowHighLbl.Name = "lowHighLbl";
            this.lowHighLbl.Size = new System.Drawing.Size(0, 13);
            this.lowHighLbl.TabIndex = 2;
            // 
            // guessCountLbl
            // 
            this.guessCountLbl.AutoSize = true;
            this.guessCountLbl.Location = new System.Drawing.Point(16, 352);
            this.guessCountLbl.Name = "guessCountLbl";
            this.guessCountLbl.Size = new System.Drawing.Size(70, 13);
            this.guessCountLbl.TabIndex = 3;
            this.guessCountLbl.Text = "# of Guesses";
            // 
            // guessNumTxtBox
            // 
            this.guessNumTxtBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessNumTxtBox.Location = new System.Drawing.Point(16, 368);
            this.guessNumTxtBox.Name = "guessNumTxtBox";
            this.guessNumTxtBox.ReadOnly = true;
            this.guessNumTxtBox.Size = new System.Drawing.Size(64, 32);
            this.guessNumTxtBox.TabIndex = 4;
            // 
            // guessInputTxtBox
            // 
            this.guessInputTxtBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessInputTxtBox.Location = new System.Drawing.Point(16, 224);
            this.guessInputTxtBox.Name = "guessInputTxtBox";
            this.guessInputTxtBox.Size = new System.Drawing.Size(64, 32);
            this.guessInputTxtBox.TabIndex = 5;
            // 
            // lastGuessBox
            // 
            this.lastGuessBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastGuessBox.Location = new System.Drawing.Point(152, 224);
            this.lastGuessBox.Name = "lastGuessBox";
            this.lastGuessBox.ReadOnly = true;
            this.lastGuessBox.Size = new System.Drawing.Size(64, 32);
            this.lastGuessBox.TabIndex = 6;
            // 
            // RulesTxtBox
            // 
            this.RulesTxtBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesTxtBox.Location = new System.Drawing.Point(8, 8);
            this.RulesTxtBox.Multiline = true;
            this.RulesTxtBox.Name = "RulesTxtBox";
            this.RulesTxtBox.Size = new System.Drawing.Size(432, 176);
            this.RulesTxtBox.TabIndex = 7;
            this.RulesTxtBox.TabStop = false;
            this.RulesTxtBox.Text = resources.GetString("RulesTxtBox.Text");
            // 
            // guessBtn
            // 
            this.guessBtn.Location = new System.Drawing.Point(16, 288);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(75, 23);
            this.guessBtn.TabIndex = 8;
            this.guessBtn.Text = "Guess";
            this.guessBtn.UseVisualStyleBackColor = true;
            this.guessBtn.Click += new System.EventHandler(this.guessBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(152, 288);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // hintLbl
            // 
            this.hintLbl.AutoSize = true;
            this.hintLbl.Location = new System.Drawing.Point(256, 208);
            this.hintLbl.Name = "hintLbl";
            this.hintLbl.Size = new System.Drawing.Size(26, 13);
            this.hintLbl.TabIndex = 10;
            this.hintLbl.Text = "Hint";
            // 
            // hintTxtBox
            // 
            this.hintTxtBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintTxtBox.Location = new System.Drawing.Point(256, 224);
            this.hintTxtBox.Name = "hintTxtBox";
            this.hintTxtBox.ReadOnly = true;
            this.hintTxtBox.Size = new System.Drawing.Size(128, 32);
            this.hintTxtBox.TabIndex = 11;
            // 
            // bestLbl
            // 
            this.bestLbl.AutoSize = true;
            this.bestLbl.Location = new System.Drawing.Point(160, 352);
            this.bestLbl.Name = "bestLbl";
            this.bestLbl.Size = new System.Drawing.Size(59, 13);
            this.bestLbl.TabIndex = 12;
            this.bestLbl.Text = "Best Score";
            // 
            // bestTxtBox
            // 
            this.bestTxtBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestTxtBox.Location = new System.Drawing.Point(160, 368);
            this.bestTxtBox.Name = "bestTxtBox";
            this.bestTxtBox.ReadOnly = true;
            this.bestTxtBox.Size = new System.Drawing.Size(56, 32);
            this.bestTxtBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 409);
            this.Controls.Add(this.bestTxtBox);
            this.Controls.Add(this.bestLbl);
            this.Controls.Add(this.hintTxtBox);
            this.Controls.Add(this.hintLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.guessBtn);
            this.Controls.Add(this.RulesTxtBox);
            this.Controls.Add(this.lastGuessBox);
            this.Controls.Add(this.guessInputTxtBox);
            this.Controls.Add(this.guessNumTxtBox);
            this.Controls.Add(this.guessCountLbl);
            this.Controls.Add(this.lowHighLbl);
            this.Controls.Add(this.lastGuessLbl);
            this.Controls.Add(this.currGuessLbl);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currGuessLbl;
        private System.Windows.Forms.Label lastGuessLbl;
        private System.Windows.Forms.Label lowHighLbl;
        private System.Windows.Forms.Label guessCountLbl;
        private System.Windows.Forms.TextBox guessNumTxtBox;
        private System.Windows.Forms.TextBox guessInputTxtBox;
        private System.Windows.Forms.TextBox lastGuessBox;
        private System.Windows.Forms.TextBox RulesTxtBox;
        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label hintLbl;
        private System.Windows.Forms.TextBox hintTxtBox;
        private System.Windows.Forms.Label bestLbl;
        private System.Windows.Forms.TextBox bestTxtBox;
    }
}

