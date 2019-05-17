namespace Scheduler
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labActualDate = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labDate = new MetroFramework.Controls.MetroLabel();
            this.labDateFrom = new MetroFramework.Controls.MetroLabel();
            this.labDateTo = new MetroFramework.Controls.MetroLabel();
            this.labBreakFrom = new MetroFramework.Controls.MetroLabel();
            this.labBreakTo = new MetroFramework.Controls.MetroLabel();
            this.labWorkHours = new MetroFramework.Controls.MetroLabel();
            this.labOverflow = new MetroFramework.Controls.MetroLabel();
            this.labHolidays = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labActualDate
            // 
            this.labActualDate.AutoSize = true;
            this.labActualDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labActualDate.Location = new System.Drawing.Point(993, 22);
            this.labActualDate.Name = "labActualDate";
            this.labActualDate.Size = new System.Drawing.Size(86, 25);
            this.labActualDate.TabIndex = 0;
            this.labActualDate.Text = "17.05.2019";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.labHolidays, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.labOverflow, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.labWorkHours, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labBreakTo, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labBreakFrom, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labDateTo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labDateFrom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labDate, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 118);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1056, 401);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labDate
            // 
            this.labDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDate.AutoSize = true;
            this.labDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labDate.Location = new System.Drawing.Point(42, 21);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(47, 25);
            this.labDate.TabIndex = 2;
            this.labDate.Text = "Date";
            // 
            // labDateFrom
            // 
            this.labDateFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDateFrom.AutoSize = true;
            this.labDateFrom.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labDateFrom.Location = new System.Drawing.Point(171, 21);
            this.labDateFrom.Name = "labDateFrom";
            this.labDateFrom.Size = new System.Drawing.Size(51, 25);
            this.labDateFrom.TabIndex = 3;
            this.labDateFrom.Text = "From";
            // 
            // labDateTo
            // 
            this.labDateTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDateTo.AutoSize = true;
            this.labDateTo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labDateTo.Location = new System.Drawing.Point(314, 21);
            this.labDateTo.Name = "labDateTo";
            this.labDateTo.Size = new System.Drawing.Size(28, 25);
            this.labDateTo.TabIndex = 4;
            this.labDateTo.Text = "To";
            // 
            // labBreakFrom
            // 
            this.labBreakFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labBreakFrom.AutoSize = true;
            this.labBreakFrom.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labBreakFrom.Location = new System.Drawing.Point(411, 21);
            this.labBreakFrom.Name = "labBreakFrom";
            this.labBreakFrom.Size = new System.Drawing.Size(95, 25);
            this.labBreakFrom.TabIndex = 5;
            this.labBreakFrom.Text = "Break from";
            // 
            // labBreakTo
            // 
            this.labBreakTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labBreakTo.AutoSize = true;
            this.labBreakTo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labBreakTo.Location = new System.Drawing.Point(552, 21);
            this.labBreakTo.Name = "labBreakTo";
            this.labBreakTo.Size = new System.Drawing.Size(75, 25);
            this.labBreakTo.TabIndex = 6;
            this.labBreakTo.Text = "Break To";
            // 
            // labWorkHours
            // 
            this.labWorkHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labWorkHours.AutoSize = true;
            this.labWorkHours.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labWorkHours.Location = new System.Drawing.Point(692, 21);
            this.labWorkHours.Name = "labWorkHours";
            this.labWorkHours.Size = new System.Drawing.Size(57, 25);
            this.labWorkHours.TabIndex = 7;
            this.labWorkHours.Text = "Hours";
            // 
            // labOverflow
            // 
            this.labOverflow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labOverflow.AutoSize = true;
            this.labOverflow.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labOverflow.Location = new System.Drawing.Point(811, 21);
            this.labOverflow.Name = "labOverflow";
            this.labOverflow.Size = new System.Drawing.Size(81, 25);
            this.labOverflow.TabIndex = 8;
            this.labOverflow.Text = "Overflow";
            // 
            // labHolidays
            // 
            this.labHolidays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labHolidays.AutoSize = true;
            this.labHolidays.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labHolidays.Location = new System.Drawing.Point(952, 21);
            this.labHolidays.Name = "labHolidays";
            this.labHolidays.Size = new System.Drawing.Size(69, 25);
            this.labHolidays.TabIndex = 9;
            this.labHolidays.Text = "Holiday";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 589);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labActualDate);
            this.Name = "Main";
            this.Text = "Scheduler";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labActualDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel labDate;
        private MetroFramework.Controls.MetroLabel labHolidays;
        private MetroFramework.Controls.MetroLabel labOverflow;
        private MetroFramework.Controls.MetroLabel labWorkHours;
        private MetroFramework.Controls.MetroLabel labBreakTo;
        private MetroFramework.Controls.MetroLabel labBreakFrom;
        private MetroFramework.Controls.MetroLabel labDateTo;
        private MetroFramework.Controls.MetroLabel labDateFrom;
    }
}

