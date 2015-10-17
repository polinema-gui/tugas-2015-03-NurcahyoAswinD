Public Class Matriks
    Dim cekForm As Boolean = True


    Private Sub btn_proses_Click(sender As Object, e As EventArgs) Handles btn_proses.Click
        generateMatrix()
    End Sub

    Private Sub generateMatrix()
        Try
            Dim barisMatriks1 As Integer = textMatriks1.Lines.Count
            Dim kolomMatriks1 As Integer = textMatriks1.Lines.ElementAt(0).Split(" ").Length
            Dim barisMatriks2 As Integer = textMatriks1.Lines.Count
            Dim kolomMatriks2 As Integer = textMatriks1.Lines.ElementAt(0).Split(" ").Length
            Dim arrayMatrix1(barisMatriks1, kolomMatriks1) As Integer
            Dim arrayMatrix2(barisMatriks2, kolomMatriks2) As Integer

            inputToArray(barisMatriks1, barisMatriks2, kolomMatriks1, kolomMatriks2, arrayMatrix1, arrayMatrix2)
            operationSet(arrayMatrix1, arrayMatrix2, barisMatriks1, kolomMatriks2)

            Label3.Text = barisMatriks1
            Label4.Text = kolomMatriks1
        Catch ex As Exception
            MsgBox("Masukan Bukan Angka atau matrix tidak sama panjangnya")
        End Try
    End Sub

    Private Sub inputToArray(ByVal baris1 As Integer, baris2 As Integer, kolom1 As Integer, kolom2 As Integer, ByRef nilai1(,) As Integer, ByRef nilai2(,) As Integer)
        If (Me.cekForm) Then
            For baris As Integer = 0 To baris1 - 1
                For kolom As Integer = 0 To kolom1 - 1
                    nilai1(baris, kolom) = textMatriks1.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                    nilai2(baris, kolom) = TextMatriks2.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                Next
            Next
        End If
    End Sub



    Private Sub operationSet(ByVal matriks1(,) As Integer, matriks2(,) As Integer, batasBaris As Integer, batasKolom As Integer)
        Dim hasil As String = ""
        If (Me.cekForm) Then
            Select Case OperationBoxList.Text
                Case "Tambah"
                    For baris As Integer = 0 To batasBaris - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            hasil &= (matriks1(baris, kolom) + matriks2(baris, kolom)).ToString & " "
                        Next
                        hasil &= vbNewLine
                    Next

                Case "Kurang"
                    For baris As Integer = 0 To batasBaris - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            hasil &= (matriks1(baris, kolom) - matriks2(baris, kolom)).ToString & " "
                        Next
                        hasil &= vbNewLine
                    Next
                Case Else
                    MsgBox("Anda Belum Memilih operationSet")
            End Select
            textResult.Text = hasil
        End If
    End Sub


End Class