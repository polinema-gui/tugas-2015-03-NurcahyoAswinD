<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bintang
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
        Me.Lbl_pola = New System.Windows.Forms.Label()
        Me.Lbl_baris = New System.Windows.Forms.Label()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.loadBtn = New System.Windows.Forms.Button()
        Me.ResultBox = New System.Windows.Forms.TextBox()
        Me.styleChooser = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Lbl_pola
        '
        Me.Lbl_pola.AutoSize = True
        Me.Lbl_pola.Location = New System.Drawing.Point(13, 19)
        Me.Lbl_pola.Name = "Lbl_pola"
        Me.Lbl_pola.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_pola.TabIndex = 1
        Me.Lbl_pola.Text = "Pola :"
        '
        'Lbl_baris
        '
        Me.Lbl_baris.AutoSize = True
        Me.Lbl_baris.Location = New System.Drawing.Point(1, 65)
        Me.Lbl_baris.Name = "Lbl_baris"
        Me.Lbl_baris.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_baris.TabIndex = 2
        Me.Lbl_baris.Text = "Jumlah :"
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(53, 62)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(266, 20)
        Me.inputTextBox.TabIndex = 3
        '
        'loadBtn
        '
        Me.loadBtn.Location = New System.Drawing.Point(325, 60)
        Me.loadBtn.Name = "loadBtn"
        Me.loadBtn.Size = New System.Drawing.Size(114, 23)
        Me.loadBtn.TabIndex = 4
        Me.loadBtn.Text = "Load"
        Me.loadBtn.UseVisualStyleBackColor = True
        '
        'ResultBox
        '
        Me.ResultBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultBox.Location = New System.Drawing.Point(16, 108)
        Me.ResultBox.Multiline = True
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.Size = New System.Drawing.Size(423, 305)
        Me.ResultBox.TabIndex = 5
        '
        'styleChooser
        '
        Me.styleChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.styleChooser.FormattingEnabled = True
        Me.styleChooser.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.styleChooser.Location = New System.Drawing.Point(53, 11)
        Me.styleChooser.Name = "styleChooser"
        Me.styleChooser.Size = New System.Drawing.Size(386, 21)
        Me.styleChooser.TabIndex = 2
        '
        'Bintang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.styleChooser)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.loadBtn)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.Lbl_baris)
        Me.Controls.Add(Me.Lbl_pola)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Bintang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_pola As System.Windows.Forms.Label
    Friend WithEvents Lbl_baris As System.Windows.Forms.Label
    Friend WithEvents inputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents loadBtn As System.Windows.Forms.Button
    Friend WithEvents ResultBox As System.Windows.Forms.TextBox
    Friend WithEvents styleChooser As System.Windows.Forms.ComboBox
End Class
