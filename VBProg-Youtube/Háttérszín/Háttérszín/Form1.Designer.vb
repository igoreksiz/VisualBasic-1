<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.R = New System.Windows.Forms.TrackBar()
        Me.G = New System.Windows.Forms.TrackBar()
        Me.B = New System.Windows.Forms.TrackBar()
        CType(Me.R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.G, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'R
        '
        Me.R.Location = New System.Drawing.Point(12, 12)
        Me.R.Maximum = 255
        Me.R.Name = "R"
        Me.R.Size = New System.Drawing.Size(776, 45)
        Me.R.TabIndex = 0
        Me.R.Value = 128
        '
        'G
        '
        Me.G.Location = New System.Drawing.Point(12, 63)
        Me.G.Maximum = 255
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(776, 45)
        Me.G.TabIndex = 1
        Me.G.Value = 127
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(12, 114)
        Me.B.Maximum = 255
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(776, 45)
        Me.B.TabIndex = 2
        Me.B.Value = 126
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 169)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.G)
        Me.Controls.Add(Me.R)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.G, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents R As TrackBar
    Friend WithEvents G As TrackBar
    Friend WithEvents B As TrackBar
End Class
