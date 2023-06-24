using C_8.Clases;

Console.WriteLine("Welcome to the console animal game! \n Please select your animal");
Console.WriteLine("1- Bird");
choose();
Console.ReadKey();  
static void choose()
{
    int select = Convert.ToInt16(Console.ReadLine());
    switch (select){
        case 1: Console.WriteLine("You selected bird.");
            Bird.loop();
            break;
   }
}



