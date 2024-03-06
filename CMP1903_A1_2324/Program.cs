using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Game object and call its methods.
            Game game1 = new Game();
            game1.rollDice();
            game1.SumOfDice();


            //Create a Testing object to verify the output and operation of the other classes.
            Testing testing = new Testing();
            testing.TestDie();
            testing.TestGame();

            Console.ReadKey();
        }
    }
}
// <black-eye-inc> Review:
// "Program.cs" is very simple and effective.
// The only (very small gripe) I can say is "game1" implies "game2" may exist... but complaining
// about something that small is the definition of is pethetic.
// </black-eye-inc>

// <black-eye-inc> Review Conclusion:
// Throughout your code you've done a great and accurate job at following the C# Style Guide's
// naming rules, with only a few exceptions that I've noted.
// Your program as a whole is very simple and effective and meets all required criteria except for
// the "Continuous Roll Dice" EXTRA Functionality method (though that is optional criteria!).
// Excluding for the use of testing purposes, I'd recommend against the use of adding
// "Console.Writeline" code everywhere to print out every small activity the program is committing
// sinse it's not what the target user brought this game to see.

// You haven't used any XML Documentation in your code, though it's only required for full marks,
// if you'd like to include it then:
// - For reference on how to use it with examples: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments
// - My project uses a lot of it, if you'd like inspiration: https://github.com/black-eye-inc/CMP1903_A1_2324_fork/tree/Development

// Also, outside of the naming rules, I couldn't find application of any of the other C# Style
// guide rules
// - mainly the "all comments should start at column 53"
                                                    // basically should all be up here and also
                                                    // should continue on at the next line at
                                                    // column 100.
// - There are many more annoying rules, so many it feels like a lost cause, but if you really want
//   full marks then the "all comments should start at column 53" is a good start
// </black-eye-inc>
