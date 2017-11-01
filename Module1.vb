Imports System.Threading

Module Module1

    Structure Player
        Public name As String
        Public lifeTotal As Integer
        Public gold As Integer
        'Public weapon As Weapon
    End Structure

    Structure Weapon
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
        Public background As String
        Public correctOption As String
        Public wrongOption1 As String
        Public wrongOption2 As String
    End Structure

    Function diceRoll(ByRef upperBound As Integer)
        Dim roll As New Random
        roll = New Random
        Return roll.Next(1, upperBound)
    End Function

    Function Weapons(ByRef theWeapon As Weapon)
        Select Case diceRoll(2)
            Case 1
                theWeapon.name = "Fist"
                theWeapon.damage = 1
            Case 2
                theWeapon.name = "Sword"
                theWeapon.damage = 5
            Case 3
                theWeapon.name = "Slightly Bigger Sword TM"
                theWeapon.damage = 10
        End Select

        Return theWeapon
    End Function

    Function livingEntity(ByRef mob As living_entity)
        Select Case diceRoll(2)
            Case 1

            Case 2

        End Select
        Return mob
    End Function

    Function Encounter() As trap
        Dim trap As trap
        Dim whichtrap As Integer

        whichtrap = diceRoll(1)

        Select Case whichtrap
            Case 1
                trap.name = "Bottomless pit"
                trap.background = "You see a bottomless pit open up infront of you. What do you do?"
                trap.correctOption = "1: Walk around it"
                trap.wrongOption1 = "2: You jump over the pit"
                trap.wrongOption2 = "3: You spin 180° and run away"
            Case 2
            Case 3
            Case 4

        End Select

        Return trap
    End Function

    Sub Main()
        Dim thePlayer As Player
        Dim theWeapon As Weapon

        thePlayer.lifeTotal = 20
        thePlayer.gold = diceRoll(10)
        theWeapon.name = "Fist"
        theWeapon.damage = 1

        Console.WriteLine("")

        Console.WriteLine("So, what would you like to be called? ")
        thePlayer.name = Console.ReadLine()
        Console.WriteLine("Today you will attack your foes with your " & theWeapon.name)

        Level_1(thePlayer, theWeapon)

    End Sub

    Sub Level_1(ByRef thePlayer As Player, ByRef theWeapon As Weapon)
        Dim trap As trap
        Dim answer As String
        Dim ans As Boolean = False
        trap = Encounter()

        Console.WriteLine("You walk into a cave")
        Console.WriteLine(trap.background)
        Console.WriteLine(trap.correctOption)
        Console.WriteLine(trap.wrongOption1)
        Console.WriteLine(trap.wrongOption2)


        While ans = False

            answer = Console.ReadLine()

            If answer = "1" Then
                Console.WriteLine("1")
                ans = True
            ElseIf answer = "2" Then
                Console.WriteLine("2")
                ans = True
            ElseIf answer = "3" Then
                Console.WriteLine("3")
                ans = True
            Else
                Console.WriteLine("Please enter a value between 1 and 3")

            End If


        End While



        Thread.Sleep(10000)
    End Sub
    Sub Level_2()
        Dim thePlayer As Player
        thePlayer.lifeTotal = 23

    End Sub
    Sub Level_3()
        Dim thePlayer As Player
        thePlayer.lifeTotal = 26

    End Sub
    Sub Level_4()
        Dim thePlayer As Player
        thePlayer.lifeTotal = 30

    End Sub

End Module