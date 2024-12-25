using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

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
            textBox_Result = new TextBox();
            button1 = new Button();
            button8 = new Button();
            button = new Button();
            button13 = new Button();
            button14 = new Button();
            button16 = new Button();
            button2 = new Button();
            button7 = new Button();
            button9 = new Button();
            button3 = new Button();
            button6 = new Button();
            button10 = new Button();
            button4 = new Button();
            button5 = new Button();
            button11 = new Button();
            button15 = new Button();
            button17 = new Button();
            button18 = new Button();
            labelCurrentOperation = new Label();
            SuspendLayout();
            // 
            // textBox_Result
            // 
            textBox_Result.Location = new Point(29, 56);
            textBox_Result.Name = "textBox_Result";
            textBox_Result.Size = new Size(532, 27);
            textBox_Result.TabIndex = 0;
            textBox_Result.Text = "0";
            textBox_Result.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(29, 146);
            button1.Name = "button1";
            button1.Size = new Size(74, 29);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_click;
            // 
            // button8
            // 
            button8.Location = new Point(29, 228);
            button8.Name = "button8";
            button8.Size = new Size(74, 29);
            button8.TabIndex = 5;
            button8.Text = "4";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_click;
            // 
            // button
            // 
            button.Location = new Point(29, 309);
            button.Name = "button";
            button.Size = new Size(74, 29);
            button.TabIndex = 9;
            button.Text = "1";
            button.UseVisualStyleBackColor = true;
            button.Click += button_click;
            // 
            // button13
            // 
            button13.Location = new Point(487, 309);
            button13.Name = "button13";
            button13.Size = new Size(74, 110);
            button13.TabIndex = 16;
            button13.Text = "=";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(262, 390);
            button14.Name = "button14";
            button14.Size = new Size(74, 29);
            button14.TabIndex = 15;
            button14.Text = ".";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button_click;
            // 
            // button16
            // 
            button16.Location = new Point(29, 390);
            button16.Name = "button16";
            button16.Size = new Size(188, 29);
            button16.TabIndex = 13;
            button16.Text = "0";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button_click;
            // 
            // button2
            // 
            button2.Location = new Point(143, 309);
            button2.Name = "button2";
            button2.Size = new Size(74, 29);
            button2.TabIndex = 19;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_click;
            // 
            // button7
            // 
            button7.Location = new Point(143, 228);
            button7.Name = "button7";
            button7.Size = new Size(74, 29);
            button7.TabIndex = 18;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_click;
            // 
            // button9
            // 
            button9.Location = new Point(143, 146);
            button9.Name = "button9";
            button9.Size = new Size(74, 29);
            button9.TabIndex = 17;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_click;
            // 
            // button3
            // 
            button3.Location = new Point(262, 309);
            button3.Name = "button3";
            button3.Size = new Size(74, 29);
            button3.TabIndex = 22;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_click;
            // 
            // button6
            // 
            button6.Location = new Point(262, 228);
            button6.Name = "button6";
            button6.Size = new Size(74, 29);
            button6.TabIndex = 21;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_click;
            // 
            // button10
            // 
            button10.Location = new Point(262, 146);
            button10.Name = "button10";
            button10.Size = new Size(74, 29);
            button10.TabIndex = 20;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_click;
            // 
            // button4
            // 
            button4.Location = new Point(384, 309);
            button4.Name = "button4";
            button4.Size = new Size(74, 29);
            button4.TabIndex = 25;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += operator_click;
            // 
            // button5
            // 
            button5.Location = new Point(384, 228);
            button5.Name = "button5";
            button5.Size = new Size(74, 29);
            button5.TabIndex = 24;
            button5.Text = "*";
            button5.UseVisualStyleBackColor = true;
            button5.Click += operator_click;
            // 
            // button11
            // 
            button11.Location = new Point(384, 146);
            button11.Name = "button11";
            button11.Size = new Size(74, 29);
            button11.TabIndex = 23;
            button11.Text = "/";
            button11.UseVisualStyleBackColor = true;
            button11.Click += operator_click;
            // 
            // button15
            // 
            button15.Location = new Point(487, 228);
            button15.Name = "button15";
            button15.Size = new Size(74, 29);
            button15.TabIndex = 27;
            button15.Text = "C";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button17
            // 
            button17.Location = new Point(487, 146);
            button17.Name = "button17";
            button17.Size = new Size(74, 29);
            button17.TabIndex = 26;
            button17.Text = "CE";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Location = new Point(384, 390);
            button18.Name = "button18";
            button18.Size = new Size(74, 29);
            button18.TabIndex = 28;
            button18.Text = "+";
            button18.UseVisualStyleBackColor = true;
            button18.Click += operator_click;
            // 
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.Location = new Point(29, 22);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(13, 20);
            labelCurrentOperation.TabIndex = 29;
            labelCurrentOperation.Text = " ";
            labelCurrentOperation.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 563);
            Controls.Add(labelCurrentOperation);
            Controls.Add(button18);
            Controls.Add(button15);
            Controls.Add(button17);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button11);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(button10);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(button9);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button16);
            Controls.Add(button);
            Controls.Add(button8);
            Controls.Add(button1);
            Controls.Add(textBox_Result);
            Name = "Form1";
            Text = "Calculator";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Result;
        private Button button1;
        private Button button8;
        private Button button;
        private Button button13;
        private Button button14;
        private Button button16;
        private Button button2;
        private Button button7;
        private Button button9;
        private Button button3;
        private Button button6;
        private Button button10;
        private Button button4;
        private Button button5;
        private Button button11;
        private Button button15;
        private Button button17;
        private Button button18;
        private Label labelCurrentOperation;
    }
}