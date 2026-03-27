namespace Labka8
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            lstNumbers = new ListBox();
            btnAdd = new Button();
            btnSortAsc = new Button();
            btnSortDesc = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(25, 187);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(125, 27);
            txtInput.TabIndex = 0;
            // 
            // lstNumbers
            // 
            lstNumbers.FormattingEnabled = true;
            lstNumbers.Location = new Point(624, 12);
            lstNumbers.Name = "lstNumbers";
            lstNumbers.Size = new Size(150, 104);
            lstNumbers.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(328, 187);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSortAsc
            // 
            btnSortAsc.Location = new Point(624, 151);
            btnSortAsc.Name = "btnSortAsc";
            btnSortAsc.Size = new Size(150, 29);
            btnSortAsc.TabIndex = 3;
            btnSortAsc.Text = "За зростанням";
            btnSortAsc.UseVisualStyleBackColor = true;
            btnSortAsc.Click += btnSortAsc_Click;
            // 
            // btnSortDesc
            // 
            btnSortDesc.Location = new Point(624, 213);
            btnSortDesc.Name = "btnSortDesc";
            btnSortDesc.Size = new Size(150, 29);
            btnSortDesc.TabIndex = 4;
            btnSortDesc.Text = "За спаданням";
            btnSortDesc.UseVisualStyleBackColor = true;
            btnSortDesc.Click += btnSortDesc_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSortDesc);
            Controls.Add(btnSortAsc);
            Controls.Add(btnAdd);
            Controls.Add(lstNumbers);
            Controls.Add(txtInput);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private ListBox lstNumbers;
        private Button btnAdd;
        private Button btnSortAsc;
        private Button btnSortDesc;
    }
}