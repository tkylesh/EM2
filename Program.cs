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
            CanadaQuestion();
            EnthusiasticQuestion();
            LoveCSharpQuestion();
            SecretQuestion();


            void CanadaQuestion()
            {
                bool isTrue = MooseAsks("Is Canada real?");
                if (isTrue)
                {
                    MooseSays("Really? It seems very unlikely.");
                }
                else
                {
                    MooseSays("I  K N E W  I T !!!");
                }
            }

            void EnthusiasticQuestion()
            {
                bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
                if (isEnthusiastic)
                {
                    MooseSays("Yay!");
                }
                else
                {
                    MooseSays("You should try it!");
                }
            }

            void LoveCSharpQuestion()
            {
                bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
                if (doesLoveCSharp)
                {
                    MooseSays("Good job sucking up to your instructor!");
                }
                else
                {
                    MooseSays("You will...oh, yes, you will...");
                }
            }

            void SecretQuestion()
            {
                bool wantsSecret = MooseAsks("Do you want to know a secret?");
                if (wantsSecret)
                {
                    MooseSays("ME TOO!!!! I love secrets...tell me one!");
                }
                else
                {
                    MooseSays("Oh, no...secrets are the best, I love to share them!");
                }
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
