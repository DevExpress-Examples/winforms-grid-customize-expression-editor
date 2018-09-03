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
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.GridColumnProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumnSupplierID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumnUnitsOnOrder = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumnDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumnExpression = New DevExpress.XtraGrid.Columns.GridColumn()
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
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 80)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.MenuManager = Me.barManager1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(892, 385)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnProductName, Me.gridColumnSupplierID, Me.gridColumnUnitsOnOrder, Me.gridColumnDiscontinued, Me.gridColumnExpression})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.AutoComplete
            Me.gridView1.OptionsView.AllowHtmlDrawHeaders = True
            '
            'GridColumnProductName
            '
            Me.GridColumnProductName.Caption = "Product Name"
            Me.GridColumnProductName.FieldName = "ProductName"
            Me.GridColumnProductName.Name = "GridColumnProductName"
            Me.GridColumnProductName.Visible = True
            Me.GridColumnProductName.VisibleIndex = 0
            '
            'gridColumnSupplierID
            '
            Me.gridColumnSupplierID.Caption = "Supplier ID"
            Me.gridColumnSupplierID.FieldName = "SupplierID"
            Me.gridColumnSupplierID.Name = "gridColumnSupplierID"
            Me.gridColumnSupplierID.Visible = True
            Me.gridColumnSupplierID.VisibleIndex = 1
            '
            'gridColumnUnitsOnOrder
            '
            Me.gridColumnUnitsOnOrder.Caption = "Units On Order"
            Me.gridColumnUnitsOnOrder.FieldName = "UnitsOnOrder"
            Me.gridColumnUnitsOnOrder.Name = "gridColumnUnitsOnOrder"
            Me.gridColumnUnitsOnOrder.Visible = True
            Me.gridColumnUnitsOnOrder.VisibleIndex = 2
            '
            'gridColumnDiscontinued
            '
            Me.gridColumnDiscontinued.Caption = "Discontinued"
            Me.gridColumnDiscontinued.FieldName = "Discontinued"
            Me.gridColumnDiscontinued.Name = "gridColumnDiscontinued"
            Me.gridColumnDiscontinued.Visible = True
            Me.gridColumnDiscontinued.VisibleIndex = 3
            '
            'gridColumnExpression
            '
            Me.gridColumnExpression.Caption = "Expression"
            Me.gridColumnExpression.FieldName = "gridColumnExpression"
            Me.gridColumnExpression.Name = "gridColumnExpression"
            Me.gridColumnExpression.ShowUnboundExpressionMenu = True
            Me.gridColumnExpression.UnboundExpression = "[Category.CategoryName]"
            Me.gridColumnExpression.UnboundType = DevExpress.Data.UnboundColumnType.[String]
            Me.gridColumnExpression.Visible = True
            Me.gridColumnExpression.VisibleIndex = 4
            '
            'barManager1
            '
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.bar3})
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
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 1
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.Text = "Tools"
            '
            'bar2
            '
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            '
            'bar3
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
            'barAndDockingController1
            '
            Me.barAndDockingController1.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
            Me.barAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = False
            Me.barAndDockingController1.PropertiesBar.AllowLinkLighting = False
            Me.barAndDockingController1.PropertiesDocking.ViewStyle = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Classic
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.barDockControlTop.Size = New System.Drawing.Size(892, 46)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 465)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.barDockControlBottom.Size = New System.Drawing.Size(892, 22)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 46)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 419)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(892, 46)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 419)
            '
            'panelControl1
            '
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 46)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(892, 34)
            Me.panelControl1.TabIndex = 1
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
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
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Private bar2 As DevExpress.XtraBars.Bar
        Private bar3 As DevExpress.XtraBars.Bar
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private barAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
        Friend WithEvents GridColumnProductName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents gridColumnSupplierID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents gridColumnUnitsOnOrder As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents gridColumnDiscontinued As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents gridColumnExpression As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace

