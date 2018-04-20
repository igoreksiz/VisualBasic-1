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
        Me.Piros = New System.Windows.Forms.Button()
        Me.Zöld = New System.Windows.Forms.Button()
        Me.Kék = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Piros
        '
        Me.Piros.Location = New System.Drawing.Point(12, 12)
        Me.Piros.Name = "Piros"
        Me.Piros.Size = New System.Drawing.Size(75, 23)
        Me.Piros.TabIndex = 0
        Me.Piros.Text = "&Piros"
        Me.Piros.UseVisualStyleBackColor = True
        '
        'Zöld
        '
        Me.Zöld.Location = New System.Drawing.Point(93, 12)
        Me.Zöld.Name = "Zöld"
        Me.Zöld.Size = New System.Drawing.Size(75, 23)
        Me.Zöld.TabIndex = 1
        Me.Zöld.Text = "Z&öld"
        Me.Zöld.UseVisualStyleBackColor = True
        '
        'Kék
        '
        Me.Kék.Location = New System.Drawing.Point(174, 12)
        Me.Kék.Name = "Kék"
        Me.Kék.Size = New System.Drawing.Size(75, 23)
        Me.Kék.TabIndex = 2
        Me.Kék.Text = "&Kék"
        Me.Kék.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 51)
        Me.Controls.Add(Me.Kék)
        Me.Controls.Add(Me.Zöld)
        Me.Controls.Add(Me.Piros)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Piros As Button
    Friend WithEvents Zöld As Button
    Friend WithEvents Kék As Button
End Class
