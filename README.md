# Lorem-Ipsum-Pong

### Lorem Ipsum is a game where you must belt Latin words with holy conviction to expel Satan from... your computer I guess?\*. This antediluvian and incredible battle of good and evil, light and darkness, of the powers holy and unholy, is most accurately represented through a game of Pong. 

By singing the words in a higher pitch, you compel the paddle upwards, and by singing lower, you force it down. If you can get to five points, you win this stuggle and the shadows are turned. If your opponent, the Antichrist himself, wins, your soul is forfeit. Enjoy!

This game features some delicious voice acting as well as original music and sounds. Banishing evil has never felt so premium.

Features:
- Developed in Unity
- Uses the Corvid Conspirator font from: https://pleeze.itch.io/slimesfonts
- Uses code from this repo for microphone input to frequency functionality: https://github.com/nakakq/AudioPitchEstimatorForUnity
- Sounds and music created in Ableton
- Random generation of Latin words using (cleaned) text file from: https://archive.org/details/laterculivocuml00gradgoog/page/n12/mode/1up
- Otherwise, it's Pong\!
  
\* Game Developer is not responsible for demons or other extraplanar creatures summoned as a consequence of over-zealous Latin invocation.

DevLog:

I began this project by following a Pong creation tutorial in Unity. I'd never actually used Unity prior to this so it served as a good general tutorial for the engine along with helping me start this project. After creating the simple version of Pong with the video, I was considering what controller system would be interesting and achievable for me. I don't have any experience with Arduino and little with physical computing so I wanted to create something that required little fabrication and hardware for this first project, especially since I was already attempting to learn a lot by using Unity. 

I intially experimented with my MIDI keyboard, since I had some experience using it and it was a readily accessible controller. I spent a decent amount of time figuring out how to use it in Unity and control the paddles, but after successfully getting input from notes I decided it wasn't as fun as I wanted. So I went back to one of my earlier ideas: controlling the paddles through singing/voice, which seems inherently silly and fun, but I wanted to put an interesting spin on it since I knew it was a popular concept for this class. First I prototyped the game using voice loudness, which took a decent amount of time to figure out with how confusing I thought the Microphone functionality of Unity is--but I got it working well. At this point I considered a way to integrate both the MIDI keyboard and voice control together, but I really didn't have any good ideas on how to make it fun and/or playable, so then decided to fully lean into using the microphone input for a control.

Of course the natural question was now "how do I make this more fun than just talking into a mic loudly or softly?" The answer was using the pitch of your voice, shifting it to move the paddles up and down. This is fundamentally funny. Fortunately I found a great GitHub repo to integrate into my project that allowed me to get frequency from microphone input (although it was quite a pain to get it working properly). I first tried it with different songs, with their lyrics to the side to sing, and while fun it didn't feel chaotic enough to me. I planned to use a random word generator, but instead of English words, I thought it'd be much funnier and unique to use Latin. This basically decided the theme for the rest of the game: You were a priest or such singing a Gregorian-esque Latin invocation to defeat the Devil. Briefly I considered implementing multiplayer, but Unity vetoed me with how frustratingly awful multiple mic input is in the engine.

Now armed with a consistent theme and set goal, I worked on making the game juicier. My first interest was sound and music. I'm very interested in diving deeper into sound and music production for games, so I decided to get some more experience in that field by creating my own music and sound effects in Ableton, as well as recording my own voice acting for the  game over and winning screens. The background music really adds to the thematic package of the game, and I made sure all the ball collision sounds were in the same key as the background music, to create a sort of generative music experience when the player begins to sing with the rest of the audio. Finally I added some visual details like the cross of the paddle and some hit feedback. I wish I could've explored more visual juice in this project, but I ran out of steam and time unfortunately. This is definitely something I want to explore in further projects though!

I also purchased a monk costume and cross to wear while playing, not because I needed it but because it was funny and I wanted it.

I'm pretty satisfied with the final product, and more importantly I learned a ton about Unity (and game production as a whole) in the process. I wish I hadn't gotten sick because I wanted more time to inject all the juice I had planned but I'll save those goals for future opportunities. As a whole, I think it's a very unique take on Pong and is surprisingly fun!
