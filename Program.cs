/* See https://aka.ms/new-console-template for more information
ARELY MARTINEZ 

MAD LIBS #5

OCT 19 2022 10:39 AM

THIS PROGRAM WILL ASK USERS FOR NOUNS, VERBS, ADJECTIVES, ETC. 
ONCE THEY ENTER SAID THING IT WILL SHOW UP IN THE TERMINAL AS  
A SENTENCE WITH THE MULTIPLE INPUTS THEY ENTERED. AT THE END 
OF PROGRAM THE TERMIAL WILL ASK THE USER IF THEY WANT TO PLAY 
AGAIN. IF THEY ENTER ANY VERIATION OF YES THE PROGRAM WILL REPLAY. 
AND VISE VERSA FOR NO. HOWEVER IF THEY DONT ENTER ANYTHING BUT THAT 
IT WILL ASK THE USER OVER AGAIN UNTIL THEY ENTER IN YES OR NO.

PEER REVIEW: NAME -- REVIEW
*/

bool playAgain = true;
while (playAgain) {
    Console.Clear();
    Console.WriteLine("WE'LL BE CREATING A UNIQUE STORY W/ WORDS U WILL PROVIDE ");

    Console.WriteLine("LETS PICK OUT THE 1ST ADJECTIVE Ex: BIG, TALL, SMELLY ");
    string firstAdj = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("LETS PICK OUT THE 2ND ADJECTIVE");
    string secAdj = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("LETS PICK OUT THE 1ST LIVING ANIMAL Ex: PIG, CAT, ELEPHANT ");
    string firstAnimal = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("LETS PICK OUT THE 2ND LIVING ANIMAL");
    string secAnimal = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("LETS PICK OUT A ADVERB (add a -ly at the end) Ex: SLOWLY, QUIETLY, JOYFULLY ");
    string firstAdv = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("LETS PICK OUT ANOTHER ADVERB");
    string secAdv = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("LETS PICK OUT A EVENT EX: BIRTHDAY PARTY, MEETING, BASKET BALL GAME");
    string firstEvent = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("LETS PICK OUT ANOTHER EVENT");
    string secEvent = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("LETS PICK OUT A NOUN (THING) EX: PRESENT, BOAT, CAKE ");
    string firstNoun = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("LETS PICK OUT ANOTHER NOUN (THING) ");
    string secNoun = Console.ReadLine();

    Console.WriteLine( " " );
    Console.WriteLine("THE " + firstAnimal + " " + firstAdv + " WENT TO THE " + firstEvent + "." );
    Console.WriteLine("WHILE THE " + secAdj + " " + secAnimal + " COULDN'T MAKE IT ON TIME. " );
    Console.WriteLine( "SO THEY MET AT THE " +  secEvent  + ". ");
    Console.WriteLine("WHEN THEY RETURNED THE " + firstAnimal + " AND THE " + secAnimal  + " CAME HOME TO " + firstNoun + " & A " + secNoun + " IN THIER PARKINGLOT. " );
    Console.WriteLine( " " );


    bool converted = true;
    while (converted){
        Console.WriteLine("WOULD YOU LIKE TO PLAY AGAIN? YES OR NO ");
        string rePlay = Console.ReadLine().ToUpper();

        if(rePlay == "YES" ){
            playAgain = true;
            converted = false;
            Console.Clear();
            Console.WriteLine( "LETS PLAY AGAIN!!" );
            Console.WriteLine( " " );
            break;
        } 
        if(rePlay == "NO"){
            playAgain = false;
            converted = false;
            Console.WriteLine(" ");
            Console.WriteLine( "THANK YOU FOR PLAYING!!! " );
            break;
        }
        else{
            converted = true;
            Console.WriteLine(" ");
            Console.WriteLine( "INVAILD RESPONSE TRY AGAIN!!" );
            Console.WriteLine(" ");
        }
    } 
}