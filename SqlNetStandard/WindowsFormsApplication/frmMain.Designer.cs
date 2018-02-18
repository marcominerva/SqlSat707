namespace WindowsFormsApplication
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        ///
        ///</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        ///
        ///</summary>
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
        ///
        ///</summary>
        private void InitializeComponent()
        {
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.cmdLoadEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEmployees
            // 
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 31;
            this.lstEmployees.Location = new System.Drawing.Point(50, 23);
            this.lstEmployees.Margin = new System.Windows.Forms.Padding(6);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(1158, 283);
            this.lstEmployees.TabIndex = 0;
            // 
            // cmdLoadEmployees
            // 
            this.cmdLoadEmployees.Location = new System.Drawing.Point(844, 318);
            this.cmdLoadEmployees.Margin = new System.Windows.Forms.Padding(6);
            this.cmdLoadEmployees.Name = "cmdLoadEmployees";
            this.cmdLoadEmployees.Size = new System.Drawing.Size(364, 68);
            this.cmdLoadEmployees.TabIndex = 1;
            this.cmdLoadEmployees.Text = "Load Employees";
            this.cmdLoadEmployees.UseVisualStyleBackColor = true;
            this.cmdLoadEmployees.Click += new System.EventHandler(this.cmdLoadEmployees_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 420);
            this.Controls.Add(this.cmdLoadEmployees);
            this.Controls.Add(this.lstEmployees);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.Button cmdLoadEmployees;
    }
}

