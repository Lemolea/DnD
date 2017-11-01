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
    Function weapons()


    End Function

    Function livingEntity()


    End Function

    Function Trap()


    End Function
    Sub SetUp()
        Dim thePlayer As player
        Dim theWeapon As weapon

        thePlayer.lifeTotal = 20
        thePlayer.gold = 0
        theWeapon.name = "Fist"
        theWeapon.damage = 1

        Console.Write("So, what would you like to be called? ")
        thePlayer.name = Console.ReadLine()
        Console.WriteLine("Today you will attack you foes with your " & theWeapon.name)

        Console.Read()
    End Sub

    Sub Level_1()


    End Sub
    Sub Level_2()


    End Sub
    Sub Level_3()


    End Sub
    Sub Level_4()


    End Sub

End Module