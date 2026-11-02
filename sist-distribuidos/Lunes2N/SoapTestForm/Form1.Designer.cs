namespace SoapTestForm
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
            num1 = new NumericUpDown();
            num2 = new NumericUpDown();
            operationBox = new ComboBox();
            sendBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)num1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num2).BeginInit();
            SuspendLayout();
            // 
            // num1
            // 
            num1.Location = new Point(41, 42);
            num1.Name = "num1";
            num1.Size = new Size(120, 23);
            num1.TabIndex = 0;
            // 
            // num2
            // 
            num2.Location = new Point(41, 89);
            num2.Name = "num2";
            num2.Size = new Size(120, 23);
            num2.TabIndex = 1;
            // 
            // operationBox
            // 
            operationBox.FormattingEnabled = true;
            operationBox.Items.AddRange(new object[] { "Add", "Multiply", "Divide", "Substract" });
            operationBox.Location = new Point(220, 42);
            operationBox.Name = "operationBox";
            operationBox.Size = new Size(148, 23);
            operationBox.TabIndex = 2;
            operationBox.Text = "Choose Operation";
            // 
            // sendBtn
            // 
            sendBtn.Location = new Point(220, 89);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(148, 23);
            sendBtn.TabIndex = 3;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 179);
            Controls.Add(sendBtn);
            Controls.Add(operationBox);
            Controls.Add(num2);
            Controls.Add(num1);
            Name = "Form1";
            Text = "Soap Calc";
            ((System.ComponentModel.ISupportInitialize)num1).EndInit();
            ((System.ComponentModel.ISupportInitialize)num2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown num1;
        private NumericUpDown num2;
        private ComboBox operationBox;
        private Button sendBtn;
    }
}