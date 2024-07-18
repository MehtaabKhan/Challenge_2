Module Module1

    Sub Main()
        Dim testScores As Integer
        Dim newTestScoreResults As Integer
        Dim totalTests As Integer
        Dim averageOfTotalScores As Decimal

        While totalTests <> 10
            Console.WriteLine("Student Score: ")
            testScores = Console.ReadLine()
            TestScoreValidation(testScores)
            totalTests = totalTests + 1
            averageOfTotalScores = newTestScoreResults + testScores
            newTestScoreResults = testScores
        End While

        averageOfTotalScores = testScores / totalTests
        Console.WriteLine("Average: " & averageOfTotalScores)
    End Sub

    Sub TestScoreValidation(score)
        If score > 10 Then
            Console.WriteLine("Score must be in range of 0-10")
        ElseIf score < 0 Then
            Console.WriteLine("Score must be in range of 0-10")
        End If
    End Sub
End Module
