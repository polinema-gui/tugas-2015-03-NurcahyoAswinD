<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matriks
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
        Me.Lbl_matrik1 = New System.Windows.Forms.Label()
        Me.textMatriks1 = New System.Windows.Forms.TextBox()
        Me.Lbl_operasi = New System.Windows.Forms.Label()
        Me.OperationBoxList = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextMatriks2 = New System.Windows.Forms.TextBox()
        Me.textResult = New System.Windows.Forms.TextBox()
        Me.Lbl_hasil = New System.Windows.Forms.Label()
        Me.btn_proses = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_matrik1
        '
        Me.Lbl_matrik1.AutoSize = True
        Me.Lbl_matrik1.Location = New System.Drawing.Point(13, 23)
        Me.Lbl_matrik1.Name = "Lbl_matrik1"
        Me.Lbl_matrik1.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_matrik1.TabIndex = 0
        Me.Lbl_matrik1.Text = "Matrik1"
        '
        'textMatriks1
        '
        Me.textMatriks1.Location = New System.Drawing.Point(61, 20)
        Me.textMatriks1.Multiline = True
        Me.textMatriks1.Name = "textMatriks1"
        Me.textMatriks1.Size = New System.Drawing.Size(368, 76)
        Me.textMatriks1.TabIndex = 1
        '
        'Lbl_operasi
        '
        Me.Lbl_operasi.AutoSize = True
        Me.Lbl_operasi.Location = New System.Drawing.Point(12, 121)
        Me.Lbl_operasi.Name = "Lbl_operasi"
        Me.Lbl_operasi.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_operasi.TabIndex = 2
        Me.Lbl_operasi.Text = "Operasi"
        '
        'OperationBoxList
        '
        Me.OperationBoxList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OperationBoxList.FormattingEnabled = True
        Me.OperationBoxList.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.OperationBoxList.Location = New System.Drawing.Point(61, 118)
        Me.OperationBoxList.Name = "OperationBoxList"
        Me.OperationBoxList.Size = New System.Drawing.Size(368, 21)
        Me.OperationBoxList.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Matrik 2"
        '
        'TextMatriks2
        '
        Me.TextMatriks2.Location = New System.Drawing.Point(61, 165)
        Me.TextMatriks2.Multiline = True
        Me.TextMatriks2.Name = "TextMatriks2"
        Me.TextMatriks2.Size = New System.Drawing.Size(368, 76)
        Me.TextMatriks2.TabIndex = 5
        '
        'textResult
        '
        Me.textResult.Location = New System.Drawing.Point(61, 260)
        Me.textResult.Multiline = True
        Me.textResult.Name = "textResult"
        Me.textResult.Size = New System.Drawing.Size(368, 76)
        Me.textResult.TabIndex = 6
        '
        'Lbl_hasil
        '
        Me.Lbl_hasil.AutoSize = True
        Me.Lbl_hasil.Location = New System.Drawing.Point(12, 263)
        Me.Lbl_hasil.Name = "Lbl_hasil"
        Me.Lbl_hasil.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_hasil.TabIndex = 7
        Me.Lbl_hasil.Text = "Hasil"
        '
        'btn_proses
        '
        Me.btn_proses.Location = New System.Drawing.Point(307, 351)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(122, 23)
        Me.btn_proses.TabIndex = 8
        Me.btn_proses.Text = "Proses"
        Me.btn_proses.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 343)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Label4"
        '
        'Matriks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_proses)
        Me.Controls.Add(Me.Lbl_hasil)
        Me.Controls.Add(Me.textResult)
        Me.Controls.Add(Me.TextMatriks2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OperationBoxList)
        Me.Controls.Add(Me.Lbl_operasi)
        Me.Controls.Add(Me.textMatriks1)
        Me.Controls.Add(Me.Lbl_matrik1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Matriks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_matrik1 As System.Windows.Forms.Label
    Friend WithEvents textMatriks1 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_operasi As System.Windows.Forms.Label
    Friend WithEvents OperationBoxList As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextMatriks2 As System.Windows.Forms.TextBox
    Friend WithEvents textResult As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_hasil As System.Windows.Forms.Label
    Friend WithEvents btn_proses As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
