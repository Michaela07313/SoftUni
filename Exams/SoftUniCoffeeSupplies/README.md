## Problem 4. SoftUni Coffee Supplies

Alex is having hard time ordering coffee recently, because the new members of the team drink too much coffee. You need to help her. At the **beginning of the input** , you will receive the **keywords** for the week. Those keywords are delimiters, that Alex will use for the rest of the input. Alex will tell you **what coffee, everyone drinks**. She **should** also tell you **the quantity for each coffee type** , but **she might forget** , so you will have to assume that there in **none** left.

After you receive **all of the information** you need, you must **check how much coffee you have** , and if there in **none left from certain type** , you **must tell Alex, to order more**. Then you must monitor how much coffee each member of the team drinks. If a **coffee type ends** , you must **tell Alex to order** more. After the **end of the week** , you need to **print reports**. The **first report** should **print how much coffee is left**. It should be in the **following format** :

&quot; **coffeeType count**&quot;

This report **must**** be ****sorted** by the **count** for each **coffee**** type **in** descending ****order**.

The second report should tell us **which team members** have some coffee left, and what is the type of the coffee. The report **must be sorted** by **coffee type**** lexicographically **. If there are** team members **that drink the** same type of coffee **, their** names ****must**** be ****sorted**** lexicographically in descending order**.

## Input

- On the first line you are given the two delimiters separated by (space).
- On the next lines, until you receive &quot; **end of info**&quot; you are given one of the following lines:
  - &quot;**PersonName[firstDelimiter]CoffeeType**&quot;
  - &quot;**CoffeeType[secondDelimiter]Quantity**&quot;
- On the next lines, until you receive &quot; **end of week**&quot; you will receive how much coffee everyone drinks in the following format:
  - &quot; **PersonName count**&quot;

## Output

- When you run out of a coffee type you must print:
  - &quot; **Out of {coffeeType}**&quot;
- After you receive the command &quot; **end of week**&quot; you must print the following reports:
  - &quot; **Coffee Left:**&quot;
  - &quot; **{coffeeType} {quantity}**&quot; – All coffee types that have more than 0 quantity, sorted in **descending order by quantity**
  - &quot; **For:**&quot;
  - &quot; **{personName} {coffeeType}**&quot; – For each of the **coffeeTypes** from the previous report, print the team members drinking **each type of coffee**. This report must be **sorted in lexicographical order for each coffee type**. If there is **more than 1 team member** drinking the **same coffeeType** , **order them alphabetically in descending order**.

## Constraints

- The **two delimiters** will always be **different** strings
- The **Coffee Quantity** will be valid integer in the range **[0...2**


## Examples

| **Input** | **Output** |
| --- | --- |
| .-
Nakov.Espresso Ricco
Trifon.Voix de la Terre
Voix de la Terre-2
Espresso Ricco-5
end of info
Nakov 3
Trifon 1
Nakov 2
end of week | Out of Espresso Ricco
            | Coffee Left:
            | Voix de la Terre 1
            | For:
            | Trifon Voix de la Terre 
            |