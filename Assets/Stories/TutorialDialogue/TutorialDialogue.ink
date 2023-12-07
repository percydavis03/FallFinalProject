#them
Goodness Syviis, slept in a bit again?

* [I like my sleep...] -> sleepChoice
* [A weird dream...] -> dreamChoice

===sleepChoice===
#you
<i>*scoffs*</i> Hey! I like my sleep Miss up-at-the-crack-of-dawn.
*[Continue] -> ifChose1

===dreamChoice===
#you
Yeah.. I had another weird dream.
*[Continue] -> ifChose2

===ifChose1===
#them
Well at least I water aNd fertilize the plants! You always just sleep while I do the dirty work hmph!
*[Continue] -> Chose1

===ifChose2===
#them
Oh... another one? That's weird do you think about seeing the Village Seer?
*[Continue] -> Chose2


===Chose1===
#you
Ah, oh well you got me haha. You need help with anything?
*[Continue] -> ifChose1End

===Chose2===
#you
Well, yes... and no. I'm not sure if this requires a Seer's guidance. Any ways... you need help?
*[Continue] -> ifChose2End


===ifChose1End===
#them
Haha, you should be thanking me! But yes, I do need some help with choosing what to put in the eggs in purgatory I'm making. I was thinking some... dragon's breath for spice... or shimmerleaf for fun and tingles!

*[Dragon's breath] -> choseDragon
*[Shimmerleaf] -> choseShimmer

===ifChose2End===
#them
If it persists, I do suggest you go to a Seer they'll help! What do you think we should put in our eggs in purgatory though? Dragon's breath for some kick or some shimmerleaf for fun?

*[Dragon's breath] -> choseDragon
*[Shimmerleaf] -> choseShimmer


===choseDragon===
#you
Let's add some heat, those eggs <i>are</i> in purgatory hah.

*[Continue] -> dragonLyra
===choseShimmer===
#you
Ooh let's just add the shimmerleaf, I can't really stomach the spice this early.
*[Continue] -> shimmerLyra

===dragonLyra===
#them
<i>*squeals*</i> Perfect! Exactly what I was thinking! Can you go and fetch some in the garden for me?

*[Accept] -> endstory
===shimmerLyra===
#them
<i>*sighs*</i> Boohoo! You're no fun... but I must oblige. Can you grab me some in the back garden?
*[Accept] -> endstory

===endstory===
#you
Will do!
-> END