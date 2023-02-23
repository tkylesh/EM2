using System;

namespace EnthusiasticMoose2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            MooseSays("Hi, I'm Randy the Moose!");
            MooseSays("I'm really excited to be here today!");

            bool isTrue = MooseAsks("Is Canada real?");
if (isTrue)
{
    MooseSays("Really? It seems very unlikely.");
}
else
{
    MooseSays("I  K N E W  I T !!!");
}


            void MooseSays(string question)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {question}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

    bool MooseAsks(string question)
{
    //displaying question and waiting for response
    Console.Write($"{question} (Y/N): ");
    //storing response in answer
    string answer = Console.ReadLine();

    //run the question until y or n is entered
    // string answer = "";

    while (answer != "y" && answer != "n")
    {
        // Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }


    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}
        }
    }
}
