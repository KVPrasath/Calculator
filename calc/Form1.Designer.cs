namespace calc
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
            panel1 = new Panel();
            Del = new Button();
            equal = new Button();
            div = new Button();
            mul = new Button();
            pnt = new Button();
            sub = new Button();
            add = new Button();
            fullDelete = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Del);
            panel1.Controls.Add(equal);
            panel1.Controls.Add(div);
            panel1.Controls.Add(mul);
            panel1.Controls.Add(pnt);
            panel1.Controls.Add(sub);
            panel1.Controls.Add(add);
            panel1.Controls.Add(fullDelete);
            panel1.Controls.Add(btn0);
            panel1.Controls.Add(btn9);
            panel1.Controls.Add(btn8);
            panel1.Controls.Add(btn7);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 317);
            panel1.TabIndex = 0;
            // 
            // Del
            // 
            Del.BackColor = Color.Crimson;
            Del.BackgroundImageLayout = ImageLayout.None;
            Del.FlatStyle = FlatStyle.Flat;
            Del.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Del.Location = new Point(3, 292);
            Del.Name = "Del";
            Del.Size = new Size(218, 25);
            Del.TabIndex = 18;
            Del.Text = "Delete";
            Del.UseVisualStyleBackColor = false;
            Del.Click += Del_Click;
            // 
            // equal
            // 
            equal.BackColor = SystemColors.MenuHighlight;
            equal.BackgroundImageLayout = ImageLayout.None;
            equal.FlatStyle = FlatStyle.Flat;
            equal.Location = new Point(3, 267);
            equal.Name = "equal";
            equal.Size = new Size(218, 25);
            equal.TabIndex = 17;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // div
            // 
            div.Location = new Point(171, 211);
            div.Name = "div";
            div.Size = new Size(50, 50);
            div.TabIndex = 16;
            div.Text = "/";
            div.UseVisualStyleBackColor = true;
            div.Click += div_Click;
            // 
            // mul
            // 
            mul.Location = new Point(171, 43);
            mul.Name = "mul";
            mul.Size = new Size(50, 50);
            mul.TabIndex = 15;
            mul.Text = "X";
            mul.UseVisualStyleBackColor = true;
            mul.Click += mul_Click;
            // 
            // pnt
            // 
            pnt.Location = new Point(3, 211);
            pnt.Name = "pnt";
            pnt.Size = new Size(50, 50);
            pnt.TabIndex = 14;
            pnt.Text = ".";
            pnt.UseVisualStyleBackColor = true;
            pnt.Click += pnt_Click;
            // 
            // sub
            // 
            sub.Location = new Point(171, 155);
            sub.Name = "sub";
            sub.Size = new Size(50, 50);
            sub.TabIndex = 13;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = true;
            sub.Click += sub_Click;
            // 
            // add
            // 
            add.Location = new Point(171, 99);
            add.Name = "add";
            add.Size = new Size(50, 50);
            add.TabIndex = 12;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // fullDelete
            // 
            fullDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fullDelete.Location = new Point(115, 211);
            fullDelete.Name = "fullDelete";
            fullDelete.Size = new Size(50, 50);
            fullDelete.TabIndex = 11;
            fullDelete.Text = "C";
            fullDelete.UseVisualStyleBackColor = true;
            fullDelete.Click += fullDelete_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(59, 211);
            btn0.Name = "btn0";
            btn0.Size = new Size(50, 50);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(115, 155);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 50);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(59, 155);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 50);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(3, 155);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 50);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(115, 99);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 50);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(59, 99);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 50);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(3, 99);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 50);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(115, 43);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 50);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(59, 43);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 50);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(3, 43);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 50);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 341);
            Controls.Add(panel1);
            Name = "Form1";
            ShowIcon = false;
            Text = "Calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Del;
        private Button equal;
        private Button div;
        private Button mul;
        private Button pnt;
        private Button sub;
        private Button add;
        private Button fullDelete;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private TextBox textBox1;
    }
}