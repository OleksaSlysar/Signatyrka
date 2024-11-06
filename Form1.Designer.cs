namespace Signatyrka
{
    partial class Form_menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_menu));
            b_pochatok = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            b_Setting = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // b_pochatok
            // 
            b_pochatok.BackColor = SystemColors.ActiveCaption;
            b_pochatok.Cursor = Cursors.Hand;
            b_pochatok.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b_pochatok.Location = new Point(460, 470);
            b_pochatok.Name = "b_pochatok";
            b_pochatok.Size = new Size(394, 106);
            b_pochatok.TabIndex = 0;
            b_pochatok.Text = "Розпочати";
            b_pochatok.UseVisualStyleBackColor = false;
            b_pochatok.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1244, 62);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(532, 98);
            label1.Name = "label1";
            label1.Size = new Size(181, 62);
            label1.TabIndex = 3;
            label1.Text = "Готові?";
            // 
            // b_Setting
            // 
            b_Setting.BackgroundImage = (Image)resources.GetObject("b_Setting.BackgroundImage");
            b_Setting.BackgroundImageLayout = ImageLayout.Stretch;
            b_Setting.Cursor = Cursors.Hand;
            b_Setting.Location = new Point(1108, 106);
            b_Setting.Name = "b_Setting";
            b_Setting.Size = new Size(87, 79);
            b_Setting.TabIndex = 4;
            b_Setting.Text = "button1";
            b_Setting.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.HotTrack;
            button2.Location = new Point(884, 640);
            button2.Name = "button2";
            button2.Size = new Size(349, 56);
            button2.TabIndex = 5;
            button2.Text = "Про програму";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1245, 717);
            Controls.Add(button2);
            Controls.Add(b_Setting);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(b_pochatok);
            Name = "Form_menu";
            Text = "Form1";
            Load += Form_menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_pochatok;
        private PictureBox pictureBox1;
        private Label label1;
        private Button b_Setting;
        private Button button2;
    }
}
