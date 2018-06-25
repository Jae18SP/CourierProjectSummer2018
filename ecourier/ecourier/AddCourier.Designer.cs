namespace ecourier
{
    partial class AddCourier
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
            this.CourierNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ecourierDatabaseDataSet = new ecourier.ecourierDatabaseDataSet();
            this.ContactNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.WorkingHoursDateEdit = new DevExpress.XtraEditors.TimeEdit();
            this.WorkingHoursDateEditTo = new DevExpress.XtraEditors.TimeEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCourierName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWorkingHours = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForisActive = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForContactNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWorkingHours1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.courierTableTableAdapter = new ecourier.ecourierDatabaseDataSetTableAdapters.CourierTableTableAdapter();
            this.courierTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourierNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecourierDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingHoursDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingHoursDateEditTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCourierName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWorkingHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForisActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWorkingHours1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courierTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.CourierNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ContactNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.isActiveCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.WorkingHoursDateEdit);
            this.dataLayoutControl1.Controls.Add(this.WorkingHoursDateEditTo);
            this.dataLayoutControl1.DataSource = this.courierTableBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(45, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(603, 4, 650, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(503, 221);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // CourierNameTextEdit
            // 
            this.CourierNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.courierTableBindingSource, "CourierName", true));
            this.CourierNameTextEdit.Location = new System.Drawing.Point(112, 12);
            this.CourierNameTextEdit.Name = "CourierNameTextEdit";
            this.CourierNameTextEdit.Size = new System.Drawing.Size(137, 20);
            this.CourierNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CourierNameTextEdit.TabIndex = 4;
            // 
            // ecourierDatabaseDataSet
            // 
            this.ecourierDatabaseDataSet.DataSetName = "ecourierDatabaseDataSet";
            this.ecourierDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ContactNumberTextEdit
            // 
            this.ContactNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.courierTableBindingSource, "ContactNumber", true));
            this.ContactNumberTextEdit.Location = new System.Drawing.Point(353, 12);
            this.ContactNumberTextEdit.Name = "ContactNumberTextEdit";
            this.ContactNumberTextEdit.Size = new System.Drawing.Size(138, 20);
            this.ContactNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.ContactNumberTextEdit.TabIndex = 5;
            // 
            // isActiveCheckEdit
            // 
            this.isActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.courierTableBindingSource, "isActive", true));
            this.isActiveCheckEdit.Location = new System.Drawing.Point(12, 60);
            this.isActiveCheckEdit.Name = "isActiveCheckEdit";
            this.isActiveCheckEdit.Properties.Caption = "is Active";
            this.isActiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.isActiveCheckEdit.Size = new System.Drawing.Size(479, 19);
            this.isActiveCheckEdit.StyleController = this.dataLayoutControl1;
            this.isActiveCheckEdit.TabIndex = 7;
            // 
            // WorkingHoursDateEdit
            // 
            this.WorkingHoursDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.courierTableBindingSource, "WorkingHours", true));
            this.WorkingHoursDateEdit.EditValue = new System.DateTime(2018, 6, 10, 16, 16, 0, 0);
            this.WorkingHoursDateEdit.Location = new System.Drawing.Point(112, 36);
            this.WorkingHoursDateEdit.Name = "WorkingHoursDateEdit";
            this.WorkingHoursDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WorkingHoursDateEdit.Properties.DisplayFormat.FormatString = "t";
            this.WorkingHoursDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.WorkingHoursDateEdit.Properties.EditFormat.FormatString = "t";
            this.WorkingHoursDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.WorkingHoursDateEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.WorkingHoursDateEdit.Properties.Mask.EditMask = "t";
            this.WorkingHoursDateEdit.Size = new System.Drawing.Size(137, 20);
            this.WorkingHoursDateEdit.StyleController = this.dataLayoutControl1;
            this.WorkingHoursDateEdit.TabIndex = 6;
            // 
            // WorkingHoursDateEditTo
            // 
            this.WorkingHoursDateEditTo.EditValue = new System.DateTime(2018, 6, 10, 16, 16, 15, 194);
            this.WorkingHoursDateEditTo.Location = new System.Drawing.Point(353, 36);
            this.WorkingHoursDateEditTo.Name = "WorkingHoursDateEditTo";
            this.WorkingHoursDateEditTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WorkingHoursDateEditTo.Properties.DisplayFormat.FormatString = "t";
            this.WorkingHoursDateEditTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.WorkingHoursDateEditTo.Properties.EditFormat.FormatString = "t";
            this.WorkingHoursDateEditTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.WorkingHoursDateEditTo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.WorkingHoursDateEditTo.Properties.Mask.EditMask = "t";
            this.WorkingHoursDateEditTo.Size = new System.Drawing.Size(138, 20);
            this.WorkingHoursDateEditTo.StyleController = this.dataLayoutControl1;
            this.WorkingHoursDateEditTo.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(503, 221);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCourierName,
            this.ItemForWorkingHours,
            this.ItemForisActive,
            this.ItemForContactNumber,
            this.ItemForWorkingHours1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(483, 201);
            // 
            // ItemForCourierName
            // 
            this.ItemForCourierName.Control = this.CourierNameTextEdit;
            this.ItemForCourierName.Location = new System.Drawing.Point(0, 0);
            this.ItemForCourierName.Name = "ItemForCourierName";
            this.ItemForCourierName.Size = new System.Drawing.Size(241, 24);
            this.ItemForCourierName.Text = "Courier Name";
            this.ItemForCourierName.TextSize = new System.Drawing.Size(97, 13);
            // 
            // ItemForWorkingHours
            // 
            this.ItemForWorkingHours.Control = this.WorkingHoursDateEdit;
            this.ItemForWorkingHours.Location = new System.Drawing.Point(0, 24);
            this.ItemForWorkingHours.Name = "ItemForWorkingHours";
            this.ItemForWorkingHours.Size = new System.Drawing.Size(241, 24);
            this.ItemForWorkingHours.Text = "Working Hours From";
            this.ItemForWorkingHours.TextSize = new System.Drawing.Size(97, 13);
            // 
            // ItemForisActive
            // 
            this.ItemForisActive.Control = this.isActiveCheckEdit;
            this.ItemForisActive.Location = new System.Drawing.Point(0, 48);
            this.ItemForisActive.Name = "ItemForisActive";
            this.ItemForisActive.Size = new System.Drawing.Size(483, 153);
            this.ItemForisActive.Text = "is Active";
            this.ItemForisActive.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForisActive.TextVisible = false;
            // 
            // ItemForContactNumber
            // 
            this.ItemForContactNumber.Control = this.ContactNumberTextEdit;
            this.ItemForContactNumber.Location = new System.Drawing.Point(241, 0);
            this.ItemForContactNumber.Name = "ItemForContactNumber";
            this.ItemForContactNumber.Size = new System.Drawing.Size(242, 24);
            this.ItemForContactNumber.Text = "Contact Number";
            this.ItemForContactNumber.TextSize = new System.Drawing.Size(97, 13);
            // 
            // ItemForWorkingHours1
            // 
            this.ItemForWorkingHours1.Control = this.WorkingHoursDateEditTo;
            this.ItemForWorkingHours1.CustomizationFormText = "Working Hours";
            this.ItemForWorkingHours1.Location = new System.Drawing.Point(241, 24);
            this.ItemForWorkingHours1.Name = "ItemForWorkingHours1";
            this.ItemForWorkingHours1.Size = new System.Drawing.Size(242, 24);
            this.ItemForWorkingHours1.Text = "Working Hours To";
            this.ItemForWorkingHours1.TextSize = new System.Drawing.Size(97, 13);
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
            this.windowsUIButtonPanelCloseButton.Size = new System.Drawing.Size(45, 251);
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
            this.windowsUIButtonPanelMain.Location = new System.Drawing.Point(0, 251);
            this.windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 60);
            this.windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(60, 60);
            this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.Size = new System.Drawing.Size(548, 60);
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
            this.labelControl.Size = new System.Drawing.Size(503, 30);
            this.labelControl.TabIndex = 1;
            this.labelControl.Text = "Courier";
            // 
            // courierTableTableAdapter
            // 
            this.courierTableTableAdapter.ClearBeforeFill = true;
            // 
            // courierTableBindingSource
            // 
            this.courierTableBindingSource.DataMember = "CourierTable";
            this.courierTableBindingSource.DataSource = this.ecourierDatabaseDataSet;
            // 
            // AddCourier
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(548, 311);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelCloseButton);
            this.Controls.Add(this.windowsUIButtonPanelMain);
            this.Name = "AddCourier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourierNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecourierDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingHoursDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingHoursDateEditTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCourierName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWorkingHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForisActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWorkingHours1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courierTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private ecourierDatabaseDataSet ecourierDatabaseDataSet;
        private System.Windows.Forms.BindingSource courierTableBindingSource;
        private ecourierDatabaseDataSetTableAdapters.CourierTableTableAdapter courierTableTableAdapter;
        private DevExpress.XtraEditors.TextEdit CourierNameTextEdit;
        private DevExpress.XtraEditors.TextEdit ContactNumberTextEdit;
        private DevExpress.XtraEditors.CheckEdit isActiveCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCourierName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWorkingHours;
        private DevExpress.XtraLayout.LayoutControlItem ItemForisActive;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContactNumber;
        private DevExpress.XtraEditors.TimeEdit WorkingHoursDateEdit;
        private DevExpress.XtraEditors.TimeEdit WorkingHoursDateEditTo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWorkingHours1;
    }

}