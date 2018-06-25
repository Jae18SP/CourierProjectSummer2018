namespace ecourier
{
    partial class AddCustomer
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
        ///
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.CustomerNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustomerMobileTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCustomerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustomerMobile = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForisActive = new DevExpress.XtraLayout.LayoutControlItem();
            this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.customerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecourierDatabaseDataSet = new ecourier.ecourierDatabaseDataSet();
            this.customerTableTableAdapter = new ecourier.ecourierDatabaseDataSetTableAdapters.CustomerTableTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMobileTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForisActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecourierDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.comboBox1);
            this.dataLayoutControl1.Controls.Add(this.CustomerNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CustomerMobileTextEdit);
            this.dataLayoutControl1.Controls.Add(this.isActiveCheckEdit);
            this.dataLayoutControl1.DataSource = this.customerTableBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(45, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(401, 182);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // CustomerNameTextEdit
            // 
            this.CustomerNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerTableBindingSource, "CustomerName", true));
            this.CustomerNameTextEdit.Location = new System.Drawing.Point(94, 12);
            this.CustomerNameTextEdit.Name = "CustomerNameTextEdit";
            this.CustomerNameTextEdit.Size = new System.Drawing.Size(295, 20);
            this.CustomerNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CustomerNameTextEdit.TabIndex = 4;
            // 
            // CustomerMobileTextEdit
            // 
            this.CustomerMobileTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerTableBindingSource, "CustomerMobile", true));
            this.CustomerMobileTextEdit.Location = new System.Drawing.Point(94, 36);
            this.CustomerMobileTextEdit.Name = "CustomerMobileTextEdit";
            this.CustomerMobileTextEdit.Size = new System.Drawing.Size(295, 20);
            this.CustomerMobileTextEdit.StyleController = this.dataLayoutControl1;
            this.CustomerMobileTextEdit.TabIndex = 5;
            // 
            // isActiveCheckEdit
            // 
            this.isActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerTableBindingSource, "isActive", true));
            this.isActiveCheckEdit.Location = new System.Drawing.Point(12, 85);
            this.isActiveCheckEdit.Name = "isActiveCheckEdit";
            this.isActiveCheckEdit.Properties.Caption = "is Active";
            this.isActiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.isActiveCheckEdit.Size = new System.Drawing.Size(377, 19);
            this.isActiveCheckEdit.StyleController = this.dataLayoutControl1;
            this.isActiveCheckEdit.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(401, 182);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCustomerName,
            this.ItemForCustomerMobile,
            this.ItemForisActive,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(381, 162);
            // 
            // ItemForCustomerName
            // 
            this.ItemForCustomerName.Control = this.CustomerNameTextEdit;
            this.ItemForCustomerName.Location = new System.Drawing.Point(0, 0);
            this.ItemForCustomerName.Name = "ItemForCustomerName";
            this.ItemForCustomerName.Size = new System.Drawing.Size(381, 24);
            this.ItemForCustomerName.Text = "Customer Name";
            this.ItemForCustomerName.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForCustomerMobile
            // 
            this.ItemForCustomerMobile.Control = this.CustomerMobileTextEdit;
            this.ItemForCustomerMobile.Location = new System.Drawing.Point(0, 24);
            this.ItemForCustomerMobile.Name = "ItemForCustomerMobile";
            this.ItemForCustomerMobile.Size = new System.Drawing.Size(381, 24);
            this.ItemForCustomerMobile.Text = "Customer Mobile";
            this.ItemForCustomerMobile.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForisActive
            // 
            this.ItemForisActive.Control = this.isActiveCheckEdit;
            this.ItemForisActive.Location = new System.Drawing.Point(0, 73);
            this.ItemForisActive.Name = "ItemForisActive";
            this.ItemForisActive.Size = new System.Drawing.Size(381, 89);
            this.ItemForisActive.Text = "is Active";
            this.ItemForisActive.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForisActive.TextVisible = false;
            // 
            // windowsUIButtonPanelCloseButton
            // 
            this.windowsUIButtonPanelCloseButton.ButtonInterval = 0;
            windowsUIButtonImageOptions4.ImageUri.Uri = "Backward;Size32x32;GrayScaled";
            this.windowsUIButtonPanelCloseButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanelCloseButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButtonPanelCloseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowsUIButtonPanelCloseButton.ForeColor = System.Drawing.Color.Gray;
            this.windowsUIButtonPanelCloseButton.Location = new System.Drawing.Point(0, 0);
            this.windowsUIButtonPanelCloseButton.MaximumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.MinimumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.Name = "windowsUIButtonPanelCloseButton";
            this.windowsUIButtonPanelCloseButton.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanelCloseButton.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.windowsUIButtonPanelCloseButton.Size = new System.Drawing.Size(45, 212);
            this.windowsUIButtonPanelCloseButton.TabIndex = 2;
            this.windowsUIButtonPanelCloseButton.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanelCloseButton.UseButtonBackgroundImages = false;
            // 
            // windowsUIButtonPanelMain
            // 
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            windowsUIButtonImageOptions5.ImageUri.Uri = "SaveAndClose;Size32x32;GrayScaled";
            windowsUIButtonImageOptions6.ImageUri.Uri = "SaveAndNew;Size32x32;GrayScaled";
            this.windowsUIButtonPanelMain.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And Close", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And New", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanelMain.EnableImageTransparency = true;
            this.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanelMain.Location = new System.Drawing.Point(0, 212);
            this.windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 60);
            this.windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(60, 60);
            this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.Size = new System.Drawing.Size(446, 60);
            this.windowsUIButtonPanelMain.TabIndex = 3;
            this.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanelMain.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanelMain_ButtonClick);
            // 
            // labelControl
            // 
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.Options.UseFont = true;
            this.labelControl.Appearance.Options.UseForeColor = true;
            this.labelControl.Appearance.Options.UseTextOptions = true;
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Location = new System.Drawing.Point(45, 0);
            this.labelControl.Name = "labelControl";
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.labelControl.Size = new System.Drawing.Size(401, 30);
            this.labelControl.TabIndex = 1;
            this.labelControl.Text = "Customer";
            // 
            // customerTableBindingSource
            // 
            this.customerTableBindingSource.DataMember = "CustomerTable";
            this.customerTableBindingSource.DataSource = this.ecourierDatabaseDataSet;
            // 
            // ecourierDatabaseDataSet
            // 
            this.ecourierDatabaseDataSet.DataSetName = "ecourierDatabaseDataSet";
            this.ecourierDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableTableAdapter
            // 
            this.customerTableTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.comboBox1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(381, 25);
            this.layoutControlItem1.Text = "PickUp";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 13);
            // 
            // AddCustomer
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(446, 272);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelCloseButton);
            this.Controls.Add(this.windowsUIButtonPanelMain);
            this.Name = "AddCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMobileTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForisActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecourierDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private ecourierDatabaseDataSet ecourierDatabaseDataSet;
        private System.Windows.Forms.BindingSource customerTableBindingSource;
        private ecourierDatabaseDataSetTableAdapters.CustomerTableTableAdapter customerTableTableAdapter;
        private DevExpress.XtraEditors.TextEdit CustomerNameTextEdit;
        private DevExpress.XtraEditors.TextEdit CustomerMobileTextEdit;
        private DevExpress.XtraEditors.CheckEdit isActiveCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerMobile;
        private DevExpress.XtraLayout.LayoutControlItem ItemForisActive;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }

}