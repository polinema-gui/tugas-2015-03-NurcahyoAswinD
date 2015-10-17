Public Class Bintang
    Dim result As String = ""

    Private Sub loadBtn_Click(sender As Object, e As EventArgs) Handles loadBtn.Click
        generatePyramid()
    End Sub

    Private Sub generatePyramid()
        Try
            Select Case styleChooser.Text
                Case "Pyramid"
                    pyramid(Convert.ToInt32(inputTextBox.Text))
                Case "Hollow Pyramid"
                    hollowPyramid(Convert.ToInt32(inputTextBox.Text))
                Case "Inverted Pyramid"
                    invertedPyramid(Convert.ToInt32(inputTextBox.Text))
                Case "Hollow Inverted Pyramid"
                    hollowInvertedPyramid(Convert.ToInt32(inputTextBox.Text))
                Case Else
                    MsgBox("Belum Memilih Bentuk")
            End Select
        Catch ex As Exception
            MsgBox("Silakan masukkan angka")
        End Try

    End Sub
    Private Sub pyramid(limit As Integer)
        Dim limitMin As Integer = limit
        Dim limitMax As Integer = limit
        For baris As Integer = 0 To limit
            For kolom As Integer = 0 To limit * 2
                If (kolom < limitMin Or kolom > limitMax) Then
                    Me.result &= " "
                Else
                    Me.result &= "*"
                End If
            Next
            limitMin -= 1
            limitMax += 1
            Me.result &= vbCrLf
        Next
        ResultBox.Text = result
        result = ""
    End Sub

    Private Sub hollowPyramid(limit As Integer)
        Dim limitMin As Integer = limit
        Dim limitMax As Integer = limit
        For baris As Integer = 0 To limit
            For kolom As Integer = 0 To limit * 2
                If (baris < limit) Then
                    If (kolom = limitMin Or kolom = limitMax) Then
                        Me.result &= "*"
                    Else
                        Me.result &= " "
                    End If
                Else
                    Me.result &= "*"
                End If
            Next
            limitMin -= 1
            limitMax += 1
            Me.result &= vbCrLf
        Next
        ResultBox.Text = result
        result = ""
    End Sub

    Private Sub invertedPyramid(limit As Integer)
        Dim limitMin As Integer = 0
        Dim limitMax As Integer = limit * 2
        For baris As Integer = limit * 2 To 0 Step -1
            For kolom As Integer = limit * 2 To 0 Step -1
                If (kolom < limitMin Or kolom > limitMax) Then
                    Me.result &= " "
                Else
                    Me.result &= "*"
                End If
            Next
            Me.result &= vbCrLf
            limitMin += 1
            limitMax -= 1
        Next
        ResultBox.Text = result
        Me.result = ""
    End Sub

    Private Sub hollowInvertedPyramid(limit As Integer)
        Dim limitMin As Integer = 0
        Dim limitMax As Integer = limit * 2
        For baris As Integer = 0 To limit
            For kolom As Integer = 0 To limit * 2
                If (baris = 0) Then
                    Me.result &= "*"
                Else
                    If (kolom = limitMin Or kolom = limitMax) Then
                        Me.result &= "*"
                    Else
                        Me.result &= " "
                    End If
                End If
            Next
            limitMin += 1
            limitMax -= 1
            Me.result &= vbCrLf
        Next
        ResultBox.Text = result
        Me.result = ""
    End Sub

End Class