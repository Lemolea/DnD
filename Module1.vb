Imports System.Threading
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
        Public ac As Integer
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

    Function Dice(ByRef u_bound As Integer)
        Dim roll As New Random
        roll = New Random
        Return roll.Next(1, u_bound)
    End Function

    Sub Main()
        Dim thePlayer As player
        Dim theWeapon As weapon

        thePlayer.lifeTotal = 25
        thePlayer.gold = 0
        theWeapon.name = "fists"
        theWeapon.damage = 2
        thePlayer.weapon = theWeapon

        Console.WriteLine("You sit in the same corner of the tavern as you always do and peer down into your empty mug. You consider buying a refill and check your pockets for any spare change. Alas, there is none. You just spent the last of your gold on this drink, hoping it would be enough to erase the memories of how you've gambled away every last thing you own, including your own family.As you recount these thoughts, you overhear a conversation on the other side of the tavern of a very wealthy cult that inexplicably live in a nearby cave.You stand up. You need that gold. And you need it now.")

        Console.WriteLine("So, what would you like to be called?")
        thePlayer.name = Console.ReadLine()
        Console.WriteLine("Today you will attack your foes with your " & theWeapon.name)

        'Level_1(thePlayer, theWeapon)
        Level_2(thePlayer, theWeapon)
        Level_3(thePlayer, theWeapon)

    End Sub

    Function Weapons(ByRef theWeapon As weapon, ByRef level As Integer)
        Select Case Dice(level)
            Case 0
                theWeapon.name = "Fists"
                theWeapon.damage = 1
            Case 1
                theWeapon.name = "Sword"
                theWeapon.damage = 5
            Case 2
                theWeapon.name = "Slightly Bigger Sword TM"
                theWeapon.damage = 7
            Case 3
                theWeapon.name = "Bow"
                theWeapon.damage = 8
            Case 4
                theWeapon.name = "Human arm"
                theWeapon.damage = 4
            Case 5
                theWeapon.name = "Wooden plank" 'Level 1 max
                theWeapon.damage = 3
            Case 6
                theWeapon.name = "Gun"
                theWeapon.damage = 12
            Case 7
                theWeapon.name = "Very Big Sword"
                theWeapon.damage = 15
            Case 8
                theWeapon.name = "Holy Sword of Fire"
                theWeapon.damage = 20
            Case 9
                theWeapon.name = "Axe Guitar"
                theWeapon.damage = 10
            Case 10
                theWeapon.name = "'Magic: the Gathering TM' Card Deck" 'Level 2 max
                theWeapon.damage = 13
            Case 11
                theWeapon.name = "The Vendor's Vapourising Ray"
                theWeapon.damage = 21
            Case 12
                theWeapon.name = "Battle Axe"
                theWeapon.damage = 17
            Case 13
                theWeapon.name = "Boomerang"
                theWeapon.damage = 15
            Case 14
                theWeapon.name = "Pepper Spray"
                theWeapon.damage = 18
            Case 15
                theWeapon.name = "Golf Club" 'Level 3 max
                theWeapon.damage = 16
            Case 16
                theWeapon.name = "Multiple Bombs"
                theWeapon.damage = 22
            Case 17
                theWeapon.name = "Hope"
                theWeapon.damage = 28
            Case 18
                theWeapon.name = "Kindness"
                theWeapon.damage = 25
            Case 19
                theWeapon.name = "A rock. A big rock"
                theWeapon.damage = 23
            Case 20
                theWeapon.name = "The power of God himself" 'Level 4 max
                theWeapon.damage = 100
        End Select

        Return theWeapon
    End Function

    Function livingEntity(ByRef living As living_entity, ByRef level As Integer)
        Dim whichliving As Integer = Dice(level)
        Select Case whichliving
            Case 1
                living.name = "Goblin"
                living.lifeTotal = 4
                living.damage = 4
                living.ac = 5
            Case 2
                living.name = "Spider"
                living.lifeTotal = 7
                living.damage = 3
                living.ac = 3
            Case 3
                living.name = "Ghost"
                living.lifeTotal = 3
                living.damage = 2
                living.ac = 6
            Case 4
                living.name = "Cyclops"
                living.lifeTotal = 9
                living.damage = 5
                living.ac = 7
            Case 5
                living.name = "Butterfly" 'level 1 max
                living.lifeTotal = 1
                living.damage = 0
                living.ac = 1
            Case 6
                living.name = "Yeti"
                living.lifeTotal = 14
                living.damage = 5
                living.ac = 4
            Case 7
                living.name = "Cenataur"
                living.lifeTotal = 13
                living.damage = 7
                living.ac = 3
            Case 8
                living.name = "Wolf"
                living.lifeTotal = 14
                living.damage = 9
                living.ac = 5
            Case 9
                living.name = "Giant (Somehow)"
                living.lifeTotal = 18
                living.damage = 8
                living.ac = 8
            Case 10
                living.name = "Human Child" 'level 2 max
                living.lifeTotal = 7
                living.damage = 2
                living.ac = 2
            Case 11
                living.name = "19"
                living.lifeTotal = 19
                living.damage = 11
                living.ac = 10
            Case 12
                living.name = "Raptor"
                living.lifeTotal = 21
                living.damage = 15
                living.ac = 9
            Case 13
                living.name = "Kolbold"
                living.lifeTotal = 25
                living.damage = 13
                living.ac = 3
            Case 14
                living.name = "Chicken"
                living.lifeTotal = 18
                living.damage = 11
                living.ac = 6
            Case 15
                living.name = "Vampire" 'level 3 max
                living.lifeTotal = 30
                living.damage = 17
                living.ac = 7
            Case 16
                living.name = "Tortoise"
                living.lifeTotal = 36
                living.damage = 20
                living.ac = 4
            Case 17
                living.name = "Sorcerer"
                living.lifeTotal = 34
                living.damage = 22
                living.ac = 5
            Case 18
                living.name = "Flying Squirrel"
                living.lifeTotal = 31
                living.damage = 16
                living.ac = 6
            Case 19
                living.name = "The Spanish Inquisition"
                living.lifeTotal = 29
                living.damage = 18
                living.ac = 9
            Case 20
                living.name = "Our lord and Savior, Raptor Jesus." 'level 4 max
                living.lifeTotal = 50
                living.damage = 30
                living.ac = 15
        End Select
        Return living
    End Function

    Function Encounter() As trap
        Dim trap As trap
        Dim whichtrap As Integer
        whichtrap = Dice(7)

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

    Function Combat(ByRef thePlayer As player, ByRef theWeapon As weapon, ByRef living As living_entity)
        Dim hit As Integer = Dice(20)
        Dim attack As Integer
        If hit > living.ac Then
            attack = Dice(theWeapon.damage)
            living.lifeTotal = living.lifeTotal - attack
            Console.WriteLine("You hit for: " & attack & ". The enemy now has: " & living.lifeTotal & " health.")
        Else
            Console.WriteLine("You miss. You sad failure.")
        End If
        attack = Dice(living.damage)
        thePlayer.lifeTotal = thePlayer.lifeTotal - attack
        Console.WriteLine("The Enemy hits for: " & attack & ". You now have: " & thePlayer.lifeTotal & " health.")
        Return living
    End Function

    Function Living_Attack(ByRef thePlayer As player, ByRef theWeapon As weapon, ByRef level As Integer)
        Dim choice As String
        Dim living As living_entity
        living = livingEntity(living, level)
        Console.WriteLine("You see a " & living.name)
        Console.WriteLine("What would you like to do? Your options are..." & vbCrLf & "Attack or Run")
        choice = Console.ReadLine()
        While living.lifeTotal > 0
            If thePlayer.lifeTotal > 0 Then
                If choice.ToLower = "attack" Then
                    Console.Clear()
                    Combat(thePlayer, theWeapon, living)
                    Thread.Sleep(2000)
                ElseIf choice.ToLower = "run" Then
                    Console.Clear()
                    Console.WriteLine("There is no going back. You die")
                    Thread.Sleep(2000)
                    End
                ElseIf choice.ToLower = "no" Then
                    living.lifeTotal = 0
                End If
            Else
                Console.WriteLine("I'm sorry. You seem to have died.")
                Thread.Sleep(3000)
                End
            End If
        End While

        Dim gold As Integer = Dice(10)
        thePlayer.gold = thePlayer.gold + gold
        Console.WriteLine("Congratulations! You recieve " & gold & " gold")
        Return thePlayer
        Thread.Sleep(3000)
        Console.Clear()

    End Function

    Function Encounter_Solve(ByRef thePlayer As player, ByRef theWeapon As weapon)
        Dim trap As trap
        Dim answer As String
        Dim ans As Boolean = False
        trap = Encounter()

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

        Return thePlayer
    End Function

    Sub Level_1(ByRef thePlayer As player, ByRef theWeapon As weapon)
        Dim level As Integer = 5
        Console.Clear()
        Console.WriteLine("You walk into the cave.")
        Call Living_Attack(thePlayer, theWeapon, level)
        Dim Weapon_pending As weapon = Weapons(theWeapon, level)
        Dim Weapon_keep As String
        Dim valid As Boolean = False

        Console.WriteLine("Hark! The enemy dropped a " & Weapon_pending.name & "! Do you take it?")
        Weapon_keep = Console.ReadLine()
        While valid = False
            If Weapon_keep.ToLower = "yes" Then
                Console.Clear()
                Console.WriteLine("You pick up your new, shiny weapon!")
                theWeapon = Weapon_pending
                valid = True
            ElseIf Weapon_keep.ToLower = "no" Then
                Console.Clear()
                Console.WriteLine("Okay. Suit yourself. You march on toward your death.")
                valid = True
            Else
                Console.WriteLine("That wasn't an option. Yes or no, please.")
            End If
        End While

        Console.WriteLine("You enter into your first room armed with your trusty " & theWeapon.name)
        Call Encounter_Solve(thePlayer, theWeapon)

        Dim win As Boolean = False
        Dim loot As String
        Dim choice As String
        Dim gold As Integer = Dice(10)
        Dim living As living_entity
        living.name = "Small Grumpy Dragon"
        living.lifeTotal = 20
        living.damage = 5
        living.ac = 5

        Console.Clear()
        Console.WriteLine("You walk into what appears to be the final room of the dungeon and look around. Your eyes fall upon a very small and very angry looking dragon." & vbCrLf & "What do you do? Attack or Run?")
        choice = Console.ReadLine()
        If choice.ToLower = "attack" Then
            While living.lifeTotal > 0
                If thePlayer.lifeTotal > 0 Then
                    Console.Clear()
                    Combat(thePlayer, theWeapon, living)
                    Thread.Sleep(2000)
                    win = True
                Else
                    Console.WriteLine("I'm sorry. You seem to have died.")
                    Thread.Sleep(3000)
                    End
                End If
            End While
        ElseIf choice.ToLower = "run" Then
            Console.Clear()
            Console.WriteLine("There is no going back, you-")
            Thread.Sleep(4000)
            Console.WriteLine("Wait. You seem to walk straight past the small dragon. He does not care... I guess you proceed then.")
        ElseIf choice.ToLower = "no" Then
            living.lifeTotal = 0
            win = True
        End If

        Weapon_pending = Weapons(theWeapon, level)
        gold = Dice(10)
        If win = True Then
            Console.WriteLine("Aha! You defeat the foul beast! Would you like to loot it?")
            loot = Console.ReadLine()
            If loot.ToLower = "yes" Then
                Console.Clear()
                thePlayer.gold = thePlayer.gold + gold
                Console.WriteLine("You punch your hand right into the small dragon's gut and pull " & gold & " gold out of it. Sweet.")
                Console.WriteLine("When you kick the small creature's corpse out of your path, you find a " & Weapon_pending.name & "! Do you keep it?")
                Weapon_keep = Console.ReadLine()
                If Weapon_keep.ToLower = "yes" Then
                    Console.Clear()
                    Console.WriteLine("You drop your previous weapon, pick up the new one and move on with your life.")
                    theWeapon = Weapon_pending
                ElseIf Weapon_keep.ToLower = "no" Then
                    Console.Clear()
                    Console.WriteLine("Okay. Suit yourself. You ignore the weapon and move on.")
                Else
                    Console.WriteLine("That wasn't an option. Yes or no, please.")
                End If
            ElseIf loot.ToLower = "no" Then
                Console.WriteLine("Okay. Suit yourself. You ignore the corpse and move on.")
            End If
        End If

        Console.ReadLine()

    End Sub
    Sub Level_2(ByRef thePlayer As player, ByRef theWeapon As weapon)
        thePlayer.lifeTotal = 40
        Console.Clear()
        Dim level As Integer = 10
        Console.WriteLine("You proceed down a staircase to the next floor of the cave.")
        Call Living_Attack(thePlayer, theWeapon, level)
        Console.Clear()
        Console.WriteLine("You walk past the body and continue down a dark corridor.")
        Call Encounter_Solve(thePlayer, theWeapon)
        Console.Clear()

        Call Living_Attack(thePlayer, theWeapon, level)
        Console.Clear()
        Console.WriteLine("You walk past the body and continue through a door.")

        Dim win As Boolean = False
        Dim loot As String
        Dim choice As String
        Dim gold As Integer = Dice(10)
        Dim living As living_entity
        living.name = "Alien Vendor"
        living.lifeTotal = 20
        living.damage = 5
        living.ac = 5

        Console.WriteLine("You open a door to find... A shop? The vendor appears to be an alien." & vbCrLf & "What do you do? Talk or Attack?")
        choice = Console.ReadLine()


        If choice.ToLower = "attack" Then
            Console.Clear()
            Combat(thePlayer, theWeapon, living)
            Thread.Sleep(3000)
        ElseIf choice.ToLower = "talk" Then
            Console.Clear()
            Console.WriteLine("You say hello to the alien. He seems friendly and offers you to browse his wares. Or at least you think so. You don't understand his language." & vbCrLf & "In his store are various sundries, such as weapons, potions and more." & vbCrLf & "Do you take any?")
            choice = Console.ReadLine()
            If choice = "yes" Then
                Console.WriteLine("The alien does not appreciate you touching his items. He attacks you. Do you fight back?")
                choice = Console.ReadLine()
                If choice.ToLower = "yes" Then
                    Console.WriteLine("You wield your " & theWeapon.name & " bravely and prepare to fight.")
                    Console.Clear()
                    Combat(thePlayer, theWeapon, living)
                    Thread.Sleep(2000)
                ElseIf choice.tolower = "no" Then
                    Console.Clear()
                    Console.WriteLine("The alien kills you. What else did you expect?")
                    Thread.Sleep(3000)
                    End
                End If
            ElseIf choice = "no" Then
                Console.WriteLine("The alien appreciates this. He gladly allows you to pass. We ran out of time. Class dismissed!")
                Console.ReadLine()
            End If
            End
        Else
            Console.WriteLine("I gave you two choices. Pick one.")
        End If

        Dim Weapon_pending As weapon = Weapons(theWeapon, level)
        Dim Weapon_keep As String
        gold = Dice(10)

        Console.WriteLine("You find some items on your way out. Would you like to take them?")
        loot = Console.ReadLine()
        If loot.ToLower = "yes" Then
            Console.Clear()
            thePlayer.gold = thePlayer.gold + gold
            Console.WriteLine("You rummage through the storage room and find " & gold & " gold. Sweet.")
            Console.WriteLine("You also find a " & Weapon_pending.name & "! Do you keep it?")
            Weapon_keep = Console.ReadLine()
            If Weapon_keep.ToLower = "yes" Then
                Console.Clear()
                Console.WriteLine("You drop your previous weapon, pick up the new one and move on with your life.")
                theWeapon = Weapon_pending
            ElseIf Weapon_keep.ToLower = "no" Then
                Console.Clear()
                Console.WriteLine("Okay. Suit yourself. You ignore the weapon and move on.")
            Else
                Console.WriteLine("That wasn't an option. Yes or no, please.")
            End If
        ElseIf loot.ToLower = "no" Then
            Console.WriteLine("Okay. Suit yourself. You ignore the corpse and move on.")
        End If

        Console.Clear()
        Console.ReadLine()

    End Sub
    Sub Level_3(ByRef thePlayer As player, ByRef theWeapon As weapon)
        Console.Clear()
        Dim level As Integer = 15

    End Sub
    Sub Level_4(ByRef thePlayer As player, ByRef theWeapon As weapon)
        Console.Clear()
        Dim level As Integer = 20

    End Sub

End Module