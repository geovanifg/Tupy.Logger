namespace SampleProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.grpMessageType = new System.Windows.Forms.GroupBox();
            this.rdbError = new System.Windows.Forms.RadioButton();
            this.rdbWarning = new System.Windows.Forms.RadioButton();
            this.rdbInformation = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grpMessageType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(26, 58);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(741, 22);
            this.txtMessage.TabIndex = 1;
            // 
            // grpMessageType
            // 
            this.grpMessageType.Controls.Add(this.rdbInformation);
            this.grpMessageType.Controls.Add(this.rdbWarning);
            this.grpMessageType.Controls.Add(this.rdbError);
            this.grpMessageType.Location = new System.Drawing.Point(26, 118);
            this.grpMessageType.Name = "grpMessageType";
            this.grpMessageType.Size = new System.Drawing.Size(741, 50);
            this.grpMessageType.TabIndex = 2;
            this.grpMessageType.TabStop = false;
            this.grpMessageType.Text = "Message Type";
            // 
            // rdbError
            // 
            this.rdbError.AutoSize = true;
            this.rdbError.Location = new System.Drawing.Point(18, 18);
            this.rdbError.Name = "rdbError";
            this.rdbError.Size = new System.Drawing.Size(61, 21);
            this.rdbError.TabIndex = 0;
            this.rdbError.TabStop = true;
            this.rdbError.Text = "Error";
            this.rdbError.UseVisualStyleBackColor = true;
            // 
            // rdbWarning
            // 
            this.rdbWarning.AutoSize = true;
            this.rdbWarning.Location = new System.Drawing.Point(313, 18);
            this.rdbWarning.Name = "rdbWarning";
            this.rdbWarning.Size = new System.Drawing.Size(82, 21);
            this.rdbWarning.TabIndex = 1;
            this.rdbWarning.TabStop = true;
            this.rdbWarning.Text = "Warning";
            this.rdbWarning.UseVisualStyleBackColor = true;
            // 
            // rdbInformation
            // 
            this.rdbInformation.AutoSize = true;
            this.rdbInformation.Location = new System.Drawing.Point(608, 18);
            this.rdbInformation.Name = "rdbInformation";
            this.rdbInformation.Size = new System.Drawing.Size(99, 21);
            this.rdbInformation.TabIndex = 2;
            this.rdbInformation.TabStop = true;
            this.rdbInformation.Text = "Information";
            this.rdbInformation.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(634, 237);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(133, 38);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grpMessageType);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grpMessageType.ResumeLayout(false);
            this.grpMessageType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox grpMessageType;
        private System.Windows.Forms.RadioButton rdbInformation;
        private System.Windows.Forms.RadioButton rdbWarning;
        private System.Windows.Forms.RadioButton rdbError;
        private System.Windows.Forms.Button btnRegister;
    }
}

