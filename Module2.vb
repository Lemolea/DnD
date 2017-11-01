Module Module1

    Structure Player
        Public name As String
        Public lifeTotal As Integer
        Public gold As Integer
        Public weapon As weapon
    End Structure

    Structure Weapon
        Public name As String
        Public damage As Integer
    End Structure

    Function D20Roll()
        Dim roll As New Random
        roll = New Random
        Return roll.Next(1, 20)
    End Function

    Sub Main()
        Dim thePlayer As Player
        Dim theWeapon As Weapon

        thePlayer.lifeTotal = 0
        thePlayer.gold = 0
        theWeapon.name = "Fist"
        theWeapon.damage = 1

        Console.Write("So, what would you like to be called? ")
        thePlayer.name = Console.ReadLine()
        Console.WriteLine("Today you will attack you foes with your " & theWeapon.name)

        Level_1()
        Level_2()
        Level_3()
        Level_4()


        Console.Read()
    End Sub

    Sub Level_1()
        Dim thePlayer As player
        thePlayer.lifeTotal = 25

        Console.WriteLine(D20Roll)

    End Sub
    Sub Level_2()
        Dim thePlayer As player
        thePlayer.lifeTotal = 30

    End Sub
    Sub Level_3()
        Dim thePlayer As player
        thePlayer.lifeTotal = 35

    End Sub
    Sub Level_4()
        Dim thePlayer As player
        thePlayer.lifeTotal = 40

    End Sub

End Module