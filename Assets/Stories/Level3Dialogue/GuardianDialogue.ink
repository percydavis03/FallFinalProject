#them
Halt!
*[Continue] -> action

===action===
#action
<i>The guardians speak in a collective voice, almost as if they were one.</i>
*[Continue] -> guardians

===guardians===
#them
What is your business here, faery, in the Great Mother's Womb?
*[Continue] -> syviis

===syviis===
#you
I was sent here, from my Village Seer, Hyacinth, she said the Great Mother has set me on a path.
*[Continue] -> guardians1

===guardians1===
#them
Who are you?
*[Continue] -> syviis1

===syviis1===
#action
<i>*Who am I?*</i>
*[I am Syviis] -> syviis2
*[I am Truthseer] -> truthseer

===syviis2===
#you
I am Syviis, first of my name, from the East Auroran Village.
*[Continue] -> action1


===truthseer===
#you
I am the Truthseer, Syviis, first of my name.
*[Continue] -> action1

===action1===
#action
<i> The guardians step aside. </i>


    -> END
