<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_Stat = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OpenTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CloseTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClosePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Profit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Komment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfitPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Update = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Growth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrowthPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 475)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'Label_Stat
        '
        Me.Label_Stat.AutoSize = True
        Me.Label_Stat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_Stat.Location = New System.Drawing.Point(147, 32)
        Me.Label_Stat.Name = "Label_Stat"
        Me.Label_Stat.Size = New System.Drawing.Size(94, 20)
        Me.Label_Stat.TabIndex = 14
        Me.Label_Stat.Text = "Statisztika"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OpenTime, Me.Type, Me.Size, Me.OpenPrice, Me.CloseTime, Me.ClosePrice, Me.Profit, Me.Komment, Me.ProfitPercent, Me.Update, Me.Growth, Me.GrowthPercent})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 455)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1247, 353)
        Me.DataGridView1.TabIndex = 15
        '
        'OpenTime
        '
        Me.OpenTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OpenTime.HeaderText = "OpenTime"
        Me.OpenTime.Name = "OpenTime"
        Me.OpenTime.Width = 81
        '
        'Type
        '
        Me.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.Width = 56
        '
        'Size
        '
        Me.Size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Size.HeaderText = "Size"
        Me.Size.Name = "Size"
        Me.Size.Width = 52
        '
        'OpenPrice
        '
        Me.OpenPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OpenPrice.HeaderText = "OpenPrice"
        Me.OpenPrice.Name = "OpenPrice"
        Me.OpenPrice.Width = 82
        '
        'CloseTime
        '
        Me.CloseTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CloseTime.HeaderText = "CloseTime"
        Me.CloseTime.Name = "CloseTime"
        Me.CloseTime.Width = 81
        '
        'ClosePrice
        '
        Me.ClosePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ClosePrice.HeaderText = "ClosePrice"
        Me.ClosePrice.Name = "ClosePrice"
        Me.ClosePrice.Width = 82
        '
        'Profit
        '
        Me.Profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Profit.HeaderText = "Profit"
        Me.Profit.Name = "Profit"
        Me.Profit.Width = 56
        '
        'Komment
        '
        Me.Komment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Komment.HeaderText = "Komment"
        Me.Komment.Name = "Komment"
        Me.Komment.Width = 76
        '
        'ProfitPercent
        '
        Me.ProfitPercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProfitPercent.HeaderText = "ProfitPercent"
        Me.ProfitPercent.Name = "ProfitPercent"
        Me.ProfitPercent.Width = 93
        '
        'Update
        '
        Me.Update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Update.HeaderText = "Update"
        Me.Update.Name = "Update"
        Me.Update.Width = 67
        '
        'Growth
        '
        Me.Growth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Growth.HeaderText = "Growth"
        Me.Growth.Name = "Growth"
        Me.Growth.Width = 66
        '
        'GrowthPercent
        '
        Me.GrowthPercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GrowthPercent.HeaderText = "GrowthPercent"
        Me.GrowthPercent.Name = "GrowthPercent"
        Me.GrowthPercent.Width = 103
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(16, 67)
        Me.Chart1.Name = "Chart1"
        Series1.BorderColor = System.Drawing.Color.Chartreuse
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Green
        Series1.Legend = "Legend1"
        Series1.Name = "hozam"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1247, 382)
        Me.Chart1.TabIndex = 16
        Me.Chart1.Text = "Chart1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 820)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label_Stat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_Stat As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OpenTime As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Size As DataGridViewTextBoxColumn
    Friend WithEvents OpenPrice As DataGridViewTextBoxColumn
    Friend WithEvents CloseTime As DataGridViewTextBoxColumn
    Friend WithEvents ClosePrice As DataGridViewTextBoxColumn
    Friend WithEvents Profit As DataGridViewTextBoxColumn
    Friend WithEvents Komment As DataGridViewTextBoxColumn
    Friend WithEvents ProfitPercent As DataGridViewTextBoxColumn
    Friend WithEvents Update As DataGridViewTextBoxColumn
    Friend WithEvents Growth As DataGridViewTextBoxColumn
    Friend WithEvents GrowthPercent As DataGridViewTextBoxColumn
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
