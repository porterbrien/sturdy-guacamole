using System;
using System.ComponentModel;
using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {
        Journal book1 = new Journal();
        Entry entry1 = new Entry();
        bool Loop = true;
        
        while(Loop){

            Console.Clear();
            Console.WriteLine("Journal:\n1. Add entry\n2. Display the Journal\n3. Save Journal\n4. Load Journal \n5. Exit\n");
            string userInput = Console.ReadLine();
            
            // first showMenu
            
            if (userInput == "1"){
                // Getting the current date.
                DateTime theCurrentTime = DateTime.Now;
                // Switches the date to a string.
                string dateText = theCurrentTime.ToShortDateString();
                // Calling the randomPrompt function from our Entry class.
                string prompt = entry1.randomPrompt();
                Console.WriteLine(prompt);
                // Reads the user input.
                string response = Console.ReadLine();
                // Calling the parameters to send into one line on a temp file, so we can access the information all in the same structure every single time.
                entry1.createEntry(dateText, prompt, response);
                // What does the Count Library do?
                Console.WriteLine(entry1.entries.Count);
            }

            else if(userInput == "2")
            {
                Console.Clear();
                entry1.displayEntry();
            }

            // else if (userInput == '3')
            // {
            //     Save journal to a file
            // }

            // else if (userInput == '4')
            // {
            //     Load the journal from a file
            // }

            else if (userInput == "5")
            {
                Console.Clear();
                Loop = false; 
            }
            
        }



    }
}
    // public Journal = new Journal();

    // public void SaveEntry(){

    // } 
    // public void LoadEntry(){

    // }


//     public void WhileStatement(){
//         bool bombLoop = true;
        
//         while(bombLoop){
//             // first showMenu
//             Console.Clear();
//             ShowMenu();
            
//             if 1{
//                 Console.WriteLine($"Userinput");
//             }

//             // if 2{
//             //     Display the journal
//             // }

//             // if 3{
//             //     Save journal to a file
//             // }

//             // if 4{
//             //     Load the journal from a file
//             // }
//         }
//     }
//     public int ShowMenu(){
//         Console.WriteLine("Journal:\n1. Add entry\n2. Display the Journal\n3. Save Journal\n4. Load Journal \n5. Exit");
//         string Input = Console.ReadLine();
//         return int.Parse(Input);
//     }

// }