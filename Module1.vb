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

    Structure living_entity
        Public name As String
        Public lifeTotal As Integer
        Public damage As Integer
    End Structure

    Structure trap
        Public name As String
        Public correct_option As String
    End Structure
    Sub Main()
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

    Function Weapons(ByRef theWeapon As weapon)
        Select Case d20
            Case 1
                theWeapon.name = "Sword"
                theWeapon.damage = 5
            Case 2
                theWeapon.name = "Slightly Bigger Sword TM"
                theWeapon.damage = 10
        End Select

        Return theWeapon
    End Function

    Function livingEntity(ByRef mob As living_entity)
        Select Case d20
            Case 1

            Case 2

        End Select
        Return mob
    End Function

    Function encounter(ByRef trap As trap)
        Select Case d20
            Case 1

            Case 2

        End Select
        Return trap
    End Function

    Sub Level_1()


    End Sub
    Sub Level_2()


    End Sub
    Sub Level_3()


    End Sub
    Sub Level_4()


    End Sub

End Module