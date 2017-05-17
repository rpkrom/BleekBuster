namespace MeramecNetFlixProject.UI
{
    partial class MemberReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.teamdDataSet = new MeramecNetFlixProject.teamdDataSet();
            this.mEMBERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEMBERTableAdapter = new MeramecNetFlixProject.teamdDataSetTableAdapters.MEMBERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teamdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMember";
            reportDataSource1.Value = this.mEMBERBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MeramecNetFlixProject.UI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(822, 537);
            this.reportViewer1.TabIndex = 0;
            // 
            // teamdDataSet
            // 
            this.teamdDataSet.DataSetName = "teamdDataSet";
            this.teamdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEMBERBindingSource
            // 
            this.mEMBERBindingSource.DataMember = "MEMBER";
            this.mEMBERBindingSource.DataSource = this.teamdDataSet;
            // 
            // mEMBERTableAdapter
            // 
            this.mEMBERTableAdapter.ClearBeforeFill = true;
            // 
            // MemberReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 537);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MemberReport";
            this.Text = "MemberReport";
            this.Load += new System.EventHandler(this.MemberReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private teamdDataSet teamdDataSet;
        private System.Windows.Forms.BindingSource mEMBERBindingSource;
        private teamdDataSetTableAdapters.MEMBERTableAdapter mEMBERTableAdapter;
    }
}