<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
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
        Me.Name = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Name
        '
        Me.Name.FormattingEnabled = True
        Me.Name.Location = New System.Drawing.Point(152, 87)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(121, 28)
        Me.Name.TabIndex = 0
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Name)
        Me.Name = "test"
        Me.Text = "test"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Name As ComboBox
End Class
