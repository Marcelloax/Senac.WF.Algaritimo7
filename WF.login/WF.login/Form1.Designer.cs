namespace WF.login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Enter = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImage = Properties.Resources.OIP__3_;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(507, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 456);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Aquamarine;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DimGray;
            textBox1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DarkRed;
            textBox1.Location = new Point(121, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 39);
            textBox1.TabIndex = 1;
            textBox1.Text = "Nome";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.RosyBrown;
            textBox2.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.DarkRed;
            textBox2.Location = new Point(121, 179);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Senha";
            textBox2.Size = new Size(274, 39);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // Enter
            // 
            Enter.BackColor = SystemColors.ControlDarkDark;
            Enter.FlatStyle = FlatStyle.Flat;
            Enter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Enter.ForeColor = Color.DarkRed;
            Enter.Location = new Point(194, 242);
            Enter.Name = "Enter";
            Enter.Size = new Size(130, 48);
            Enter.TabIndex = 3;
            Enter.Text = "ENTER";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(181, 398);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(161, 25);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esqueçeu a Senha?";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(70, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.IndianRed;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(803, 456);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel1);
            Controls.Add(Enter);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            ForeColor = SystemColors.GrayText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.85D;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Enter;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
