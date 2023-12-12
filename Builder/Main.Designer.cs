namespace Builder
{
    partial class Main
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSubTtl = new TextBox();
            txtVAT = new TextBox();
            txtTtl = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panelBB = new Panel();
            lblWidthmtrs = new Label();
            txtWidth = new TextBox();
            lblWidth = new Label();
            lblDepthmtrs = new Label();
            txtDepth = new TextBox();
            lblDepth = new Label();
            lblmtrs = new Label();
            lblHeightmtrs = new Label();
            label = new Label();
            txtArea = new TextBox();
            txtHeight = new TextBox();
            txtLenght = new TextBox();
            label9 = new Label();
            lblHeight = new Label();
            label7 = new Label();
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            matrialToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBB.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Bricks", "100mm Building Blocks", "200mm Building Blocks", "Concrete", "Kerbing" });
            listBox1.Location = new Point(46, 149);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(140, 169);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(46, 119);
            label1.Name = "label1";
            label1.Size = new Size(179, 20);
            label1.TabIndex = 1;
            label1.Text = "First Select One Material";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(245, 28);
            label2.Name = "label2";
            label2.Size = new Size(276, 37);
            label2.TabIndex = 2;
            label2.Text = "ROBERT'S BUILDERS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Capture8;
            pictureBox1.Location = new Point(563, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 142);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 285);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Sub Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 321);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 5;
            label4.Text = "VAT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 361);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 6;
            label5.Text = "Total";
            // 
            // txtSubTtl
            // 
            txtSubTtl.Location = new Point(360, 285);
            txtSubTtl.Name = "txtSubTtl";
            txtSubTtl.Size = new Size(100, 23);
            txtSubTtl.TabIndex = 7;
            // 
            // txtVAT
            // 
            txtVAT.Location = new Point(360, 318);
            txtVAT.Name = "txtVAT";
            txtVAT.Size = new Size(100, 23);
            txtVAT.TabIndex = 8;
            // 
            // txtTtl
            // 
            txtTtl.Location = new Point(360, 353);
            txtTtl.Name = "txtTtl";
            txtTtl.Size = new Size(100, 23);
            txtTtl.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(118, 398);
            button1.Name = "button1";
            button1.Size = new Size(97, 40);
            button1.TabIndex = 10;
            button1.Text = "New Estimate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(245, 398);
            button2.Name = "button2";
            button2.Size = new Size(97, 40);
            button2.TabIndex = 11;
            button2.Text = "Cost Excld VAT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(369, 398);
            button3.Name = "button3";
            button3.Size = new Size(105, 40);
            button3.TabIndex = 12;
            button3.Text = "Total Incld VAT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(503, 398);
            button4.Name = "button4";
            button4.Size = new Size(106, 40);
            button4.TabIndex = 13;
            button4.Text = "EXIT";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panelBB
            // 
            panelBB.Controls.Add(lblWidthmtrs);
            panelBB.Controls.Add(txtWidth);
            panelBB.Controls.Add(lblWidth);
            panelBB.Controls.Add(lblDepthmtrs);
            panelBB.Controls.Add(txtDepth);
            panelBB.Controls.Add(lblDepth);
            panelBB.Controls.Add(lblmtrs);
            panelBB.Controls.Add(lblHeightmtrs);
            panelBB.Controls.Add(label);
            panelBB.Controls.Add(txtArea);
            panelBB.Controls.Add(txtHeight);
            panelBB.Controls.Add(txtLenght);
            panelBB.Controls.Add(label9);
            panelBB.Controls.Add(lblHeight);
            panelBB.Controls.Add(label7);
            panelBB.Controls.Add(label6);
            panelBB.Location = new Point(245, 77);
            panelBB.Name = "panelBB";
            panelBB.Size = new Size(299, 192);
            panelBB.TabIndex = 14;
            // 
            // lblWidthmtrs
            // 
            lblWidthmtrs.AutoSize = true;
            lblWidthmtrs.Location = new Point(238, 134);
            lblWidthmtrs.Name = "lblWidthmtrs";
            lblWidthmtrs.Size = new Size(31, 15);
            lblWidthmtrs.TabIndex = 40;
            lblWidthmtrs.Text = "mtrs";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(114, 131);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(100, 23);
            txtWidth.TabIndex = 39;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(35, 134);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(39, 15);
            lblWidth.TabIndex = 38;
            lblWidth.Text = "Width";
            // 
            // lblDepthmtrs
            // 
            lblDepthmtrs.AutoSize = true;
            lblDepthmtrs.Location = new Point(238, 102);
            lblDepthmtrs.Name = "lblDepthmtrs";
            lblDepthmtrs.Size = new Size(31, 15);
            lblDepthmtrs.TabIndex = 37;
            lblDepthmtrs.Text = "mtrs";
            // 
            // txtDepth
            // 
            txtDepth.Location = new Point(114, 102);
            txtDepth.Name = "txtDepth";
            txtDepth.Size = new Size(100, 23);
            txtDepth.TabIndex = 36;
            // 
            // lblDepth
            // 
            lblDepth.AutoSize = true;
            lblDepth.Location = new Point(34, 105);
            lblDepth.Name = "lblDepth";
            lblDepth.Size = new Size(39, 15);
            lblDepth.TabIndex = 35;
            lblDepth.Text = "Depth";
            // 
            // lblmtrs
            // 
            lblmtrs.AutoSize = true;
            lblmtrs.Location = new Point(238, 165);
            lblmtrs.Name = "lblmtrs";
            lblmtrs.Size = new Size(0, 15);
            lblmtrs.TabIndex = 21;
            // 
            // lblHeightmtrs
            // 
            lblHeightmtrs.AutoSize = true;
            lblHeightmtrs.Location = new Point(238, 73);
            lblHeightmtrs.Name = "lblHeightmtrs";
            lblHeightmtrs.Size = new Size(31, 15);
            lblHeightmtrs.TabIndex = 20;
            lblHeightmtrs.Text = "mtrs";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(238, 47);
            label.Name = "label";
            label.Size = new Size(31, 15);
            label.TabIndex = 19;
            label.Text = "mtrs";
            // 
            // txtArea
            // 
            txtArea.Location = new Point(115, 157);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(100, 23);
            txtArea.TabIndex = 18;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(114, 73);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 23);
            txtHeight.TabIndex = 17;
            // 
            // txtLenght
            // 
            txtLenght.Location = new Point(114, 44);
            txtLenght.Name = "txtLenght";
            txtLenght.Size = new Size(100, 23);
            txtLenght.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 160);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 4;
            label9.Text = "Area";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(34, 76);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(43, 15);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "Height";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 47);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 2;
            label7.Text = "Lenght";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(34, 9);
            label6.Name = "label6";
            label6.Size = new Size(195, 20);
            label6.TabIndex = 0;
            label6.Text = "Enter the below dimention";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, matrialToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // matrialToolStripMenuItem
            // 
            matrialToolStripMenuItem.Name = "matrialToolStripMenuItem";
            matrialToolStripMenuItem.Size = new Size(67, 20);
            matrialToolStripMenuItem.Text = "Materials";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelBB);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTtl);
            Controls.Add(txtVAT);
            Controls.Add(txtSubTtl);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Form1";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBB.ResumeLayout(false);
            panelBB.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSubTtl;
        private TextBox txtVAT;
        private TextBox txtTtl;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panelBB;
        private Label label6;
        private Panel panelKB;
        private Label lblmtrs;
        private Label lblHeightmtrs;
        private Label label;
        private TextBox txtArea;
        private TextBox txtHeight;
        private TextBox txtLenght;
        private Label label9;
        private Label lblHeight;
        private Label label7;
        private Label lblWidthmtrs;
        private TextBox txtWidth;
        private Label lblWidth;
        private Label lblDepthmtrs;
        private TextBox txtDepth;
        private Label lblDepth;
        private Label label10;
        private Label label12;
        private TextBox txtCumtrs;
        private TextBox txtKBLenght;
        private Label label15;
        private Label label17;
        private Label label18;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem matrialToolStripMenuItem;
    }
}