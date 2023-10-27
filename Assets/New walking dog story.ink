VAR happyEnding = false
VAR badEnding = false

 

-> Park

== Park ==
#image;walkingwithdog
#sound;manWalking3
Sally wanted to have a nice relaxing walk with her dog Max. #left
They decided to head to the park and walk along the lake and play with max. # right
*[walking] -> leavepark

 


 == Sidewalk ==
  # right
  #image;Dogsbarking
  #sound;dogbarks2
  #anime;sad
 Sally then decided to walk back home taking a longer way so max and her can relax on the way.
 *[Street] -> Street
 
 == Street ==
 # right
 #anime;idle
 on one quiet street Sally and Max saw Suzie with with her dog Pam walking towards the. 
 *[Meet Suzie]-> MeetSuzie
 == MeetSuzie ==
 #image;dogbarkfaraway
 #sound;Dogbarkingfaraway2
 Max was a nice playful dog, but pam was a bigger, sort of unfriendly dog and started barking from a distance as soon as she saw max.#right
 *[Continue] -> Continue
 
 == Continue ==
 #right
 #anime;talk
 Sally expected Suzie to change lanes with her dog. But she did not and the dogs met and pam started barking at max making Sally and Max scared.
 *[Sally is concerned]->Sallyisconcerned
 *[Sally is relaxed]->Sallyisrelaxed
 ==Sallyisrelaxed==
 #right
 #anime;happy
 Hello you have a nice dog you got there.
  *[Suzie is Aggressive]->SuzieisAggressive
 *[Suzie is Nice]->SuzieisNice
 == Sallyisconcerned ==
 #right
 #sound;dogangrygrowl
 #image;angrybarkingdog
 #anime;angry
 Please control your dog get away from mine!
 *[Suzie is Aggressive]->SuzieisAggressive
 *[Suzie is Nice]->SuzieisNice
 ==SuzieisNice==
 #left
 #anime;talk
 Oh thank you, your dog is also nice.
 ~ happyEnding = true
 -> theend
 
 == SuzieisAggressive ==
 #left
 #anime;angry
 She is just playing! Don't stress!
 
 *[Sally replies]-> Sallyreplies
 == Sallyreplies ==
 #right
 #sound;twoangrydogsfighting
 #image;fightingdogs
 That's no play, get her away!
 
 *[Suzie Replies back]-> SuzieRepliesback
 ==SuzieRepliesback==
 #left
 #anime;sad
 OMG!  Don't be so Sensitve!
 
 *[Suzie Apologies]->SuzieApologies
 *[Suzie Speaks back]->SuzieSpeaksback
 ==SuzieApologies==
 #left
 ok, Im sorry, she is just being hasty, she doesn't bite. See? they are getting to each other.
 
 *[Sally changes]->Sallychanges
 == Sallychanges ==
 #right
 #sound;dogsplaying
 #image;Dogshavingfun
 #anime;happy
While the dogs were calmer. Sally saw max more relaxed with pam and started chatting with suzie while they kept on talking


*[Max and Sally]-> MaxandSally
== MaxandSally ==
#left
#anime;happy
 Both Max and Sally made new friends.
 
 ->DONE
 ==SuzieSpeaksback==

 
 ~ badEnding = true
 -> theend
 ==theend==
 {happyEnding: 
 #right
 Max was sniffing around pam and playing with him.
 
 }
 
  {badEnding: 
 #left
 #anime;angry
  Can't you tell when dogs want to play?
 
  
 }
 
 *[Sally speaks Nice] -> SallyspeaksNice
     *[Sally speaks angrily]-> Sallyspeaksangrily
  == Sallyspeaksangrily ==
  #right
  #anime;angry
  Yes! and that is not it.
 
 *[Go home] -> Gohome
 
 
 == SallyspeaksNice ==
 #right
 #image;twodogsplaying
 #sound;twoDogsplaying
 #anime;talk
 it look like my dog likes your dog a lot.
 *[Sally and Suzie are friends]->SallyandSuziearefriends
 == SallyandSuziearefriends ==
 #right
 #image;twogirlswalking
 #anime;idle
 and with that both Sally and Suzies dogs began playing a lot and had fun all day long.
 ->END
 


  
 
 
 == leavepark ==
 
 However, when they arrived to the park they found a dog contest going on and the park was full of dogs and their owners, there would be no relaxing walk there. # right
 *[sidewalk] -> Sidewalk 
 

 
 == Gohome==
# right 
#image;walkingawaywithdog
#sound;girlhmph
 She pulled max away while suzie pulled pam. gave each other a denty look and walked away from each other very angry that they met. 
 
 -> DONE