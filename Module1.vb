Module Module1

    Sub Main()
        Dim testScores As Integer
        Dim totalTests As Integer

        While totalTests <> 10
            Console.WriteLine("Student Score: ")
            testScores = Console.ReadLine()
            totalTests = totalTests + 1
            testScores = testScores + testScores
        End While
    End Sub

End Module
