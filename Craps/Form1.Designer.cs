
namespace Craps
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
            this.die1Img = new System.Windows.Forms.PictureBox();
            this.die2Img = new System.Windows.Forms.PictureBox();
            this.rulesTxtBox = new System.Windows.Forms.TextBox();
            this.resultTxtBox = new System.Windows.Forms.TextBox();
            this.rollBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pointTxtBox = new System.Windows.Forms.TextBox();
            this.pointLbl = new System.Windows.Forms.Label();
            this.rollLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.die1Img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2Img)).BeginInit();
            this.SuspendLayout();
            // 
            // die1Img
            // 
            this.die1Img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.die1Img.InitialImage = global::Craps.Properties.Resources.one;
            this.die1Img.Location = new System.Drawing.Point(16, 192);
            this.die1Img.MaximumSize = new System.Drawing.Size(100, 100);
            this.die1Img.MinimumSize = new System.Drawing.Size(100, 100);
            this.die1Img.Name = "die1Img";
            this.die1Img.Size = new System.Drawing.Size(100, 100);
            this.die1Img.TabIndex = 0;
            this.die1Img.TabStop = false;
            // 
            // die2Img
            // 
            this.die2Img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.die2Img.InitialImage = global::Craps.Properties.Resources.one;
            this.die2Img.Location = new System.Drawing.Point(248, 192);
            this.die2Img.MaximumSize = new System.Drawing.Size(100, 100);
            this.die2Img.MinimumSize = new System.Drawing.Size(100, 100);
            this.die2Img.Name = "die2Img";
            this.die2Img.Size = new System.Drawing.Size(100, 100);
            this.die2Img.TabIndex = 1;
            this.die2Img.TabStop = false;
            // 
            // rulesTxtBox
            // 
            this.rulesTxtBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.rulesTxtBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesTxtBox.Location = new System.Drawing.Point(8, 8);
            this.rulesTxtBox.Multiline = true;
            this.rulesTxtBox.Name = "rulesTxtBox";
            this.rulesTxtBox.ReadOnly = true;
            this.rulesTxtBox.Size = new System.Drawing.Size(344, 144);
            this.rulesTxtBox.TabIndex = 2;
            this.rulesTxtBox.TabStop = false;
            this.rulesTxtBox.Text = resources.GetString("rulesTxtBox.Text");
            // 
            // resultTxtBox
            // 
            this.resultTxtBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTxtBox.Location = new System.Drawing.Point(144, 288);
            this.resultTxtBox.Name = "resultTxtBox";
            this.resultTxtBox.ReadOnly = true;
            this.resultTxtBox.Size = new System.Drawing.Size(80, 63);
            this.resultTxtBox.TabIndex = 3;
            this.resultTxtBox.TabStop = false;
            this.resultTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rollBtn
            // 
            this.rollBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollBtn.Location = new System.Drawing.Point(24, 304);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(83, 56);
            this.rollBtn.TabIndex = 0;
            this.rollBtn.Text = "ROLL!";
            this.rollBtn.UseVisualStyleBackColor = true;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(256, 304);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(83, 56);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pointTxtBox
            // 
            this.pointTxtBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointTxtBox.Location = new System.Drawing.Point(144, 192);
            this.pointTxtBox.Name = "pointTxtBox";
            this.pointTxtBox.ReadOnly = true;
            this.pointTxtBox.Size = new System.Drawing.Size(80, 63);
            this.pointTxtBox.TabIndex = 7;
            this.pointTxtBox.TabStop = false;
            this.pointTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointLbl
            // 
            this.pointLbl.AutoSize = true;
            this.pointLbl.Location = new System.Drawing.Point(168, 176);
            this.pointLbl.Name = "pointLbl";
            this.pointLbl.Size = new System.Drawing.Size(31, 13);
            this.pointLbl.TabIndex = 8;
            this.pointLbl.Text = "Point";
            this.pointLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rollLbl
            // 
            this.rollLbl.AutoSize = true;
            this.rollLbl.Location = new System.Drawing.Point(168, 272);
            this.rollLbl.Name = "rollLbl";
            this.rollLbl.Size = new System.Drawing.Size(25, 13);
            this.rollLbl.TabIndex = 9;
            this.rollLbl.Text = "Roll";
            this.rollLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(361, 375);
            this.Controls.Add(this.rollLbl);
            this.Controls.Add(this.pointLbl);
            this.Controls.Add(this.pointTxtBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.rollBtn);
            this.Controls.Add(this.resultTxtBox);
            this.Controls.Add(this.rulesTxtBox);
            this.Controls.Add(this.die2Img);
            this.Controls.Add(this.die1Img);
            this.Name = "Form1";
            this.Text = "Craps";
            ((System.ComponentModel.ISupportInitialize)(this.die1Img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox die1Img;
        private System.Windows.Forms.PictureBox die2Img;
        private System.Windows.Forms.TextBox rulesTxtBox;
        private System.Windows.Forms.TextBox resultTxtBox;
        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox pointTxtBox;
        private System.Windows.Forms.Label pointLbl;
        private System.Windows.Forms.Label rollLbl;
    }
}

