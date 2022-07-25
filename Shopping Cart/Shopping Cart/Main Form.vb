Public Class frmMain
    Private DVD_FILE As String = "DVs.txt"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''''Variables
        Dim inFile As IO.StreamReader
        Dim DVDNames(9) As String
        Dim DVDPrices(9) As Double
        ''Tests that file exists, then moves contents to arrays and then to list boxes
        If IO.File.Exists(DVD_FILE) Then
            inFile = IO.File.OpenText(DVD_FILE)
            Do Until inFile.Peek = -1
                For i As Integer = 0 To 9
                    DVDNames(i) = inFile.ReadLine
                    DVDPrices(i) = inFile.ReadLine
                Next i
            Loop
            For i As Integer = 0 To DVDPrices.Length - 1
                lstDVDs.Items.Add(DVDNames(i).PadRight(20) & DVDPrices(i).ToString("C2").PadLeft(8))
            Next i
        Else 'If file does not exist, show error screen and exit
            MessageBox.Show("Could not open " & DVD_FILE & "! Ending application.", "Shopping Cart", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Close()
        End If
    End Sub


End Class
