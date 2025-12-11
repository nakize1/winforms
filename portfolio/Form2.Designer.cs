namespace portfolio
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
            System.Windows.Forms.Button info2bon;
            System.Windows.Forms.Button skills2bon;
            System.Windows.Forms.Button educ2bon;
            System.Windows.Forms.Button hobbies2bon;
            System.Windows.Forms.Button msg2bon;
            System.Windows.Forms.Button back2bon;
            info2bon = new System.Windows.Forms.Button();
            skills2bon = new System.Windows.Forms.Button();
            educ2bon = new System.Windows.Forms.Button();
            hobbies2bon = new System.Windows.Forms.Button();
            msg2bon = new System.Windows.Forms.Button();
            back2bon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info2bon
            // 
            info2bon.BackColor = System.Drawing.Color.Transparent;
            info2bon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            info2bon.ForeColor = System.Drawing.Color.DimGray;
            info2bon.Location = new System.Drawing.Point(656, 280);
            info2bon.Name = "info2bon";
            info2bon.Size = new System.Drawing.Size(75, 62);
            info2bon.TabIndex = 0;
            info2bon.Text = "+";
            info2bon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            info2bon.UseVisualStyleBackColor = false;
            info2bon.Click += new System.EventHandler(this.info2bon_Click);
            // 
            // skills2bon
            // 
            skills2bon.BackColor = System.Drawing.Color.Transparent;
            skills2bon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            skills2bon.ForeColor = System.Drawing.Color.Gray;
            skills2bon.Location = new System.Drawing.Point(737, 280);
            skills2bon.Name = "skills2bon";
            skills2bon.Size = new System.Drawing.Size(75, 62);
            skills2bon.TabIndex = 1;
            skills2bon.Text = "+";
            skills2bon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            skills2bon.UseVisualStyleBackColor = false;
            skills2bon.Click += new System.EventHandler(this.skills2bon_Click);
            // 
            // educ2bon
            // 
            educ2bon.BackColor = System.Drawing.Color.Transparent;
            educ2bon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            educ2bon.ForeColor = System.Drawing.Color.Gray;
            educ2bon.Location = new System.Drawing.Point(827, 280);
            educ2bon.Name = "educ2bon";
            educ2bon.Size = new System.Drawing.Size(75, 62);
            educ2bon.TabIndex = 2;
            educ2bon.Text = "+";
            educ2bon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            educ2bon.UseVisualStyleBackColor = false;
            educ2bon.Click += new System.EventHandler(this.educ2bon_Click);
            // 
            // hobbies2bon
            // 
            hobbies2bon.BackColor = System.Drawing.Color.Transparent;
            hobbies2bon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            hobbies2bon.ForeColor = System.Drawing.Color.Gray;
            hobbies2bon.Location = new System.Drawing.Point(908, 280);
            hobbies2bon.Name = "hobbies2bon";
            hobbies2bon.Size = new System.Drawing.Size(75, 62);
            hobbies2bon.TabIndex = 3;
            hobbies2bon.Text = "+";
            hobbies2bon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            hobbies2bon.UseVisualStyleBackColor = false;
            hobbies2bon.Click += new System.EventHandler(this.hobbies2bon_Click);
            // 
            // msg2bon
            // 
            msg2bon.BackColor = System.Drawing.Color.Transparent;
            msg2bon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            msg2bon.ForeColor = System.Drawing.Color.DarkGray;
            msg2bon.Location = new System.Drawing.Point(989, 280);
            msg2bon.Name = "msg2bon";
            msg2bon.Size = new System.Drawing.Size(75, 62);
            msg2bon.TabIndex = 4;
            msg2bon.Text = "+";
            msg2bon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            msg2bon.UseVisualStyleBackColor = false;
            msg2bon.Click += new System.EventHandler(this.msg2bon_Click);
            // 
            // back2bon
            // 
            back2bon.BackColor = System.Drawing.Color.Transparent;
            back2bon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            back2bon.ForeColor = System.Drawing.Color.Black;
            back2bon.Location = new System.Drawing.Point(41, 18);
            back2bon.Name = "back2bon";
            back2bon.Size = new System.Drawing.Size(100, 40);
            back2bon.TabIndex = 5;
            back2bon.Text = "+";
            back2bon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            back2bon.UseVisualStyleBackColor = false;
            back2bon.Click += new System.EventHandler(this.back2bon_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::portfolio.Properties.Resources.bontoall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 598);
            this.Controls.Add(back2bon);
            this.Controls.Add(msg2bon);
            this.Controls.Add(hobbies2bon);
            this.Controls.Add(educ2bon);
            this.Controls.Add(skills2bon);
            this.Controls.Add(info2bon);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}