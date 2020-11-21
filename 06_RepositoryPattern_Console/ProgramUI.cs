﻿using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class ProgramUI
    {
        // Method that runs/starts the application
        public void Run()
        {
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display the options to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing COntent\n" +
                    "6. Exit");

                //Get the users input
                string input = Console.ReadLine();

                //Evaluate the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        //Create new content
                        CreateNewContent();
                        break;
                    case "2":
                        //View all content
                        DisplayAllContent();
                        break;
                    case "3":
                        //View content by title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        //Update Existing content
                        UpdateExistingContent();
                        break;
                    case "5":
                        //Delete exisiting content
                        DeleteExistingContent();
                        break;
                    case "6":
                        //Exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Create New Streaming Content
        private void CreateNewContent()
        {
            StreamingContent
        }

        //View Current Streaming Content that  is saved
        private void DisplayAllContent()
        {

        }

        //View existing content by title
        private void DisplayContentByTitle()
        {

        }

        //Update Existing Content
        private void UpdateExistingContent()
        {

        }

        //Delete Existing Content
        private void DeleteExistingContent()
        {

        }
    }
}
