
namespace Lab2Cs
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.textC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveA = new System.Windows.Forms.Button();
            this.saveB = new System.Windows.Forms.Button();
            this.saveC = new System.Windows.Forms.Button();
            this.deleteA = new System.Windows.Forms.Button();
            this.deleteB = new System.Windows.Forms.Button();
            this.deleteC = new System.Windows.Forms.Button();
            this.doA = new System.Windows.Forms.Button();
            this.doB = new System.Windows.Forms.Button();
            this.saveAll = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(764, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(518, 40);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(122, 23);
            this.textA.TabIndex = 1;
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(518, 69);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(122, 23);
            this.textB.TabIndex = 2;
            // 
            // textC
            // 
            this.textC.Location = new System.Drawing.Point(518, 98);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(122, 23);
            this.textC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "A =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "B =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "C =";
            // 
            // saveA
            // 
            this.saveA.FlatAppearance.BorderSize = 0;
            this.saveA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveA.Image = ((System.Drawing.Image)(resources.GetObject("saveA.Image")));
            this.saveA.Location = new System.Drawing.Point(664, 39);
            this.saveA.Margin = new System.Windows.Forms.Padding(0);
            this.saveA.Name = "saveA";
            this.saveA.Size = new System.Drawing.Size(22, 22);
            this.saveA.TabIndex = 7;
            this.saveA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveA.UseVisualStyleBackColor = true;
            this.saveA.Click += new System.EventHandler(this.saveA_Click);
            // 
            // saveB
            // 
            this.saveB.FlatAppearance.BorderSize = 0;
            this.saveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveB.Image = ((System.Drawing.Image)(resources.GetObject("saveB.Image")));
            this.saveB.Location = new System.Drawing.Point(664, 68);
            this.saveB.Margin = new System.Windows.Forms.Padding(0);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(22, 22);
            this.saveB.TabIndex = 8;
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // saveC
            // 
            this.saveC.FlatAppearance.BorderSize = 0;
            this.saveC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveC.Image = global::Lab2Cs.Properties.Resources.save1;
            this.saveC.Location = new System.Drawing.Point(664, 97);
            this.saveC.Margin = new System.Windows.Forms.Padding(0);
            this.saveC.Name = "saveC";
            this.saveC.Size = new System.Drawing.Size(22, 22);
            this.saveC.TabIndex = 9;
            this.saveC.UseVisualStyleBackColor = true;
            this.saveC.Click += new System.EventHandler(this.saveC_Click);
            // 
            // deleteA
            // 
            this.deleteA.FlatAppearance.BorderSize = 0;
            this.deleteA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteA.Image = global::Lab2Cs.Properties.Resources.image208;
            this.deleteA.Location = new System.Drawing.Point(698, 40);
            this.deleteA.Margin = new System.Windows.Forms.Padding(0);
            this.deleteA.Name = "deleteA";
            this.deleteA.Size = new System.Drawing.Size(22, 22);
            this.deleteA.TabIndex = 10;
            this.deleteA.UseVisualStyleBackColor = true;
            this.deleteA.Click += new System.EventHandler(this.deleteA_Click);
            // 
            // deleteB
            // 
            this.deleteB.FlatAppearance.BorderSize = 0;
            this.deleteB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteB.Image = global::Lab2Cs.Properties.Resources.image208;
            this.deleteB.Location = new System.Drawing.Point(698, 68);
            this.deleteB.Margin = new System.Windows.Forms.Padding(0);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(22, 22);
            this.deleteB.TabIndex = 11;
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // deleteC
            // 
            this.deleteC.FlatAppearance.BorderSize = 0;
            this.deleteC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteC.Image = global::Lab2Cs.Properties.Resources.image208;
            this.deleteC.Location = new System.Drawing.Point(698, 97);
            this.deleteC.Margin = new System.Windows.Forms.Padding(0);
            this.deleteC.Name = "deleteC";
            this.deleteC.Size = new System.Drawing.Size(22, 22);
            this.deleteC.TabIndex = 12;
            this.deleteC.UseVisualStyleBackColor = true;
            this.deleteC.Click += new System.EventHandler(this.deleteC_Click);
            // 
            // doA
            // 
            this.doA.Location = new System.Drawing.Point(78, 153);
            this.doA.Name = "doA";
            this.doA.Size = new System.Drawing.Size(133, 32);
            this.doA.TabIndex = 13;
            this.doA.Text = "Решить а";
            this.doA.UseVisualStyleBackColor = true;
            this.doA.Click += new System.EventHandler(this.doA_Click);
            // 
            // doB
            // 
            this.doB.Location = new System.Drawing.Point(217, 153);
            this.doB.Name = "doB";
            this.doB.Size = new System.Drawing.Size(133, 32);
            this.doB.TabIndex = 14;
            this.doB.Text = "Решить б";
            this.doB.UseVisualStyleBackColor = true;
            this.doB.Click += new System.EventHandler(this.doB_Click);
            // 
            // saveAll
            // 
            this.saveAll.Location = new System.Drawing.Point(487, 153);
            this.saveAll.Name = "saveAll";
            this.saveAll.Size = new System.Drawing.Size(133, 32);
            this.saveAll.TabIndex = 15;
            this.saveAll.Text = "Сохранить всё";
            this.saveAll.UseVisualStyleBackColor = true;
            this.saveAll.Click += new System.EventHandler(this.saveAll_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(626, 153);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(133, 32);
            this.deleteAll.TabIndex = 16;
            this.deleteAll.Text = "Очистить всё";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 207);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.saveAll);
            this.Controls.Add(this.doB);
            this.Controls.Add(this.doA);
            this.Controls.Add(this.deleteC);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.deleteA);
            this.Controls.Add(this.saveC);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.saveA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveA;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button saveC;
        private System.Windows.Forms.Button deleteA;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button deleteC;
        private System.Windows.Forms.Button doA;
        private System.Windows.Forms.Button doB;
        private System.Windows.Forms.Button saveAll;
        private System.Windows.Forms.Button deleteAll;
    }
}