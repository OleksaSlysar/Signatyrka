namespace Signatyrka
{
    partial class Form_Gra
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
            components = new System.ComponentModel.Container();
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            picPlayer = new PictureBox();
            picCPU = new PictureBox();
            txtMessage = new Label();
            roundsText = new Label();
            button4 = new Button();
            txtTime = new Label();
            countDownTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCPU).BeginInit();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Location = new Point(64, 148);
            btnRock.Margin = new Padding(4, 5, 4, 5);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(100, 35);
            btnRock.TabIndex = 0;
            btnRock.Text = "Камінь";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(64, 235);
            btnPaper.Margin = new Padding(4, 5, 4, 5);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(100, 35);
            btnPaper.TabIndex = 0;
            btnPaper.Text = "Папір";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(64, 321);
            btnScissors.Margin = new Padding(4, 5, 4, 5);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(100, 35);
            btnScissors.TabIndex = 0;
            btnScissors.Text = "Ножниці";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // picPlayer
            // 
            picPlayer.Location = new Point(261, 139);
            picPlayer.Margin = new Padding(3, 4, 3, 4);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(209, 192);
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer.TabIndex = 1;
            picPlayer.TabStop = false;
            // 
            // picCPU
            // 
            picCPU.Location = new Point(800, 125);
            picCPU.Margin = new Padding(3, 4, 3, 4);
            picCPU.Name = "picCPU";
            picCPU.Size = new Size(197, 192);
            picCPU.SizeMode = PictureBoxSizeMode.StretchImage;
            picCPU.TabIndex = 1;
            picCPU.TabStop = false;
            // 
            // txtMessage
            // 
            txtMessage.AutoSize = true;
            txtMessage.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMessage.Location = new Point(516, 148);
            txtMessage.Margin = new Padding(4, 0, 4, 0);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(239, 29);
            txtMessage.TabIndex = 2;
            txtMessage.Text = "Гравець: 0 - Бот: 0";
            txtMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundsText
            // 
            roundsText.AutoSize = true;
            roundsText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundsText.Location = new Point(564, 479);
            roundsText.Margin = new Padding(4, 0, 4, 0);
            roundsText.Name = "roundsText";
            roundsText.Size = new Size(123, 29);
            roundsText.TabIndex = 2;
            roundsText.Text = "Rounds 3";
            // 
            // button4
            // 
            button4.Location = new Point(920, 558);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(100, 35);
            button4.TabIndex = 3;
            button4.Text = "Зпочатку";
            button4.UseVisualStyleBackColor = true;
            button4.Click += restartGame;
            // 
            // txtTime
            // 
            txtTime.AutoSize = true;
            txtTime.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTime.Location = new Point(600, 286);
            txtTime.Margin = new Padding(4, 0, 4, 0);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(64, 31);
            txtTime.TabIndex = 2;
            txtTime.Text = "Час";
            // 
            // countDownTimer
            // 
            countDownTimer.Interval = 1000;
            countDownTimer.Tick += countDownTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 4;
            label1.Text = "Гравець";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(895, 68);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 4;
            label4.Text = "Бот";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Dock = DockStyle.Top;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1308, 83);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // Form_Gra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 619);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(roundsText);
            Controls.Add(txtTime);
            Controls.Add(txtMessage);
            Controls.Add(picCPU);
            Controls.Add(picPlayer);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form_Gra";
            Text = "Lr2";
            Load += Form_Gra_Load;
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCPU).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picCPU;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.Label roundsText;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
