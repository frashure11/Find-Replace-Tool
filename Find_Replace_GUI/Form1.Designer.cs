
namespace Find_Replace_GUI
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
                        this.textBoxFind = new System.Windows.Forms.TextBox();
                        this.textBoxReplace = new System.Windows.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        this.checkBoxSearchSubDirs = new System.Windows.Forms.CheckBox();
                        this.button1 = new System.Windows.Forms.Button();
                        this.buttonSetDirectory = new System.Windows.Forms.Button();
                        this.button3 = new System.Windows.Forms.Button();
                        this.SuspendLayout();
                        // 
                        // textBoxFind
                        // 
                        this.textBoxFind.Location = new System.Drawing.Point(12, 62);
                        this.textBoxFind.Name = "textBoxFind";
                        this.textBoxFind.Size = new System.Drawing.Size(136, 20);
                        this.textBoxFind.TabIndex = 0;
                        // 
                        // textBoxReplace
                        // 
                        this.textBoxReplace.Location = new System.Drawing.Point(12, 108);
                        this.textBoxReplace.Name = "textBoxReplace";
                        this.textBoxReplace.Size = new System.Drawing.Size(136, 20);
                        this.textBoxReplace.TabIndex = 1;
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(9, 46);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(27, 13);
                        this.label1.TabIndex = 2;
                        this.label1.Text = "Find";
                        // 
                        // label2
                        // 
                        this.label2.AutoSize = true;
                        this.label2.Location = new System.Drawing.Point(9, 92);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(47, 13);
                        this.label2.TabIndex = 3;
                        this.label2.Text = "Replace";
                        // 
                        // checkBoxSearchSubDirs
                        // 
                        this.checkBoxSearchSubDirs.AutoSize = true;
                        this.checkBoxSearchSubDirs.Location = new System.Drawing.Point(154, 64);
                        this.checkBoxSearchSubDirs.Name = "checkBoxSearchSubDirs";
                        this.checkBoxSearchSubDirs.Size = new System.Drawing.Size(136, 17);
                        this.checkBoxSearchSubDirs.TabIndex = 4;
                        this.checkBoxSearchSubDirs.Text = "Include Sub-Directories";
                        this.checkBoxSearchSubDirs.UseVisualStyleBackColor = true;
                        // 
                        // button1
                        // 
                        this.button1.Location = new System.Drawing.Point(12, 134);
                        this.button1.Name = "button1";
                        this.button1.Size = new System.Drawing.Size(269, 23);
                        this.button1.TabIndex = 5;
                        this.button1.Text = "Replace";
                        this.button1.UseVisualStyleBackColor = true;
                        this.button1.Click += new System.EventHandler(this.ButtonReplace_Click);
                        // 
                        // buttonSetDirectory
                        // 
                        this.buttonSetDirectory.Location = new System.Drawing.Point(13, 13);
                        this.buttonSetDirectory.Name = "buttonSetDirectory";
                        this.buttonSetDirectory.Size = new System.Drawing.Size(268, 23);
                        this.buttonSetDirectory.TabIndex = 6;
                        this.buttonSetDirectory.Text = "Set Directory";
                        this.buttonSetDirectory.UseVisualStyleBackColor = true;
                        this.buttonSetDirectory.Click += new System.EventHandler(this.ButtonSetDirectory_Click);
                        // 
                        // button3
                        // 
                        this.button3.Location = new System.Drawing.Point(12, 163);
                        this.button3.Name = "button3";
                        this.button3.Size = new System.Drawing.Size(269, 23);
                        this.button3.TabIndex = 7;
                        this.button3.Text = "GitHub";
                        this.button3.UseVisualStyleBackColor = true;
                        this.button3.Click += new System.EventHandler(this.ButtonGitHub_Click);
                        // 
                        // Form1
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(293, 195);
                        this.Controls.Add(this.button3);
                        this.Controls.Add(this.buttonSetDirectory);
                        this.Controls.Add(this.button1);
                        this.Controls.Add(this.checkBoxSearchSubDirs);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.textBoxReplace);
                        this.Controls.Add(this.textBoxFind);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                        this.MaximizeBox = false;
                        this.Name = "Form1";
                        this.ShowIcon = false;
                        this.Text = "Find/Replace Filename Tool";
                        this.Load += new System.EventHandler(this.Form1_Load);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.TextBox textBoxFind;
                private System.Windows.Forms.TextBox textBoxReplace;
                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.CheckBox checkBoxSearchSubDirs;
                private System.Windows.Forms.Button button1;
                private System.Windows.Forms.Button buttonSetDirectory;
                private System.Windows.Forms.Button button3;
        }
}

