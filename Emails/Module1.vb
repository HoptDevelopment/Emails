Module Module1

    Sub Main()

        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("-------------------------")
        Console.WriteLine("     Spooky Email        ")
        Console.WriteLine("-------------------------")
        Console.WriteLine("1 - New Email")
        Console.WriteLine("2 - New Settings")
        Console.WriteLine("3 - Exit Program")

        Select Case Console.ReadLine()
            Case Is = "1"
                Console.Clear()
                Emailing()
            Case Is = "2"
                Console.ReadLine()
                EmailSettings()
            Case Is = "3"
                End
        End Select

    End Sub

    Sub Emailing()

    End Sub

    Sub EmailSettings()
        Console.WriteLine("-------------------------")
        Console.WriteLine("     Spooky Email Settings        ")
        Console.WriteLine("-------------------------")

        Console.WriteLine("What is your name?")
        My.Settings.Name

    End Sub

End Module
