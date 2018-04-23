Namespace WindowsFormsApplication1
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
            Dim customSqlQuery1 As New DevExpress.DataAccess.Sql.CustomSqlQuery()
            Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As New DevExpress.DataAccess.Sql.Table()
            Dim column2 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim masterDetailInfo1 As New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim relationColumnInfo2 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim relationColumnInfo3 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrderID1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            DirectCast(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridView2
            ' 
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderID1, Me.colQuantity, Me.colUnitPrice, Me.colDiscount, Me.colTotal})
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsView.AllowHtmlDrawHeaders = True
            ' 
            ' colOrderID1
            ' 
            Me.colOrderID1.FieldName = "OrderID"
            Me.colOrderID1.Name = "colOrderID1"
            Me.colOrderID1.Visible = True
            Me.colOrderID1.VisibleIndex = 0
            ' 
            ' colQuantity
            ' 
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 1
            ' 
            ' colUnitPrice
            ' 
            Me.colUnitPrice.Caption = "Some Price"
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 2
            ' 
            ' colDiscount
            ' 
            Me.colDiscount.FieldName = "Discount"
            Me.colDiscount.Name = "colDiscount"
            Me.colDiscount.Visible = True
            Me.colDiscount.VisibleIndex = 3
            ' 
            ' colTotal
            ' 
            Me.colTotal.Caption = "<b>Total"
            Me.colTotal.FieldName = "colTotal"
            Me.colTotal.Name = "colTotal"
            Me.colTotal.UnboundExpression = "[UnitPrice] * (1 - [Discount]) * [Quantity]"
            Me.colTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            Me.colTotal.Visible = True
            Me.colTotal.VisibleIndex = 4
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataMember = "Query"
            Me.gridControl1.DataSource = Me.sqlDataSource1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            gridLevelNode1.RelationName = "OrdersOrder Details"
            Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
            Me.gridControl1.Location = New System.Drawing.Point(0, 80)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.MenuManager = Me.barManager1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(892, 385)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind.mdb"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            customSqlQuery1.Name = "Query"
            customSqlQuery1.Sql = "select *" & ControlChars.CrLf & "  from [Order Details] [Order Details]"
            columnExpression1.ColumnName = "CategoryID"
            table1.Name = "Categories"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "CategoryName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Description"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Picture"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Name = "Categories"
            selectQuery1.Tables.Add(table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { customSqlQuery1, selectQuery1})
            masterDetailInfo1.DetailQueryName = "Categories"
            relationColumnInfo1.NestedKeyColumn = "Description"
            relationColumnInfo1.ParentKeyColumn = "UnitPrice"
            relationColumnInfo2.NestedKeyColumn = "CategoryName"
            relationColumnInfo2.ParentKeyColumn = "ProductID"
            relationColumnInfo3.NestedKeyColumn = "Description"
            relationColumnInfo3.ParentKeyColumn = "ProductID"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1)
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo2)
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo3)
            masterDetailInfo1.MasterQueryName = "Query"
            Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() { masterDetailInfo1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderID, Me.colProductID, Me.colUnitPrice1, Me.colQuantity1, Me.colDiscount1, Me.gridColumn1})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "UnitPrice", Me.gridColumn1, "[].Count()")})
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.True
            Me.gridView1.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.AutoComplete
            Me.gridView1.OptionsView.AllowHtmlDrawHeaders = True
            ' 
            ' colOrderID
            ' 
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.Visible = True
            Me.colOrderID.VisibleIndex = 0
            ' 
            ' colProductID
            ' 
            Me.colProductID.FieldName = "ProductID"
            Me.colProductID.Name = "colProductID"
            Me.colProductID.Visible = True
            Me.colProductID.VisibleIndex = 1
            ' 
            ' colUnitPrice1
            ' 
            Me.colUnitPrice1.FieldName = "UnitPrice"
            Me.colUnitPrice1.Name = "colUnitPrice1"
            Me.colUnitPrice1.Visible = True
            Me.colUnitPrice1.VisibleIndex = 2
            ' 
            ' colQuantity1
            ' 
            Me.colQuantity1.FieldName = "Quantity"
            Me.colQuantity1.Name = "colQuantity1"
            Me.colQuantity1.Visible = True
            Me.colQuantity1.VisibleIndex = 3
            ' 
            ' colDiscount1
            ' 
            Me.colDiscount1.FieldName = "Discount"
            Me.colDiscount1.Name = "colDiscount1"
            Me.colDiscount1.Visible = True
            Me.colDiscount1.VisibleIndex = 4
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.Caption = "gridColumn1"
            Me.gridColumn1.FieldName = "gridColumn1"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.ShowUnboundExpressionMenu = True
            Me.gridColumn1.UnboundExpression = "[OrderID] * Rnd()"
            Me.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 5
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3})
            Me.barManager1.Controller = Me.barAndDockingController1
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.MainMenu = Me.bar2
            Me.barManager1.MaxItemId = 0
            Me.barManager1.StatusBar = Me.bar3
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 1
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.Text = "Tools"
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            ' 
            ' bar3
            ' 
            Me.bar3.BarName = "Status bar"
            Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar3.DockCol = 0
            Me.bar3.DockRow = 0
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar3.OptionsBar.AllowQuickCustomization = False
            Me.bar3.OptionsBar.DrawDragBorder = False
            Me.bar3.OptionsBar.UseWholeRow = True
            Me.bar3.Text = "Status bar"
            ' 
            ' barAndDockingController1
            ' 
            Me.barAndDockingController1.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
            Me.barAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = False
            Me.barAndDockingController1.PropertiesBar.AllowLinkLighting = False
            Me.barAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
            Me.barAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.barDockControlTop.Size = New System.Drawing.Size(892, 46)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 465)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.barDockControlBottom.Size = New System.Drawing.Size(892, 22)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 46)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 419)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(892, 46)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 419)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 46)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(892, 34)
            Me.panelControl1.TabIndex = 1
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(892, 487)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
            Me.LookAndFeel.UseDefaultLookAndFeel = False
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colOrderID1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private colDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Private colTotal As DevExpress.XtraGrid.Columns.GridColumn
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Private bar2 As DevExpress.XtraBars.Bar
        Private bar3 As DevExpress.XtraBars.Bar
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private barAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
        Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitPrice1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colDiscount1 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace

