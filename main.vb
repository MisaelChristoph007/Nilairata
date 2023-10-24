Module NilaiRataan
    Sub Main()
        Dim lagi As Boolean = True

        Do
            Console.Write("Masukkan jumlah angka: ")
            Dim jumlahAngka As Integer = Convert.ToInt32(Console.ReadLine())

            Dim total As Double = 0

            For i As Integer = 1 To jumlahAngka
                Console.Write("Masukkan angka ke-" & i & ": ")
                Dim angka As Double = Convert.ToDouble(Console.ReadLine())
                total += angka
            Next

            Dim rataRata As Double = total / jumlahAngka

            Console.WriteLine("Rata-rata dari " & jumlahAngka & " angka adalah: " & rataRata)

            Console.Write("Apakah Anda ingin menghitung rata-rata lagi? (Y/T): ")
            Dim jawaban As String = Console.ReadLine()

            If Not (jawaban.ToLower() = "y") Then
                lagi = False
            End If
        Loop While lagi
    End Sub
End Module
