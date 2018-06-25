namespace ecourier
{
    partial class AddEmployees
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.UserNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.employeeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecourierDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecourierDatabaseDataSet = new ecourier.ecourierDatabaseDataSet();
            this.PasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForisActive = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.employeeTableTableAdapter = new ecourier.ecourierDatabaseDataSetTableAdapters.EmployeeTableTableAdapter();
            this.isAdminUser = new DevExpress.XtraEditors.CheckEdit();
            this.isAdmin = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecourierDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecourierDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForisActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAdminUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.isAdminUser);
            this.dataLayoutControl1.Controls.Add(this.UserNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PasswordTextEdit);
            this.dataLayoutControl1.Controls.Add(this.isActiveCheckEdit);
            this.dataLayoutControl1.DataSource = this.employeeTableBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(45, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(145, 213, 650, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(343, 126);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // UserNameTextEdit
            // 
            this.UserNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeTableBindingSource, "UserName", true));
            this.UserNameTextEdit.Location = new System.Drawing.Point(67, 12);
            this.UserNameTextEdit.Name = "UserNameTextEdit";
            this.UserNameTextEdit.Size = new System.Drawing.Size(264, 20);
            this.UserNameTextEdit.StyleController = this.dataLayoutControl1;
            this.UserNameTextEdit.TabIndex = 4;
            // 
            // employeeTableBindingSource
            // 
            this.employeeTableBindingSource.DataMember = "EmployeeTable";
            this.employeeTableBindingSource.DataSource = this.ecourierDatabaseDataSetBindingSource;
            // 
            // ecourierDatabaseDataSetBindingSource
            // 
            this.ecourierDatabaseDataSetBindingSource.DataSource = this.ecourierDatabaseDataSet;
            this.ecourierDatabaseDataSetBindingSource.Position = 0;
            // 
            // ecourierDatabaseDataSet
            // 
            this.ecourierDatabaseDataSet.DataSetName = "ecourierDatabaseDataSet";
            this.ecourierDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PasswordTextEdit
            // 
            this.PasswordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeTableBindingSource, "Password", true));
            this.PasswordTextEdit.Location = new System.Drawing.Point(67, 36);
            this.PasswordTextEdit.Name = "PasswordTextEdit";
            this.PasswordTextEdit.Size = new System.Drawing.Size(264, 20);
            this.PasswordTextEdit.StyleController = this.dataLayoutControl1;
            this.PasswordTextEdit.TabIndex = 5;
            // 
            // isActiveCheckEdit
            // 
            this.isActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeTableBindingSource, "isActive", true));
            this.isActiveCheckEdit.Location = new System.Drawing.Point(12, 60);
            this.isActiveCheckEdit.Name = "isActiveCheckEdit";
            this.isActiveCheckEdit.Properties.Caption = "is Active";
            this.isActiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.isActiveCheckEdit.Size = new System.Drawing.Size(157, 19);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(343, 126);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUserName,
            this.ItemForisActive,
            this.ItemForPassword,
            this.isAdmin});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(323, 106);
            // 
            // ItemForUserName
            // 
            this.ItemForUserName.Control = this.UserNameTextEdit;
            this.ItemForUserName.Location = new System.Drawing.Point(0, 0);
            this.ItemForUserName.Name = "ItemForUserName";
            this.ItemForUserName.Size = new System.Drawing.Size(323, 24);
            this.ItemForUserName.Text = "User Name";
            this.ItemForUserName.TextSize = new System.Drawing.Size(52, 13);
            // 
            // ItemForisActive
            // 
            this.ItemForisActive.Control = this.isActiveCheckEdit;
            this.ItemForisActive.Location = new System.Drawing.Point(0, 48);
            this.ItemForisActive.Name = "ItemForisActive";
            this.ItemForisActive.Size = new System.Drawing.Size(161, 58);
            this.ItemForisActive.Text = "is Active";
            this.ItemForisActive.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForisActive.TextVisible = false;
            // 
            // ItemForPassword
            // 
            this.ItemForPassword.Control = this.PasswordTextEdit;
            this.ItemForPassword.Location = new System.Drawing.Point(0, 24);
            this.ItemForPassword.Name = "ItemForPassword";
            this.ItemForPassword.Size = new System.Drawing.Size(323, 24);
            this.ItemForPassword.Text = "Password";
            this.ItemForPassword.TextSize = new System.Drawing.Size(52, 13);
            // 
            // windowsUIButtonPanelCloseButton
            // 
            this.windowsUIButtonPanelCloseButton.ButtonInterval = 0;
            windowsUIButtonImageOptions1.ImageUri.Uri = "Backward;Size32x32;GrayScaled";
            this.windowsUIButtonPanelCloseButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanelCloseButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButtonPanelCloseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowsUIButtonPanelCloseButton.ForeColor = System.Drawing.Color.Gray;
            this.windowsUIButtonPanelCloseButton.Location = new System.Drawing.Point(0, 0);
            this.windowsUIButtonPanelCloseButton.MaximumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.MinimumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.Name = "windowsUIButtonPanelCloseButton";
            this.windowsUIButtonPanelCloseButton.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanelCloseButton.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.windowsUIButtonPanelCloseButton.Size = new System.Drawing.Size(45, 156);
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
            windowsUIButtonImageOptions2.ImageUri.Uri = "SaveAndClose;Size32x32;GrayScaled";
            windowsUIButtonImageOptions3.ImageUri.Uri = "SaveAndNew;Size32x32;GrayScaled";
            this.windowsUIButtonPanelMain.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And Close", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And New", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanelMain.EnableImageTransparency = true;
            this.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanelMain.Location = new System.Drawing.Point(0, 156);
            this.windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 60);
            this.windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(60, 60);
            this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.Size = new System.Drawing.Size(388, 60);
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
            this.labelControl.Size = new System.Drawing.Size(343, 30);
            this.labelControl.TabIndex = 1;
            this.labelControl.Text = "Employee";
            // 
            // employeeTableTableAdapter
            // 
            this.employeeTableTableAdapter.ClearBeforeFill = true;
            // 
            // isAdminUser
            // 
            this.isAdminUser.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeTableBindingSource, "isActive", true));
            this.isAdminUser.Location = new System.Drawing.Point(173, 60);
            this.isAdminUser.Name = "isAdminUser";
            this.isAdminUser.Properties.Caption = "is Admin";
            this.isAdminUser.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.isAdminUser.Size = new System.Drawing.Size(158, 19);
            this.isAdminUser.StyleController = this.dataLayoutControl1;
            this.isAdminUser.TabIndex = 7;
            // 
            // isAdmin
            // 
            this.isAdmin.Control = this.isAdminUser;
            this.isAdmin.Location = new System.Drawing.Point(161, 48);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Size = new System.Drawing.Size(162, 58);
            this.isAdmin.TextSize = new System.Drawing.Size(0, 0);
            this.isAdmin.TextVisible = false;
            // 
            // AddEmployees
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(388, 216);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelCloseButton);
            this.Controls.Add(this.windowsUIButtonPanelMain);
            this.Name = "AddEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecourierDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecourierDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForisActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAdminUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private System.Windows.Forms.BindingSource ecourierDatabaseDataSetBindingSource;
        private ecourierDatabaseDataSet ecourierDatabaseDataSet;
        private System.Windows.Forms.BindingSource employeeTableBindingSource;
        private ecourierDatabaseDataSetTableAdapters.EmployeeTableTableAdapter employeeTableTableAdapter;
        private DevExpress.XtraEditors.TextEdit UserNameTextEdit;
        private DevExpress.XtraEditors.TextEdit PasswordTextEdit;
        private DevExpress.XtraEditors.CheckEdit isActiveCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUserName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPassword;
        private DevExpress.XtraLayout.LayoutControlItem ItemForisActive;
        private DevExpress.XtraEditors.CheckEdit isAdminUser;
        private DevExpress.XtraLayout.LayoutControlItem isAdmin;
    }

}