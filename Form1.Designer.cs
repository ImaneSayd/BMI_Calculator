namespace BMI_Project1
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
            lblWeight = new Label();
            lblHeight = new Label();
            lblResult = new Label();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            txtResult = new RichTextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            btnClear = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.BackColor = Color.Gainsboro;
            lblWeight.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeight.Location = new Point(148, 111);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(107, 23);
            lblWeight.TabIndex = 0;
            lblWeight.Text = "Weight (kg)";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.BackColor = Color.Gainsboro;
            lblHeight.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeight.Location = new Point(148, 170);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(106, 23);
            lblHeight.TabIndex = 1;
            lblHeight.Text = "Height (cm)";
            lblHeight.Click += lblHeight_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.LightGray;
            lblResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(148, 234);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(111, 23);
            lblResult.TabIndex = 2;
            lblResult.Text = "BMI (kg/m²)";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(337, 107);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(125, 27);
            txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(337, 170);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 4;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(286, 233);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(227, 120);
            txtResult.TabIndex = 5;
            txtResult.Text = "";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.RoyalBlue;
            btnCalculate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = SystemColors.ButtonHighlight;
            btnCalculate.Location = new Point(286, 359);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(227, 34);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Firebrick;
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(412, 399);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(101, 39);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(286, 399);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 39);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.ActiveCaption;
            lblTitle.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(257, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(283, 61);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "BMI Calculator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtResult);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(lblResult);
            Controls.Add(lblHeight);
            Controls.Add(lblWeight);
            Name = "Form1";
            Text = "BMI Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWeight;
        private Label lblHeight;
        private Label lblResult;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private RichTextBox txtResult;
        private Button btnCalculate;
        private Button btnExit;
        private Button btnClear;
        private Label lblTitle;
    }
}
