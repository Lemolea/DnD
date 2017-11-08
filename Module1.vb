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
        Public background As String
        Public Option_1 As String
        Public Option_2 As String
        Public Option_3 As String
        Public answer1 As String
        Public answer2 As String
        Public answer3 As String
        Public correctAnswer_1 As String
        Public wrongAnswer_2 As String
        Public wrongAnswer_3 As String

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

        whichtrap = diceRoll(7)

        Select Case whichtrap
            Case 1
                'Bottomless pit
                trap.background = "You see a bottomless pit open up infront of you. What do you do?"
                trap.Option_1 = "1: Walk around it"
                trap.Option_2 = "2: You jump over the pit"
                trap.Option_3 = "3: You spin 180° and run away"
                trap.answer1 = "Sensible. You walk around and carry on with your adventure."
                trap.answer2 = "The ground is damp, you jump hard but slip and fall to your death."
                trap.answer3 = "Oh no! There was another pit behind you and you fall right into it, the impact shatters every bone in your body."
                trap.correctAnswer_1 = 1
                trap.wrongAnswer_2 = 2
                trap.wrongAnswer_3 = 3
            Case 2
                'Swinging Blade
                trap.background = "You notice slits in the walls either side of you. What do you do?"
                trap.Option_1 = "1: Get down on your belly and crawl through the room"
                trap.Option_2 = "2: Peer into the slits to find out what's inside"
                trap.Option_3 = "3: Hit the play button on your music and cut some shapes throught the room"
                trap.answer3 = "You get half way into the room before a massive blade swings from the wall and cuts you clean in half." & vbCrLf & "You manage to catch a glimpse of your intestines laying on the floor behind you before your vision fades to black"
                trap.answer2 = "Well that was stupid, your head is now not on your body."
                trap.answer1 = "Massive blades swing out from the slits in the walls they are heading straight towards you, " & vbCrLf & "but the Gods look kindly on your joyful soul so the blades all miss."
                trap.correctAnswer_1 = 3
                trap.wrongAnswer_2 = 1
                trap.wrongAnswer_3 = 2

            Case 3
                'Falling balders 
                trap.background = "'CLICK!' Looking down you see that you stepped on a pressure plate. What do you do?"
                trap.Option_1 = "1: Step back cautiously."
                trap.Option_2 = "2: Lie down and go for a little sleep, your really tired."
                trap.Option_3 = "3: Charge onward, nothing can stop you!"
                trap.answer2 = "The pressure plate clicks a second time, five balders fall from the celling onto you. Your neck snaps like a twig."
                trap.answer1 = "'CLUNK' You wake in a slumber. Your laziness as been rewarded, the trap deactivated on its own!"
                trap.answer3 = "The pressure plate clicks a second time, five balders fall from the celling behind you. You go full Indiana Jones sprinting down a hallway but this isn't a film so the balders catch up with you and crush you like a snail underfoot."
                trap.correctAnswer_1 = 2
                trap.wrongAnswer_2 = 1
                trap.wrongAnswer_3 = 3
            Case 4
                'Sunlight beams
                trap.background = "Bright sunlight cuts through the gloomy space, it is coming out of holes in the walls in beams. What do you do?"
                trap.Option_1 = "1: Go into the light, it feels so right."
                trap.Option_2 = "2: Close your eyes. Breath deep and slow. Walk with a purpose through the room."
                trap.Option_3 = "3: Atempt to roll, dive, flip and jump through they beams like a ninja."
                trap.answer2 = "It's sunlight you idiot, you go blind. In your frantic blind atempt to escape you run into a spike and impail yourself."
                trap.answer1 = "Hey would you look at that! It actually worked."
                trap.answer3 = "Your not a ninja, you roll into a beam and poison darts shoot out from the walls. Pain spreads across your whole body, you lay there in searing pain for ages before you finally die."
                trap.correctAnswer_1 = 2
                trap.wrongAnswer_2 = 1
                trap.wrongAnswer_3 = 3
            Case 5
                'Beartraps
                trap.background = "The floor is a mixture of rocks, rusty bear traps and man-sized cracks that go deep into the floor. What do you do?"
                trap.Option_1 = "1: Pick up a rock and through it at a beartrap to clear a path."
                trap.Option_2 = "2: Jump across the rocks all the way to the other side."
                trap.Option_3 = "3: Too many decisions, jump down a hole."
                trap.answer1 = "You clear a path through the rubble and walk through. Well done."
                trap.answer2 = "The rocks aren't stable so you fall and your head it crushed in an instant"
                trap.answer3 = "You fall for ages."
                trap.correctAnswer_1 = 1
                trap.wrongAnswer_2 = 2
                trap.wrongAnswer_3 = 3
            Case 6
                'The Holy Step
                trap.background = "There is a step infront of you. What do you do?"
                trap.Option_1 = "1: You just step over the step."
                trap.Option_2 = "2: You just onto the step"
                trap.Option_3 = "3: Kneel to the rightful king of steps"
                trap.answer2 = "You have a heart attack. Unlucky."
                trap.answer3 = "Tiny knives come out of the step and stab you in the feet, you fall. More knives appear and stab you continously, you die from blood loss."
                trap.answer1 = "The step cracks in two, a crown lies inside. You live to fight another day."
                trap.correctAnswer_1 = 3
                trap.wrongAnswer_2 = 1
                trap.wrongAnswer_3 = 2

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

        Level_1(thePlayer, theWeapon)

    End Sub

    Sub Level_1(ByRef thePlayer As Player, ByRef theWeapon As Weapon)
        Dim trap As trap
        Dim answer As String
        Dim ans As Boolean = False
        trap = Encounter()

        Console.WriteLine("You enter into your first room armed with your trusty " & theWeapon.name)
        Console.WriteLine(trap.background)
        Console.WriteLine(trap.Option_1)
        Console.WriteLine(trap.Option_2)
        Console.WriteLine(trap.Option_3)

        While ans = False
            answer = Console.ReadLine()
            If answer = trap.correctAnswer_1 Then
                Console.WriteLine(trap.answer1)
                ans = True
            ElseIf answer = trap.wrongAnswer_2 Then
                Console.WriteLine(trap.answer2)
                Console.WriteLine("You die, better luck next time.")
                Thread.Sleep(6000)
                End
            ElseIf answer = trap.wrongAnswer_3 Then
                Console.WriteLine(trap.answer3)
                Console.WriteLine("You die, better luck next time.")
                Thread.Sleep(6000)
                End
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