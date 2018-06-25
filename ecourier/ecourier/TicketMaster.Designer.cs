namespace ecourier
{
    partial class TicketMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketMaster));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPickupIntersectionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliverIntersectionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPickUpDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPickupTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourierId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliverdTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliverStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 116);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1026, 484);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCustomerId,
            this.colPickupIntersectionId,
            this.colDeliverIntersectionId,
            this.colPickUpDate,
            this.colPickupTime,
            this.colDeliveryDate,
            this.colDeliveryTime,
            this.colCourierId,
            this.colDeliverdTime,
            this.colDeliverStatus,
            this.colisDeleted,
            this.colDOC,
            this.colDOM});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPickUpDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 112;
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerName";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Visible = true;
            this.colCustomerId.VisibleIndex = 1;
            this.colCustomerId.Width = 173;
            // 
            // colPickupIntersectionId
            // 
            this.colPickupIntersectionId.Caption = "Pickup Intersection";
            this.colPickupIntersectionId.FieldName = "Pickuptable_Pickup_Intersaction_name";
            this.colPickupIntersectionId.Name = "colPickupIntersectionId";
            this.colPickupIntersectionId.Width = 106;
            // 
            // colDeliverIntersectionId
            // 
            this.colDeliverIntersectionId.Caption = "Delivery Intersection";
            this.colDeliverIntersectionId.FieldName = "Pickuptable_1_Pickup_Intersaction_name";
            this.colDeliverIntersectionId.Name = "colDeliverIntersectionId";
            this.colDeliverIntersectionId.Width = 115;
            // 
            // colPickUpDate
            // 
            this.colPickUpDate.FieldName = "PickUpDate";
            this.colPickUpDate.Name = "colPickUpDate";
            this.colPickUpDate.Visible = true;
            this.colPickUpDate.VisibleIndex = 2;
            this.colPickUpDate.Width = 167;
            // 
            // colPickupTime
            // 
            this.colPickupTime.FieldName = "PickupTime";
            this.colPickupTime.Name = "colPickupTime";
            this.colPickupTime.Visible = true;
            this.colPickupTime.VisibleIndex = 3;
            this.colPickupTime.Width = 133;
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.FieldName = "DeliveryDate";
            this.colDeliveryDate.Name = "colDeliveryDate";
            this.colDeliveryDate.Visible = true;
            this.colDeliveryDate.VisibleIndex = 4;
            this.colDeliveryDate.Width = 152;
            // 
            // colDeliveryTime
            // 
            this.colDeliveryTime.FieldName = "DeliveryTime";
            this.colDeliveryTime.Name = "colDeliveryTime";
            this.colDeliveryTime.Width = 53;
            // 
            // colCourierId
            // 
            this.colCourierId.Caption = "Courier Name";
            this.colCourierId.FieldName = "CourierName";
            this.colCourierId.Name = "colCourierId";
            this.colCourierId.Width = 70;
            // 
            // colDeliverdTime
            // 
            this.colDeliverdTime.FieldName = "DeliverdTime";
            this.colDeliverdTime.Name = "colDeliverdTime";
            this.colDeliverdTime.Width = 70;
            // 
            // colDeliverStatus
            // 
            this.colDeliverStatus.FieldName = "DeliverStatus";
            this.colDeliverStatus.Name = "colDeliverStatus";
            this.colDeliverStatus.Visible = true;
            this.colDeliverStatus.VisibleIndex = 5;
            this.colDeliverStatus.Width = 80;
            // 
            // colisDeleted
            // 
            this.colisDeleted.FieldName = "isDeleted";
            this.colisDeleted.Name = "colisDeleted";
            // 
            // colDOC
            // 
            this.colDOC.FieldName = "DOC";
            this.colDOC.Name = "colDOC";
            // 
            // colDOM
            // 
            this.colDOM.FieldName = "DOM";
            this.colDOM.Name = "colDOM";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.barButtonItem2});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1026, 116);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "Create Ticket";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Schedule Ticket";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Update Ticket";
            this.barButtonItem2.Id = 20;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 573);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1026, 27);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Schedule Ticket";
            this.barButtonItem1.Id = 17;
            this.barButtonItem1.ImageOptions.ImageUri.Uri = "Edit";
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // TicketMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "TicketMaster";
            this.Size = new System.Drawing.Size(1026, 600);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colPickupIntersectionId;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliverIntersectionId;
        private DevExpress.XtraGrid.Columns.GridColumn colPickUpDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPickupTime;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryTime;
        private DevExpress.XtraGrid.Columns.GridColumn colCourierId;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliverdTime;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliverStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colisDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colDOC;
        private DevExpress.XtraGrid.Columns.GridColumn colDOM;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}
