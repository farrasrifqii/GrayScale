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
        Me.asli = New System.Windows.Forms.PictureBox()
        Me.gray = New System.Windows.Forms.PictureBox()
        Me.biner = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.asli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gray, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.biner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'asli
        '
        Me.asli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.asli.Location = New System.Drawing.Point(27, 25)
        Me.asli.Name = "asli"
        Me.asli.Size = New System.Drawing.Size(187, 160)
        Me.asli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.asli.TabIndex = 0
        Me.asli.TabStop = False
        '
        'gray
        '
        Me.gray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gray.Location = New System.Drawing.Point(247, 25)
        Me.gray.Name = "gray"
        Me.gray.Size = New System.Drawing.Size(187, 160)
        Me.gray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gray.TabIndex = 1
        Me.gray.TabStop = False
        '
        'biner
        '
        Me.biner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.biner.Location = New System.Drawing.Point(469, 25)
        Me.biner.Name = "biner"
        Me.biner.Size = New System.Drawing.Size(187, 160)
        Me.biner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.biner.TabIndex = 2
        Me.biner.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(57, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Browse Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(273, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 35)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Save Image"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(273, 191)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 35)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Convert to Gray"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(497, 232)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 35)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Save Image"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(497, 191)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(122, 35)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Convert to Biner"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(218, 301)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(249, 57)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "CLEAR"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 400)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.biner)
        Me.Controls.Add(Me.gray)
        Me.Controls.Add(Me.asli)
        Me.Name = "Form1"
        Me.Text = "GrayScale"
        CType(Me.asli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gray, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.biner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents asli As System.Windows.Forms.PictureBox
    Friend WithEvents gray As System.Windows.Forms.PictureBox
    Friend WithEvents biner As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button

End Class
