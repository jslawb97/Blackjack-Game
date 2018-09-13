namespace WinformPresentation
{
    partial class mainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.dealersCard1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dealersCard2 = new System.Windows.Forms.PictureBox();
            this.dealersCard3 = new System.Windows.Forms.PictureBox();
            this.dealersCard4 = new System.Windows.Forms.PictureBox();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.plyerScore = new System.Windows.Forms.Label();
            this.playerCard4 = new System.Windows.Forms.PictureBox();
            this.playerCard3 = new System.Windows.Forms.PictureBox();
            this.playerCard2 = new System.Windows.Forms.PictureBox();
            this.playerCard1 = new System.Windows.Forms.PictureBox();
            this.DlrScore = new System.Windows.Forms.Label();
            this.dealBtn = new System.Windows.Forms.Button();
            this.hitBtn = new System.Windows.Forms.Button();
            this.standBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerBank = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // dealersCard1
            // 
            this.dealersCard1.Location = new System.Drawing.Point(512, 66);
            this.dealersCard1.Margin = new System.Windows.Forms.Padding(2);
            this.dealersCard1.Name = "dealersCard1";
            this.dealersCard1.Size = new System.Drawing.Size(87, 133);
            this.dealersCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealersCard1.TabIndex = 0;
            this.dealersCard1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dealer\'s Hand:";
            // 
            // dealersCard2
            // 
            this.dealersCard2.Location = new System.Drawing.Point(604, 66);
            this.dealersCard2.Margin = new System.Windows.Forms.Padding(2);
            this.dealersCard2.Name = "dealersCard2";
            this.dealersCard2.Size = new System.Drawing.Size(94, 133);
            this.dealersCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealersCard2.TabIndex = 2;
            this.dealersCard2.TabStop = false;
            // 
            // dealersCard3
            // 
            this.dealersCard3.Location = new System.Drawing.Point(701, 66);
            this.dealersCard3.Margin = new System.Windows.Forms.Padding(2);
            this.dealersCard3.Name = "dealersCard3";
            this.dealersCard3.Size = new System.Drawing.Size(94, 133);
            this.dealersCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealersCard3.TabIndex = 3;
            this.dealersCard3.TabStop = false;
            // 
            // dealersCard4
            // 
            this.dealersCard4.Location = new System.Drawing.Point(800, 66);
            this.dealersCard4.Margin = new System.Windows.Forms.Padding(2);
            this.dealersCard4.Name = "dealersCard4";
            this.dealersCard4.Size = new System.Drawing.Size(94, 133);
            this.dealersCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealersCard4.TabIndex = 4;
            this.dealersCard4.TabStop = false;
            // 
            // betAmount
            // 
            this.betAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.betAmount.Location = new System.Drawing.Point(120, 303);
            this.betAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.betAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(120, 20);
            this.betAmount.TabIndex = 5;
            this.betAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player\'s Hand:";
            // 
            // plyerScore
            // 
            this.plyerScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plyerScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plyerScore.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plyerScore.Location = new System.Drawing.Point(149, 15);
            this.plyerScore.Name = "plyerScore";
            this.plyerScore.Size = new System.Drawing.Size(56, 32);
            this.plyerScore.TabIndex = 7;
            this.plyerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerCard4
            // 
            this.playerCard4.Location = new System.Drawing.Point(319, 66);
            this.playerCard4.Name = "playerCard4";
            this.playerCard4.Size = new System.Drawing.Size(94, 133);
            this.playerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard4.TabIndex = 11;
            this.playerCard4.TabStop = false;
            // 
            // playerCard3
            // 
            this.playerCard3.Location = new System.Drawing.Point(218, 66);
            this.playerCard3.Name = "playerCard3";
            this.playerCard3.Size = new System.Drawing.Size(94, 133);
            this.playerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard3.TabIndex = 10;
            this.playerCard3.TabStop = false;
            // 
            // playerCard2
            // 
            this.playerCard2.Location = new System.Drawing.Point(118, 66);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(94, 133);
            this.playerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard2.TabIndex = 9;
            this.playerCard2.TabStop = false;
            // 
            // playerCard1
            // 
            this.playerCard1.Location = new System.Drawing.Point(19, 66);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(94, 133);
            this.playerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard1.TabIndex = 8;
            this.playerCard1.TabStop = false;
            // 
            // DlrScore
            // 
            this.DlrScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DlrScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DlrScore.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DlrScore.Location = new System.Drawing.Point(644, 15);
            this.DlrScore.Name = "DlrScore";
            this.DlrScore.Size = new System.Drawing.Size(56, 32);
            this.DlrScore.TabIndex = 12;
            this.DlrScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealBtn
            // 
            this.dealBtn.Location = new System.Drawing.Point(83, 222);
            this.dealBtn.Name = "dealBtn";
            this.dealBtn.Size = new System.Drawing.Size(84, 28);
            this.dealBtn.TabIndex = 13;
            this.dealBtn.Text = "Start Game";
            this.dealBtn.UseVisualStyleBackColor = true;
            this.dealBtn.Click += new System.EventHandler(this.dealBtn_Click);
            // 
            // hitBtn
            // 
            this.hitBtn.Location = new System.Drawing.Point(173, 222);
            this.hitBtn.Name = "hitBtn";
            this.hitBtn.Size = new System.Drawing.Size(84, 28);
            this.hitBtn.TabIndex = 14;
            this.hitBtn.Text = "Hit";
            this.hitBtn.UseVisualStyleBackColor = true;
            this.hitBtn.Click += new System.EventHandler(this.hitBtn_Click);
            // 
            // standBtn
            // 
            this.standBtn.Location = new System.Drawing.Point(263, 222);
            this.standBtn.Name = "standBtn";
            this.standBtn.Size = new System.Drawing.Size(84, 28);
            this.standBtn.TabIndex = 15;
            this.standBtn.Text = "Stand";
            this.standBtn.UseVisualStyleBackColor = true;
            this.standBtn.Click += new System.EventHandler(this.standBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Place Bet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Player Bank";
            // 
            // playerBank
            // 
            this.playerBank.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerBank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerBank.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBank.Location = new System.Drawing.Point(667, 280);
            this.playerBank.Name = "playerBank";
            this.playerBank.Size = new System.Drawing.Size(110, 32);
            this.playerBank.TabIndex = 18;
            this.playerBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 354);
            this.Controls.Add(this.playerBank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.standBtn);
            this.Controls.Add(this.hitBtn);
            this.Controls.Add(this.dealBtn);
            this.Controls.Add(this.DlrScore);
            this.Controls.Add(this.playerCard4);
            this.Controls.Add(this.playerCard3);
            this.Controls.Add(this.playerCard2);
            this.Controls.Add(this.playerCard1);
            this.Controls.Add(this.plyerScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.betAmount);
            this.Controls.Add(this.dealersCard4);
            this.Controls.Add(this.dealersCard3);
            this.Controls.Add(this.dealersCard2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dealersCard1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dealersCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox dealersCard2;
        private System.Windows.Forms.PictureBox dealersCard3;
        private System.Windows.Forms.PictureBox dealersCard4;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label plyerScore;
        private System.Windows.Forms.PictureBox playerCard4;
        private System.Windows.Forms.PictureBox playerCard3;
        private System.Windows.Forms.PictureBox playerCard2;
        private System.Windows.Forms.PictureBox playerCard1;
        private System.Windows.Forms.Label DlrScore;
        private System.Windows.Forms.Button dealBtn;
        private System.Windows.Forms.Button hitBtn;
        private System.Windows.Forms.Button standBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playerBank;
    }
}

