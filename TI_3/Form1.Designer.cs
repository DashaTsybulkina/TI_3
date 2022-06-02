namespace TI_3
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
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_K = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_r = new System.Windows.Forms.TextBox();
            this.textBox_ks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_ko = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(173, 72);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(178, 27);
            this.textBox_p.TabIndex = 0;
            this.textBox_p.TextChanged += new System.EventHandler(this.textBox_p_TextChanged);
            this.textBox_p.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_p_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите q:";
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(173, 130);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(174, 27);
            this.textBox_q.TabIndex = 3;
            this.textBox_q.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_q_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(580, 43);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(334, 222);
            this.textBoxInput.TabIndex = 6;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(580, 318);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(334, 222);
            this.textBoxOutput.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "Открыть файл";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox_K
            // 
            this.textBox_K.Location = new System.Drawing.Point(173, 194);
            this.textBox_K.Name = "textBox_K";
            this.textBox_K.Size = new System.Drawing.Size(174, 27);
            this.textBox_K.TabIndex = 9;
            this.textBox_K.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_K_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите K(секретный):";
            // 
            // textBox_r
            // 
            this.textBox_r.Location = new System.Drawing.Point(169, 333);
            this.textBox_r.Name = "textBox_r";
            this.textBox_r.Size = new System.Drawing.Size(178, 27);
            this.textBox_r.TabIndex = 11;
            this.textBox_r.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_r_KeyPress);
            // 
            // textBox_ks
            // 
            this.textBox_ks.Location = new System.Drawing.Point(173, 386);
            this.textBox_ks.Name = "textBox_ks";
            this.textBox_ks.Size = new System.Drawing.Size(174, 27);
            this.textBox_ks.TabIndex = 12;
            this.textBox_ks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ks_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Введите K(секретный):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Введите r:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Исходный текст:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(580, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Конечный текст:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 311);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 29);
            this.button4.TabIndex = 17;
            this.button4.Text = "Открыть файл";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox_m
            // 
            this.textBox_m.Location = new System.Drawing.Point(385, 72);
            this.textBox_m.Name = "textBox_m";
            this.textBox_m.ReadOnly = true;
            this.textBox_m.Size = new System.Drawing.Size(178, 27);
            this.textBox_m.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Функция Эйлера:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "N:";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(385, 130);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.ReadOnly = true;
            this.textBox_n.Size = new System.Drawing.Size(178, 27);
            this.textBox_n.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "K(откртый):";
            // 
            // textBox_ko
            // 
            this.textBox_ko.Location = new System.Drawing.Point(385, 194);
            this.textBox_ko.Name = "textBox_ko";
            this.textBox_ko.ReadOnly = true;
            this.textBox_ko.Size = new System.Drawing.Size(178, 27);
            this.textBox_ko.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(926, 552);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_ko);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_m);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ks);
            this.Controls.Add(this.textBox_r);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_K);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_p);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_p;
        private Label label1;
        private Label label2;
        private TextBox textBox_q;
        private Button button1;
        private Button button2;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private Button button3;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox_K;
        private Label label3;
        private TextBox textBox_r;
        private TextBox textBox_ks;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button4;
        private TextBox textBox_m;
        private Label label8;
        private Label label9;
        private TextBox textBox_n;
        private Label label10;
        private TextBox textBox_ko;
    }
}