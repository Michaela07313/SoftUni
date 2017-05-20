Problem 4. NSA<br/>


Most people have probably heard the news about some dummy named Edward Snowden, who released some info about an American association called the NSA, which, by his words, was spying on innocent citizens. Who cares anyways, it’s America, not my country. Yeah well … Guess again, NSA is Global.<br/>
The NSA creates a registry of spies. The input of data comes in the following format:<br/>
<ul>
<li>{countryName} -> {spyName} -> {daysInService}</li>
</ul>
The countryName and the spyName are both strings which may contain alphanumeric characters.<br/>The daysInService is an integer.<br/>
If you get an existent country, add the new spy to it. If even the spy exists, update its daysInService, with the new given value.<br/>
When you get the command “quit”, you terminate the program. Then you must print all countries and their spies.<br/>
The countries must be ordered by amount of spies they have in descending order.<br/>
The spies must be ordered by days in service, in descending order.<br/>

Input<br/>
<ul>
<li>The input comes in the format specified above.</li>
<li>The input sequence ends when you receive the “quit” command.</li>
</ul>

Output<br/>
<ul>
<li>The countries and their spies must be printed in the following format:<br/>
“Country: {country1Name}<br/>
 **{spy1Name} : {spy1Score}<br/>
 **{spy2Name} : {spy2Score}<br/>
 . . . <br/>
 Country: {country2Name}<br/>
 . . .”<br/></li>
 </ul><br/>
Constrains<br/>
<ul>
<li>The countryName and the spyName are both strings which may contain alphanumeric characters.</li>
<li>The daysInService will be a valid integer in range [0, 231 – 1].</li>
<li>There will be NO invalid input lines.</li>
</ul>

Examples<br/>
Input<br/>

Germany -> Duffy -> 1<br/>
Australia -> Bond -> 7<br/>
America -> Bond –> 5<br/>
Germany -> Alex -> 4<br/>
America -> Donald -> 4<br/>
Germany -> Jeffrey -> 3<br/>
Australia -> Jeffrey -> 4<br/>
quit	<br/><br/>

Output<br/>
Country: Germany<br/>
**Alex : 4<br/>
**Jeffrey : 3<br/>
**Duffy : 1<br/>
Country: Australia<br/>
**Bond : 7<br/>
**Jeffrey : 4<br/>
Country: America<br/>
**Bond : 5<br/>
**Donald : 4<br/>

