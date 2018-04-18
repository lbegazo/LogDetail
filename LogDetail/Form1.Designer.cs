namespace LogDetail
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.cmbTypeMessage = new System.Windows.Forms.ComboBox();
            this.chkLogFile = new System.Windows.Forms.CheckBox();
            this.chkLogConsole = new System.Windows.Forms.CheckBox();
            this.chkLogDatabase = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkWarning = new System.Windows.Forms.CheckBox();
            this.chkMessage = new System.Windows.Forms.CheckBox();
            this.chkError = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(566, 312);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Log";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(104, 68);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(484, 50);
            this.txtMessage.TabIndex = 1;
            // 
            // cmbTypeMessage
            // 
            this.cmbTypeMessage.FormattingEnabled = true;
            this.cmbTypeMessage.Location = new System.Drawing.Point(104, 30);
            this.cmbTypeMessage.Name = "cmbTypeMessage";
            this.cmbTypeMessage.Size = new System.Drawing.Size(96, 21);
            this.cmbTypeMessage.TabIndex = 2;
            // 
            // chkLogFile
            // 
            this.chkLogFile.AutoSize = true;
            this.chkLogFile.Location = new System.Drawing.Point(137, 38);
            this.chkLogFile.Name = "chkLogFile";
            this.chkLogFile.Size = new System.Drawing.Size(75, 17);
            this.chkLogFile.TabIndex = 5;
            this.chkLogFile.Text = "Log to File";
            this.chkLogFile.UseVisualStyleBackColor = true;
            // 
            // chkLogConsole
            // 
            this.chkLogConsole.AutoSize = true;
            this.chkLogConsole.Location = new System.Drawing.Point(214, 38);
            this.chkLogConsole.Name = "chkLogConsole";
            this.chkLogConsole.Size = new System.Drawing.Size(97, 17);
            this.chkLogConsole.TabIndex = 6;
            this.chkLogConsole.Text = "Log to Console";
            this.chkLogConsole.UseVisualStyleBackColor = true;
            // 
            // chkLogDatabase
            // 
            this.chkLogDatabase.AutoSize = true;
            this.chkLogDatabase.Location = new System.Drawing.Point(317, 38);
            this.chkLogDatabase.Name = "chkLogDatabase";
            this.chkLogDatabase.Size = new System.Drawing.Size(114, 17);
            this.chkLogDatabase.TabIndex = 7;
            this.chkLogDatabase.Text = "Log to a Database";
            this.chkLogDatabase.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Message type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Where is it logged?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "What gets logged?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkWarning);
            this.groupBox1.Controls.Add(this.chkMessage);
            this.groupBox1.Controls.Add(this.chkError);
            this.groupBox1.Controls.Add(this.chkLogDatabase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkLogFile);
            this.groupBox1.Controls.Add(this.chkLogConsole);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(28, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 124);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // chkWarning
            // 
            this.chkWarning.AutoSize = true;
            this.chkWarning.Location = new System.Drawing.Point(317, 73);
            this.chkWarning.Name = "chkWarning";
            this.chkWarning.Size = new System.Drawing.Size(66, 17);
            this.chkWarning.TabIndex = 14;
            this.chkWarning.Text = "Warning";
            this.chkWarning.UseVisualStyleBackColor = true;
            // 
            // chkMessage
            // 
            this.chkMessage.AutoSize = true;
            this.chkMessage.Location = new System.Drawing.Point(137, 73);
            this.chkMessage.Name = "chkMessage";
            this.chkMessage.Size = new System.Drawing.Size(69, 17);
            this.chkMessage.TabIndex = 12;
            this.chkMessage.Text = "Message";
            this.chkMessage.UseVisualStyleBackColor = true;
            // 
            // chkError
            // 
            this.chkError.AutoSize = true;
            this.chkError.Location = new System.Drawing.Point(214, 73);
            this.chkError.Name = "chkError";
            this.chkError.Size = new System.Drawing.Size(48, 17);
            this.chkError.TabIndex = 13;
            this.chkError.Text = "Error";
            this.chkError.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Controls.Add(this.cmbTypeMessage);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 143);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegister);
            this.Name = "Form1";
            this.Text = "Log Message";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ComboBox cmbTypeMessage;
        private System.Windows.Forms.CheckBox chkLogFile;
        private System.Windows.Forms.CheckBox chkLogConsole;
        private System.Windows.Forms.CheckBox chkLogDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkWarning;
        private System.Windows.Forms.CheckBox chkMessage;
        private System.Windows.Forms.CheckBox chkError;
    }
}

