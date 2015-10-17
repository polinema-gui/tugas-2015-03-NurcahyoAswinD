Public Class Form1

    Private Sub ProblemBintangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProblemBintang.Click
        If Matriks.ShowInTaskbar = True Then
            Matriks.Close()
        End If
        Bintang.MdiParent = Me
        Bintang.Show()
    End Sub

    Private Sub MatriksKalkulator_Click(sender As Object, e As EventArgs) Handles MatriksKalkulator.Click
        If Bintang.ShowInTaskbar = True Then
            Bintang.Close()
        End If
        Matriks.MdiParent = Me
        Matriks.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Keluar dari Aplikasi", "Aplikasi Tugas 03", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
        = DialogResult.Yes Then
            Environment.Exit(0)
        End If

    End Sub

End Class
