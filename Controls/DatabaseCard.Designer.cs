﻿namespace DoQL.Controls
{
    partial class DatabaseCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LastModified = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DatabaseType = new System.Windows.Forms.Label();
            this.DatabaseName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastModified
            // 
            this.LastModified.AutoSize = true;
            this.LastModified.ForeColor = System.Drawing.Color.Gray;
            this.LastModified.Location = new System.Drawing.Point(132, 195);
            this.LastModified.Name = "LastModified";
            this.LastModified.Size = new System.Drawing.Size(85, 20);
            this.LastModified.TabIndex = 10;
            this.LastModified.Text = "14/03/2002";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(19, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last modified :";
            // 
            // DatabaseType
            // 
            this.DatabaseType.AutoSize = true;
            this.DatabaseType.Location = new System.Drawing.Point(19, 101);
            this.DatabaseType.Name = "DatabaseType";
            this.DatabaseType.Size = new System.Drawing.Size(107, 20);
            this.DatabaseType.TabIndex = 8;
            this.DatabaseType.Text = "Database Type";
            // 
            // DatabaseName
            // 
            this.DatabaseName.AutoSize = true;
            this.DatabaseName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DatabaseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.DatabaseName.Location = new System.Drawing.Point(28, 27);
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.Size = new System.Drawing.Size(103, 20);
            this.DatabaseName.TabIndex = 7;
            this.DatabaseName.Text = "System name";
            // 
            // DatabaseCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.LastModified);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DatabaseType);
            this.Controls.Add(this.DatabaseName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DatabaseCard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(240, 240);
            this.Load += new System.EventHandler(this.DatabaseCard_Load);
            this.Click += new System.EventHandler(this.OpenDiagram);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LastModified;
        private Label label4;
        private Label DatabaseType;
        private Label DatabaseName;
    }
}
