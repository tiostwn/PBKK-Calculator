namespace CalculatorApp
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
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            n4 = new Button();
            n5 = new Button();
            n6 = new Button();
            n7 = new Button();
            n8 = new Button();
            n9 = new Button();
            n0 = new Button();
            button10 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox = new TextBox();
            button6 = new Button();
            button7 = new Button();
            isCurrentOp = new Label();
            SuspendLayout();
            // 
            // n1
            // 
            n1.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            n1.Location = new Point(23, 148);
            n1.Name = "n1";
            n1.Size = new Size(75, 54);
            n1.TabIndex = 0;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = true;
            n1.Click += n_click;
            // 
            // n2
            // 
            n2.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            n2.Location = new Point(112, 148);
            n2.Name = "n2";
            n2.Size = new Size(75, 54);
            n2.TabIndex = 1;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = true;
            n2.Click += n_click;
            // 
            // n3
            // 
            n3.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            n3.Location = new Point(204, 148);
            n3.Name = "n3";
            n3.Size = new Size(75, 54);
            n3.TabIndex = 2;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = true;
            n3.Click += n_click;
            // 
            // n4
            // 
            n4.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            n4.Location = new Point(23, 225);
            n4.Name = "n4";
            n4.Size = new Size(75, 54);
            n4.TabIndex = 3;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = true;
            n4.Click += n_click;
            // 
            // n5
            // 
            n5.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            n5.Location = new Point(112, 225);
            n5.Name = "n5";
            n5.Size = new Size(75, 54);
            n5.TabIndex = 4;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = true;
            n5.Click += n_click;
            // 
            // n6
            // 
            n6.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            n6.Location = new Point(204, 225);
            n6.Name = "n6";
            n6.Size = new Size(75, 54);
            n6.TabIndex = 5;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = true;
            n6.Click += n_click;
            // 
            // n7
            // 
            n7.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            n7.Location = new Point(23, 303);
            n7.Name = "n7";
            n7.Size = new Size(75, 54);
            n7.TabIndex = 6;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = true;
            n7.Click += n_click;
            // 
            // n8
            // 
            n8.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            n8.Location = new Point(112, 303);
            n8.Name = "n8";
            n8.Size = new Size(75, 54);
            n8.TabIndex = 7;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = true;
            n8.Click += n_click;
            // 
            // n9
            // 
            n9.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            n9.Location = new Point(204, 303);
            n9.Name = "n9";
            n9.Size = new Size(75, 54);
            n9.TabIndex = 8;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = true;
            n9.Click += n_click;
            // 
            // n0
            // 
            n0.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            n0.Location = new Point(23, 378);
            n0.Name = "n0";
            n0.Size = new Size(164, 54);
            n0.TabIndex = 9;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = true;
            n0.Click += n_click;
            // 
            // button10
            // 
            button10.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(301, 148);
            button10.Name = "button10";
            button10.Size = new Size(75, 54);
            button10.TabIndex = 10;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = true;
            button10.Click += n_operation;
            // 
            // button1
            // 
            button1.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(301, 225);
            button1.Name = "button1";
            button1.Size = new Size(75, 54);
            button1.TabIndex = 11;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += n_operation;
            // 
            // button2
            // 
            button2.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(301, 303);
            button2.Name = "button2";
            button2.Size = new Size(75, 54);
            button2.TabIndex = 12;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = true;
            button2.Click += n_operation;
            // 
            // button3
            // 
            button3.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(301, 378);
            button3.Name = "button3";
            button3.Size = new Size(75, 54);
            button3.TabIndex = 13;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = true;
            button3.Click += n_operation;
            // 
            // button4
            // 
            button4.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(204, 378);
            button4.Name = "button4";
            button4.Size = new Size(75, 54);
            button4.TabIndex = 14;
            button4.Text = "Del";
            button4.UseVisualStyleBackColor = true;
            button4.Click += n_delete;
            // 
            // button5
            // 
            button5.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(389, 303);
            button5.Name = "button5";
            button5.Size = new Size(75, 129);
            button5.TabIndex = 15;
            button5.Text = "=";
            button5.UseVisualStyleBackColor = true;
            button5.Click += n_result;
            // 
            // textBox
            // 
            textBox.Font = new Font("Swis721 WGL4 BT", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(23, 77);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(441, 51);
            textBox.TabIndex = 16;
            textBox.Text = "0";
            textBox.TextAlign = HorizontalAlignment.Right;
            // 
            // button6
            // 
            button6.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(389, 148);
            button6.Name = "button6";
            button6.Size = new Size(75, 54);
            button6.TabIndex = 17;
            button6.Text = ".";
            button6.UseVisualStyleBackColor = true;
            button6.Click += n_click;
            // 
            // button7
            // 
            button7.Font = new Font("Swis721 WGL4 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(389, 225);
            button7.Name = "button7";
            button7.Size = new Size(75, 54);
            button7.TabIndex = 18;
            button7.Text = "CE";
            button7.UseVisualStyleBackColor = true;
            button7.Click += n_reset;
            // 
            // isCurrentOp
            // 
            isCurrentOp.AutoSize = true;
            isCurrentOp.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            isCurrentOp.Location = new Point(34, 34);
            isCurrentOp.Name = "isCurrentOp";
            isCurrentOp.Size = new Size(61, 27);
            isCurrentOp.TabIndex = 19;
            isCurrentOp.Text = "label";
            isCurrentOp.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 499);
            Controls.Add(isCurrentOp);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(textBox);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button10);
            Controls.Add(n0);
            Controls.Add(n9);
            Controls.Add(n8);
            Controls.Add(n7);
            Controls.Add(n6);
            Controls.Add(n5);
            Controls.Add(n4);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button n1;
        private Button n2;
        private Button n3;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button n0;
        private Button button10;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox;
        private Button button6;
        private Button button7;
        private Label isCurrentOp;
    }
}