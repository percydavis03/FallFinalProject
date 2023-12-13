#them
Goodness Syviis, slept in a bit again?
#action
    <b> [press Space to continue] </b>
* [(W)I like my sleep...] -> sleepChoice
* [(S)A weird dream...] -> dreamChoice

===sleepChoice===
#you
#anim;Astarion
<i>*scoffs*</i> Hey! I like my sleep Miss up-at-the-crack-of-dawn.
*[Continue] -> ifChose1

===dreamChoice===
#you
#anim;Worried
Yeah.. I had another weird dream.
*[Continue] -> ifChose2

===ifChose1===
#them
#anim;Angry
Well at least I water aNd fertilize the plants! You always just sleep while I do the dirty work hmph!
*[Continue] -> Chose1

===ifChose2===
#them
#anim;Surprised
Oh... another one? That's weird do you think about seeing the Village Seer?
*[Continue] -> Chose2


===Chose1===
#you
#anim;Smile
Ah, oh well you got me haha. You need help with anything?
*[Continue] -> ifChose1End

===Chose2===
#you
#anim;Worried
Well, yes... and no. I'm not sure if this requires a Seer's guidance. Any ways... you need help?
*[Continue] -> ifChose2End


===ifChose1End===
#them
#anim;Neutral
Haha, you should be thanking me! But yes, I do need some help with choosing what to put in the eggs in purgatory I'm making. I was thinking some... dragon's breath for spice... or shimmerleaf for fun and tingles!

*[Dragon's breath] -> choseDragon
*[Shimmerleaf] -> choseShimmer

===ifChose2End===
#them
#anim;Neutral
If it persists, I do suggest you go to a Seer they'll help! What do you think we should put in our eggs in purgatory though? Dragon's breath for some kick or some shimmerleaf for fun?

*[Dragon's breath] -> choseDragon
*[Shimmerleaf] -> choseShimmer


===choseDragon===
#you
#anim;Astarion
Let's add some heat, those eggs <i>are</i> in purgatory hah.

*[Continue] -> dragonLyra
===choseShimmer===
#you
#anim;Astarion
Ooh let's just add the shimmerleaf, I can't really stomach the spice this early.
*[Continue] -> shimmerLyra

===dragonLyra===
#them
#anim;Happy
<i>*squeals*</i> Perfect! Exactly what I was thinking! Can you go and fetch some in the garden for me?

*[Accept] -> endstory
===shimmerLyra===
#them
#anim;Astarion
<i>*sighs*</i> Boohoo! You're no fun... either way I was going to do add the dragon's breath, it <i>is</i> in the recipe. And you will get it for me hahah!
*[Accept] -> endstory

===endstory===
#you
#anim;Smile
Will do ma'am!
-> END