<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloWorld
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
        Me.btnPress = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPress
        '
        Me.btnPress.BackColor = System.Drawing.Color.Crimson
        Me.btnPress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPress.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPress.Location = New System.Drawing.Point(166, 134)
        Me.btnPress.Name = "btnPress"
        Me.btnPress.Size = New System.Drawing.Size(236, 81)
        Me.btnPress.TabIndex = 0
        Me.btnPress.Text = "Press Me!"
        Me.btnPress.UseVisualStyleBackColor = False
        '
        'HelloWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(570, 400)
        Me.Controls.Add(Me.btnPress)
        Me.Name = "HelloWorld"
        Me.Text = "Hello"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPress As Button
End Class
