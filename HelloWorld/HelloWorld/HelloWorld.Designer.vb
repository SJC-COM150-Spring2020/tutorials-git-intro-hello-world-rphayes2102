<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HelloWorld
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
        Me.btnPress = New System.Windows.Forms.Button()
        Me.lstHello = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnPress
        '
        Me.btnPress.BackColor = System.Drawing.Color.Crimson
        Me.btnPress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPress.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPress.Location = New System.Drawing.Point(150, 90)
        Me.btnPress.Name = "btnPress"
        Me.btnPress.Size = New System.Drawing.Size(226, 81)
        Me.btnPress.TabIndex = 0
        Me.btnPress.Text = "Press Me!"
        Me.btnPress.UseVisualStyleBackColor = False
        '
        'lstHello
        '
        Me.lstHello.BackColor = System.Drawing.Color.Orange
        Me.lstHello.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstHello.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHello.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lstHello.FormattingEnabled = True
        Me.lstHello.ItemHeight = 25
        Me.lstHello.Location = New System.Drawing.Point(172, 189)
        Me.lstHello.Name = "lstHello"
        Me.lstHello.Size = New System.Drawing.Size(175, 127)
        Me.lstHello.TabIndex = 1
        '
        'HelloWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(513, 364)
        Me.Controls.Add(Me.lstHello)
        Me.Controls.Add(Me.btnPress)
        Me.Name = "HelloWorld"
        Me.Text = "Hello"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPress As Button
    Friend WithEvents lstHello As ListBox
End Class
