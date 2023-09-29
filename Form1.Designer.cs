namespace FileIODemo
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreateDictionary = new System.Windows.Forms.Button();
            this.btnCreateFille = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnStreamwrite = new System.Windows.Forms.Button();
            this.btnstreamRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(238, 59);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(232, 26);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(238, 124);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(232, 26);
            this.TxtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salary";
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(238, 184);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(232, 26);
            this.TxtSalary.TabIndex = 5;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(152, 280);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(155, 62);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(328, 280);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(142, 62);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCreateDictionary
            // 
            this.btnCreateDictionary.Location = new System.Drawing.Point(531, 59);
            this.btnCreateDictionary.Name = "btnCreateDictionary";
            this.btnCreateDictionary.Size = new System.Drawing.Size(156, 63);
            this.btnCreateDictionary.TabIndex = 8;
            this.btnCreateDictionary.Text = "Create Dictionary";
            this.btnCreateDictionary.UseVisualStyleBackColor = true;
            this.btnCreateDictionary.Click += new System.EventHandler(this.btnCreateDictionary_Click);
            // 
            // btnCreateFille
            // 
            this.btnCreateFille.Location = new System.Drawing.Point(531, 218);
            this.btnCreateFille.Name = "btnCreateFille";
            this.btnCreateFille.Size = new System.Drawing.Size(158, 65);
            this.btnCreateFille.TabIndex = 9;
            this.btnCreateFille.Text = "Create File";
            this.btnCreateFille.UseVisualStyleBackColor = true;
            this.btnCreateFille.Click += new System.EventHandler(this.btnCreateFille_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(777, 67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(383, 136);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // btnStreamwrite
            // 
            this.btnStreamwrite.Location = new System.Drawing.Point(800, 239);
            this.btnStreamwrite.Name = "btnStreamwrite";
            this.btnStreamwrite.Size = new System.Drawing.Size(154, 65);
            this.btnStreamwrite.TabIndex = 11;
            this.btnStreamwrite.Text = "Stream Write";
            this.btnStreamwrite.UseVisualStyleBackColor = true;
            this.btnStreamwrite.Click += new System.EventHandler(this.btnStreamwrite_Click);
            // 
            // btnstreamRead
            // 
            this.btnstreamRead.Location = new System.Drawing.Point(978, 239);
            this.btnstreamRead.Name = "btnstreamRead";
            this.btnstreamRead.Size = new System.Drawing.Size(138, 65);
            this.btnstreamRead.TabIndex = 12;
            this.btnstreamRead.Text = "Stream Read";
            this.btnstreamRead.UseVisualStyleBackColor = true;
            this.btnstreamRead.Click += new System.EventHandler(this.btnstreamRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 621);
            this.Controls.Add(this.btnstreamRead);
            this.Controls.Add(this.btnStreamwrite);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCreateFille);
            this.Controls.Add(this.btnCreateDictionary);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.TxtSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreateDictionary;
        private System.Windows.Forms.Button btnCreateFille;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnStreamwrite;
        private System.Windows.Forms.Button btnstreamRead;
    }
}

