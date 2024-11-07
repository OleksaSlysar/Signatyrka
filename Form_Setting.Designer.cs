namespace Signatyrka
{
    partial class Form_Setting
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
            label1 = new Label();
            b_povernena = new Button();
            b_na_dvoh = new Button();
            b_AV = new Button();
            b_AVlegko = new Button();
            b_AVvajko = new Button();
            RB_Do1 = new RadioButton();
            RB_Do3 = new RadioButton();
            RB_Do5 = new RadioButton();
            b_SaveSetting = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(417, 38);
            label1.Name = "label1";
            label1.Size = new Size(340, 62);
            label1.TabIndex = 0;
            label1.Text = "Налаштування";
            // 
            // b_povernena
            // 
            b_povernena.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b_povernena.ImageAlign = ContentAlignment.TopLeft;
            b_povernena.Location = new Point(29, 38);
            b_povernena.Name = "b_povernena";
            b_povernena.Size = new Size(223, 62);
            b_povernena.TabIndex = 1;
            b_povernena.Text = "Повернутися";
            b_povernena.UseVisualStyleBackColor = true;
            b_povernena.Click += b_povernena_Click;
            // 
            // b_na_dvoh
            // 
            b_na_dvoh.Anchor = AnchorStyles.None;
            b_na_dvoh.Font = new Font("Segoe UI", 16.2F);
            b_na_dvoh.Location = new Point(517, 106);
            b_na_dvoh.Name = "b_na_dvoh";
            b_na_dvoh.Size = new Size(167, 78);
            b_na_dvoh.TabIndex = 3;
            b_na_dvoh.Text = "На двох";
            b_na_dvoh.UseVisualStyleBackColor = true;
            // 
            // b_AV
            // 
            b_AV.Anchor = AnchorStyles.None;
            b_AV.Font = new Font("Segoe UI", 16.2F);
            b_AV.Location = new Point(517, 349);
            b_AV.Name = "b_AV";
            b_AV.Size = new Size(167, 78);
            b_AV.TabIndex = 4;
            b_AV.Text = "Проти А.В.";
            b_AV.UseVisualStyleBackColor = true;
            // 
            // b_AVlegko
            // 
            b_AVlegko.Anchor = AnchorStyles.None;
            b_AVlegko.Font = new Font("Segoe UI", 16.2F);
            b_AVlegko.Location = new Point(277, 303);
            b_AVlegko.Name = "b_AVlegko";
            b_AVlegko.Size = new Size(167, 78);
            b_AVlegko.TabIndex = 5;
            b_AVlegko.Text = "Легко";
            b_AVlegko.UseVisualStyleBackColor = true;
            // 
            // b_AVvajko
            // 
            b_AVvajko.Anchor = AnchorStyles.None;
            b_AVvajko.Font = new Font("Segoe UI", 16.2F);
            b_AVvajko.Location = new Point(729, 303);
            b_AVvajko.Name = "b_AVvajko";
            b_AVvajko.Size = new Size(211, 78);
            b_AVvajko.TabIndex = 6;
            b_AVvajko.Text = "Не можливо";
            b_AVvajko.UseVisualStyleBackColor = true;
            // 
            // RB_Do1
            // 
            RB_Do1.Anchor = AnchorStyles.None;
            RB_Do1.AutoSize = true;
            RB_Do1.Font = new Font("Segoe UI", 16.2F);
            RB_Do1.Location = new Point(484, 190);
            RB_Do1.Name = "RB_Do1";
            RB_Do1.Size = new Size(227, 42);
            RB_Do1.TabIndex = 7;
            RB_Do1.TabStop = true;
            RB_Do1.Text = "Перемога до 1";
            RB_Do1.UseVisualStyleBackColor = true;
            // 
            // RB_Do3
            // 
            RB_Do3.Anchor = AnchorStyles.None;
            RB_Do3.AutoSize = true;
            RB_Do3.Font = new Font("Segoe UI", 16.2F);
            RB_Do3.Location = new Point(484, 301);
            RB_Do3.Name = "RB_Do3";
            RB_Do3.Size = new Size(227, 42);
            RB_Do3.TabIndex = 8;
            RB_Do3.TabStop = true;
            RB_Do3.Text = "Перемога до 3";
            RB_Do3.UseVisualStyleBackColor = true;
            // 
            // RB_Do5
            // 
            RB_Do5.Anchor = AnchorStyles.None;
            RB_Do5.AutoSize = true;
            RB_Do5.Font = new Font("Segoe UI", 16.2F);
            RB_Do5.Location = new Point(484, 433);
            RB_Do5.Name = "RB_Do5";
            RB_Do5.Size = new Size(227, 42);
            RB_Do5.TabIndex = 9;
            RB_Do5.TabStop = true;
            RB_Do5.Text = "Перемога до 5";
            RB_Do5.UseVisualStyleBackColor = true;
            // 
            // b_SaveSetting
            // 
            b_SaveSetting.Anchor = AnchorStyles.None;
            b_SaveSetting.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b_SaveSetting.Location = new Point(484, 532);
            b_SaveSetting.Name = "b_SaveSetting";
            b_SaveSetting.Size = new Size(200, 75);
            b_SaveSetting.TabIndex = 10;
            b_SaveSetting.Text = "Зберегти";
            b_SaveSetting.UseVisualStyleBackColor = true;
            b_SaveSetting.Click += b_SaveSetting_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.banner;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Location = new Point(0, 650);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1238, 85);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form_Setting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1238, 735);
            Controls.Add(pictureBox1);
            Controls.Add(b_SaveSetting);
            Controls.Add(RB_Do5);
            Controls.Add(RB_Do3);
            Controls.Add(RB_Do1);
            Controls.Add(b_AVvajko);
            Controls.Add(b_AVlegko);
            Controls.Add(b_AV);
            Controls.Add(b_na_dvoh);
            Controls.Add(b_povernena);
            Controls.Add(label1);
            Name = "Form_Setting";
            Text = "Form_Setting";
            Load += Form_Setting_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button b_povernena;
        private Button b_na_dvoh;
        private Button b_AV;
        private Button b_AVlegko;
        private Button b_AVvajko;
        private RadioButton RB_Do1;
        private RadioButton RB_Do3;
        private RadioButton RB_Do5;
        private Button b_SaveSetting;
        private PictureBox pictureBox1;
    }
}