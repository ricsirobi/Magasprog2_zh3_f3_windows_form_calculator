namespace Szamologep
{//tc92hl
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        
        /// <param name="toDespose">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool toDespose)
        {
            if (toDespose && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(toDespose);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_numOne = new System.Windows.Forms.TextBox();
            this.label_number = new System.Windows.Forms.Label();
            this.button_intake = new System.Windows.Forms.Button();
            this.radioButton_add = new System.Windows.Forms.RadioButton();
            this.radioButton_sub = new System.Windows.Forms.RadioButton();
            this.radioButton_mul = new System.Windows.Forms.RadioButton();
            this.radioButton_div = new System.Windows.Forms.RadioButton();
            this.label_operation = new System.Windows.Forms.Label();
            this.groupBox_operations = new System.Windows.Forms.GroupBox();
            this.textBox_numTwo = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.panel_numbers = new System.Windows.Forms.Panel();
            this.button_new = new System.Windows.Forms.Button();
            this.groupBox_operations.SuspendLayout();
            this.panel_numbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bináris számológép c#";
            // 
            // textBox_numOne
            // 
            this.textBox_numOne.Location = new System.Drawing.Point(3, 4);
            this.textBox_numOne.Name = "textBox_numOne";
            this.textBox_numOne.Size = new System.Drawing.Size(125, 20);
            this.textBox_numOne.TabIndex = 7;
            this.textBox_numOne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_numOne_KeyPress);
            // 
            // label_number
            // 
            this.label_number.Location = new System.Drawing.Point(12, 161);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(100, 19);
            this.label_number.TabIndex = 8;
            this.label_number.Text = "1. szám:";
            this.label_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_intake
            // 
            this.button_intake.Location = new System.Drawing.Point(150, 415);
            this.button_intake.Name = "button_intake";
            this.button_intake.Size = new System.Drawing.Size(100, 23);
            this.button_intake.TabIndex = 10;
            this.button_intake.Text = "Be";
            this.button_intake.UseVisualStyleBackColor = true;
            this.button_intake.Click += new System.EventHandler(this.Button_intake_Click);
            // 
            // radioButton_add
            // 
            this.radioButton_add.AutoSize = true;
            this.radioButton_add.Checked = true;
            this.radioButton_add.Location = new System.Drawing.Point(8, 38);
            this.radioButton_add.Name = "radioButton_add";
            this.radioButton_add.Size = new System.Drawing.Size(31, 17);
            this.radioButton_add.TabIndex = 11;
            this.radioButton_add.TabStop = true;
            this.radioButton_add.Text = "+";
            this.radioButton_add.UseVisualStyleBackColor = true;
            // 
            // radioButton_sub
            // 
            this.radioButton_sub.AutoSize = true;
            this.radioButton_sub.Location = new System.Drawing.Point(8, 61);
            this.radioButton_sub.Name = "radioButton_sub";
            this.radioButton_sub.Size = new System.Drawing.Size(28, 17);
            this.radioButton_sub.TabIndex = 12;
            this.radioButton_sub.Text = "-";
            this.radioButton_sub.UseVisualStyleBackColor = true;
            // 
            // radioButton_mul
            // 
            this.radioButton_mul.AutoSize = true;
            this.radioButton_mul.Location = new System.Drawing.Point(60, 38);
            this.radioButton_mul.Name = "radioButton_mul";
            this.radioButton_mul.Size = new System.Drawing.Size(30, 17);
            this.radioButton_mul.TabIndex = 13;
            this.radioButton_mul.Text = "x";
            this.radioButton_mul.UseVisualStyleBackColor = true;
            this.radioButton_mul.CheckedChanged += new System.EventHandler(this.radioButton_mul_CheckedChanged);
            // 
            // radioButton_div
            // 
            this.radioButton_div.AutoSize = true;
            this.radioButton_div.Location = new System.Drawing.Point(60, 62);
            this.radioButton_div.Name = "radioButton_div";
            this.radioButton_div.Size = new System.Drawing.Size(30, 17);
            this.radioButton_div.TabIndex = 14;
            this.radioButton_div.Text = "/";
            this.radioButton_div.UseVisualStyleBackColor = true;
            // 
            // label_operation
            // 
            this.label_operation.Location = new System.Drawing.Point(5, 16);
            this.label_operation.Name = "label_operation";
            this.label_operation.Size = new System.Drawing.Size(100, 19);
            this.label_operation.TabIndex = 15;
            this.label_operation.Text = "Operandus";
            this.label_operation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_operations
            // 
            this.groupBox_operations.Controls.Add(this.label_operation);
            this.groupBox_operations.Controls.Add(this.radioButton_add);
            this.groupBox_operations.Controls.Add(this.radioButton_div);
            this.groupBox_operations.Controls.Add(this.radioButton_sub);
            this.groupBox_operations.Controls.Add(this.radioButton_mul);
            this.groupBox_operations.Location = new System.Drawing.Point(148, 257);
            this.groupBox_operations.Name = "groupBox_operations";
            this.groupBox_operations.Size = new System.Drawing.Size(105, 92);
            this.groupBox_operations.TabIndex = 16;
            this.groupBox_operations.TabStop = false;
            this.groupBox_operations.Visible = false;
            // 
            // textBox_numTwo
            // 
            this.textBox_numTwo.Location = new System.Drawing.Point(3, 28);
            this.textBox_numTwo.Name = "textBox_numTwo";
            this.textBox_numTwo.Size = new System.Drawing.Size(122, 20);
            this.textBox_numTwo.TabIndex = 18;
            this.textBox_numTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_numTwo_KeyPress);
            // 
            // textBox_result
            // 
            this.textBox_result.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_result.Location = new System.Drawing.Point(12, 49);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_result.Size = new System.Drawing.Size(269, 75);
            this.textBox_result.TabIndex = 19;
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel_numbers
            // 
            this.panel_numbers.Controls.Add(this.textBox_numOne);
            this.panel_numbers.Controls.Add(this.textBox_numTwo);
            this.panel_numbers.Location = new System.Drawing.Point(137, 147);
            this.panel_numbers.Name = "panel_numbers";
            this.panel_numbers.Size = new System.Drawing.Size(128, 54);
            this.panel_numbers.TabIndex = 22;
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(38, 415);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(100, 23);
            this.button_new.TabIndex = 23;
            this.button_new.Text = "Új számolás";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Visible = false;
            this.button_new.Click += new System.EventHandler(this.Button_new_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 450);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.panel_numbers);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.groupBox_operations);
            this.Controls.Add(this.button_intake);
            this.Controls.Add(this.label1);
            this.Name = "Calculator";
            this.Text = "Számológép";
            this.groupBox_operations.ResumeLayout(false);
            this.groupBox_operations.PerformLayout();
            this.panel_numbers.ResumeLayout(false);
            this.panel_numbers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_numOne;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Button button_intake;
        private System.Windows.Forms.RadioButton radioButton_add;
        private System.Windows.Forms.RadioButton radioButton_sub;
        private System.Windows.Forms.RadioButton radioButton_mul;
        private System.Windows.Forms.RadioButton radioButton_div;
        private System.Windows.Forms.Label label_operation;//tc92hl
        private System.Windows.Forms.GroupBox groupBox_operations;
        private System.Windows.Forms.TextBox textBox_numTwo;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Panel panel_numbers;
        private System.Windows.Forms.Button button_new;
    }
}

