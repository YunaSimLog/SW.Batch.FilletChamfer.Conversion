
namespace SW.Batch.FilletChamfer.Conversion
{
    partial class MainForm
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnConvertChamfer = new DevExpress.XtraEditors.SimpleButton();
            this.btnConvertFillet = new DevExpress.XtraEditors.SimpleButton();
            this.lbFilletList = new DevExpress.XtraEditors.LabelControl();
            this.lbChamferList = new DevExpress.XtraEditors.LabelControl();
            this.lstbFillet = new DevExpress.XtraEditors.ListBoxControl();
            this.lstbChamfer = new DevExpress.XtraEditors.ListBoxControl();
            this.btnAnalModel = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstbFillet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstbChamfer)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.tablePanel1.SetColumn(this.splitContainerControl1, 0);
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(3, 3);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.tablePanel1.SetRow(this.splitContainerControl1, 0);
            this.splitContainerControl1.Size = new System.Drawing.Size(562, 316);
            this.splitContainerControl1.SplitterPosition = 265;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Controls.Add(this.panelControl1);
            this.tablePanel1.Controls.Add(this.splitContainerControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 322F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(568, 371);
            this.tablePanel1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.tablePanel1.SetColumn(this.panelControl1, 0);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnAnalModel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 325);
            this.panelControl1.Name = "panelControl1";
            this.tablePanel1.SetRow(this.panelControl1, 1);
            this.panelControl1.Size = new System.Drawing.Size(562, 43);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lstbFillet);
            this.panelControl2.Controls.Add(this.lbFilletList);
            this.panelControl2.Controls.Add(this.btnConvertChamfer);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(265, 316);
            this.panelControl2.TabIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.lstbChamfer);
            this.panelControl3.Controls.Add(this.lbChamferList);
            this.panelControl3.Controls.Add(this.btnConvertFillet);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(287, 316);
            this.panelControl3.TabIndex = 2;
            // 
            // btnConvertChamfer
            // 
            this.btnConvertChamfer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertChamfer.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertChamfer.Appearance.Options.UseFont = true;
            this.btnConvertChamfer.Location = new System.Drawing.Point(9, 33);
            this.btnConvertChamfer.Name = "btnConvertChamfer";
            this.btnConvertChamfer.Size = new System.Drawing.Size(251, 34);
            this.btnConvertChamfer.TabIndex = 0;
            this.btnConvertChamfer.Text = "모따기로 변환";
            // 
            // btnConvertFillet
            // 
            this.btnConvertFillet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertFillet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertFillet.Appearance.Options.UseFont = true;
            this.btnConvertFillet.Location = new System.Drawing.Point(5, 33);
            this.btnConvertFillet.Name = "btnConvertFillet";
            this.btnConvertFillet.Size = new System.Drawing.Size(273, 34);
            this.btnConvertFillet.TabIndex = 1;
            this.btnConvertFillet.Text = "필렛으로 변환";
            // 
            // lbFilletList
            // 
            this.lbFilletList.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilletList.Appearance.Options.UseFont = true;
            this.lbFilletList.Location = new System.Drawing.Point(9, 9);
            this.lbFilletList.Name = "lbFilletList";
            this.lbFilletList.Size = new System.Drawing.Size(70, 18);
            this.lbFilletList.TabIndex = 1;
            this.lbFilletList.Text = "필렛 리스트";
            // 
            // lbChamferList
            // 
            this.lbChamferList.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChamferList.Appearance.Options.UseFont = true;
            this.lbChamferList.Location = new System.Drawing.Point(5, 9);
            this.lbChamferList.Name = "lbChamferList";
            this.lbChamferList.Size = new System.Drawing.Size(83, 18);
            this.lbChamferList.TabIndex = 2;
            this.lbChamferList.Text = "모따기 리스트";
            // 
            // lstbFillet
            // 
            this.lstbFillet.Location = new System.Drawing.Point(9, 73);
            this.lstbFillet.Name = "lstbFillet";
            this.lstbFillet.Size = new System.Drawing.Size(251, 238);
            this.lstbFillet.TabIndex = 2;
            // 
            // lstbChamfer
            // 
            this.lstbChamfer.Location = new System.Drawing.Point(5, 73);
            this.lstbChamfer.Name = "lstbChamfer";
            this.lstbChamfer.Size = new System.Drawing.Size(273, 238);
            this.lstbChamfer.TabIndex = 3;
            // 
            // btnAnalModel
            // 
            this.btnAnalModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalModel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalModel.Appearance.Options.UseFont = true;
            this.btnAnalModel.Location = new System.Drawing.Point(9, 5);
            this.btnAnalModel.Name = "btnAnalModel";
            this.btnAnalModel.Size = new System.Drawing.Size(139, 33);
            this.btnAnalModel.TabIndex = 1;
            this.btnAnalModel.Text = "모델 분석하기";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(465, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "닫기";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 371);
            this.Controls.Add(this.tablePanel1);
            this.IconOptions.Image = global::SW.Batch.FilletChamfer.Conversion.Properties.Resources.fillet;
            this.Name = "MainForm";
            this.Text = "필렛&모따기 일괄 변환";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstbFillet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstbChamfer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnAnalModel;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.ListBoxControl lstbFillet;
        private DevExpress.XtraEditors.LabelControl lbFilletList;
        private DevExpress.XtraEditors.SimpleButton btnConvertChamfer;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.ListBoxControl lstbChamfer;
        private DevExpress.XtraEditors.LabelControl lbChamferList;
        private DevExpress.XtraEditors.SimpleButton btnConvertFillet;
    }
}