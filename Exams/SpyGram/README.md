Problem 2 – SpyGram

After arriving from the trip from the Splinter Trip problem, our hero Sam is feeling a bit jet lagged, but he’s ready to go to work! He needs to receive orders from his commanding officers through the sophisticated messaging app, called SpyGram. The app uses a sophisticated algorithm to encrypt messages. Since you’re tired of jumbling text by hand for 8 hours a day, you decide to write an algorithm to do it for you.<br/>
Sending messages works the following way – an outgoing message must follow the following format:<br/>
<ul>
<li>TO: {recipient}; MESSAGE: {message};</li>
</ul><br/>
Here’s what an example message looks like: “TO: GOSHO; MESSAGE: hi.;”. If any message is not in this format, you should ignore it.<br/>
Both parties are given a private key, which consists of digits of a variable length, with which to encrypt/decrypt messages. The encryption algorithm is simple:<br/>
First, we take the message in the format above, then we shift right the first character of our message by the value of the first character of our private key in the ASCII table, the second character by the second private key character, and so on. If we run out of characters in our private key (such as when our message is longer than our private key), then we start over from the beginning of our private key.<br/>
So, with an example message of “hello”, and an example private key of 123, it would look like this:<br/>
hello -> igomq<br/>
<ul>
<li>h gets shifted right by 1 character</li>
<li>e gets shifted right by 2 characters</li>
<li>l gets shifted right by 3 characters</li>
<li>l gets shifted right by 1 character (we ran out of characters in the private key and rolled over to the start)</li>
<li>o gets shifted right by 2 characters.</li>
</ul>

Input<br/>
The first line of our input consists of our private key.<br/>
Until we receive the command “END”, we’ll start receiving non-encrypted messages to send to the command center. If we receive a message to send, we need to put it in our pending messages collection.<br/>
After that, we need to sort the sent messages by sender name in ascending order. <br/>

Output<br/>
To send a message, all we have to do is encrypt it and print it on the console in the standard outgoing message format.<br/>

Constraints<br/>
<ul>
<li>All valid recipient/sender names will be UPPERCASE and contain only Latin letters</li>
<li>Messages can contain ANY ASCII characterExamples</li>
</ul>

Input<br/>
13234<br/>
TO: GRIM; MESSAGE: hello;<br/>
TO: ARCHER; MESSAGE: sneak around it;<br/>
END	<br/>

Output<br/>
UR<#ESFJHV<#OHWTDIH>!vphel#cusvqf#mu><br/>
UR<#KSLO>$NHUVEHH<#lfonr?<br/>




