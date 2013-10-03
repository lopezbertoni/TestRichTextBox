namespace TestRichTextBox
{
    partial class Form1
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
            this.btnAddRight = new System.Windows.Forms.Button();
            this.btnAddLeft = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAddRight
            // 
            this.btnAddRight.Location = new System.Drawing.Point(13, 22);
            this.btnAddRight.Name = "btnAddRight";
            this.btnAddRight.Size = new System.Drawing.Size(129, 36);
            this.btnAddRight.TabIndex = 0;
            this.btnAddRight.Text = "Add Text Right";
            this.btnAddRight.UseVisualStyleBackColor = true;
            this.btnAddRight.Click += new System.EventHandler(this.btnAddRight_Click);
            // 
            // btnAddLeft
            // 
            this.btnAddLeft.Location = new System.Drawing.Point(13, 64);
            this.btnAddLeft.Name = "btnAddLeft";
            this.btnAddLeft.Size = new System.Drawing.Size(129, 36);
            this.btnAddLeft.TabIndex = 1;
            this.btnAddLeft.Text = "Add Text Left";
            this.btnAddLeft.UseVisualStyleBackColor = true;
            this.btnAddLeft.Click += new System.EventHandler(this.btnAddLeft_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(186, 22);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(313, 186);
            this.txtText.TabIndex = 2;
            this.txtText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 240);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnAddLeft);
            this.Controls.Add(this.btnAddRight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRight;
        private System.Windows.Forms.Button btnAddLeft;
        private System.Windows.Forms.RichTextBox txtText;
    }
}

