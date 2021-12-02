
namespace ListBoxDragDrop
{
    partial class SetWorkDay
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
            this.lstOrderWorkDayPerson = new System.Windows.Forms.ListBox();
            this.btnAddWorkDayPerson = new System.Windows.Forms.Button();
            this.btnDeleteWorkDayPerson = new System.Windows.Forms.Button();
            this.txtWorkDayPerson = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstOrderWorkDayPerson
            // 
            this.lstOrderWorkDayPerson.FormattingEnabled = true;
            this.lstOrderWorkDayPerson.ItemHeight = 12;
            this.lstOrderWorkDayPerson.Location = new System.Drawing.Point(12, 38);
            this.lstOrderWorkDayPerson.Name = "lstOrderWorkDayPerson";
            this.lstOrderWorkDayPerson.Size = new System.Drawing.Size(157, 256);
            this.lstOrderWorkDayPerson.TabIndex = 0;
            this.lstOrderWorkDayPerson.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstOrderWorkDayPerson_DragDrop);
            this.lstOrderWorkDayPerson.DragOver += new System.Windows.Forms.DragEventHandler(this.lstOrderWorkDayPerson_DragOver);
            this.lstOrderWorkDayPerson.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstOrderWorkDayPerson_MouseDown);
            // 
            // btnAddWorkDayPerson
            // 
            this.btnAddWorkDayPerson.Location = new System.Drawing.Point(103, 9);
            this.btnAddWorkDayPerson.Name = "btnAddWorkDayPerson";
            this.btnAddWorkDayPerson.Size = new System.Drawing.Size(66, 23);
            this.btnAddWorkDayPerson.TabIndex = 1;
            this.btnAddWorkDayPerson.Text = "新增人員";
            this.btnAddWorkDayPerson.UseVisualStyleBackColor = true;
            this.btnAddWorkDayPerson.Click += new System.EventHandler(this.btnAddWorkDayPerson_Click);
            // 
            // btnDeleteWorkDayPerson
            // 
            this.btnDeleteWorkDayPerson.Location = new System.Drawing.Point(72, 300);
            this.btnDeleteWorkDayPerson.Name = "btnDeleteWorkDayPerson";
            this.btnDeleteWorkDayPerson.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteWorkDayPerson.TabIndex = 2;
            this.btnDeleteWorkDayPerson.Text = "刪除點選人員";
            this.btnDeleteWorkDayPerson.UseVisualStyleBackColor = true;
            this.btnDeleteWorkDayPerson.Click += new System.EventHandler(this.btnDeleteWorkDayPerson_Click);
            // 
            // txtWorkDayPerson
            // 
            this.txtWorkDayPerson.Location = new System.Drawing.Point(12, 9);
            this.txtWorkDayPerson.Name = "txtWorkDayPerson";
            this.txtWorkDayPerson.Size = new System.Drawing.Size(85, 22);
            this.txtWorkDayPerson.TabIndex = 3;
            // 
            // SetWorkDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.txtWorkDayPerson);
            this.Controls.Add(this.btnDeleteWorkDayPerson);
            this.Controls.Add(this.btnAddWorkDayPerson);
            this.Controls.Add(this.lstOrderWorkDayPerson);
            this.Name = "SetWorkDay";
            this.Text = "SetWorkDay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOrderWorkDayPerson;
        private System.Windows.Forms.Button btnAddWorkDayPerson;
        private System.Windows.Forms.Button btnDeleteWorkDayPerson;
        private System.Windows.Forms.TextBox txtWorkDayPerson;
    }
}