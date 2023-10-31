VAR madeGoodChoice = false
VAR madeBadChoice = false


-> main

=== main ===
#sound;appear
#anim;idle
you have two choices <b>choices</b> to make.
{madeGoodChoice and madeBadChoice:
    #anim;happy
    I now know everyone I need. 
}
* [The good one] -> goodChoice
* [The bad one] -> badChoice
* {madeGoodChoice and madeBadChoice}[The ultimate choice] -> ultimateChoice


=== goodChoice ===
#sound;backward
#anim;happy
That was a good choice 
~ madeGoodChoice = true

* ["Ok"] -> main

=== badChoice ===
#sound;gulp
#anim;sad
That was a bad choice 
~ madeBadChoice = true

* ["Ok"] -> main

=== ultimateChoice ===
#sound;music_octo
You now know all. Nice 
-> END
