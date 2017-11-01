Module Module1

    Structure player
        Public name As String
        Public lifeTotal As Integer
        Public gold As Integer
        Public weapon As weapon
    End Structure

    Structure weapon
        Public name As String
        Public damage As Integer
    End Structure


    Sub Main()

        Dim player1 As player

        Console.Write("So, what would you like to be called?")
        player1.name = Console.ReadLine()


        Console.Read()
    End Sub




    Function weapons()


    End Function

    Function encounters()


    End Function

End Module
