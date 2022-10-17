using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FinalTask
{
    class User
    {
        string mail;
        string path;
        string username;
        Dictionary<int, object> info;
        List<object> questions;
        List<int> mistake; // To collect all previous files of this user.
        public User(string email, string name, Dictionary<int, object> data) // Constructor.
        {
            Mail = email;
            Username = name;
            mistake = new List<int>();
            info = data;
            questions = new List<object>();
            path = $@"..\\..\\Data\\{mail}"; // Save the path, our Data directory and add the user mail beacuse it is the name of the directory for the player.
        }

        public string Mail // Property.
        {
            get
            {
                return mail;
            }
            set // Setter
            {
                List<int> invalid1 = new List<int>();
                int[] invalid = { 37, 38, 35, 123, 125, 60, 62, 42, 63, 47, 32, 36, 33, 92, 58, 43, 96, 124, 61 };
                foreach (var item in invalid)
                {
                    invalid1.Add(item);
                }
                bool check = false; // Indicate if the mail contains '@'
                bool dot = false; // Indicate if there is a '.' after the '@' sign in the mail.
                foreach (char item in value) // Check every char in the mail string.
                {
                    if (item == ' ') // According to your request the mail cannot contain spaces.
                    {
                        throw new ArgumentException(".המיי ל מכיל רווחים, הוא לא תקין");
                    }
                    if (item == '@') // Check for '@'.
                    {
                        check = true;

                    }
                    if ((check == true) && item == '.') // Check for '.' after '@'.
                    {
                        dot = true;
                    }
                    if (invalid1.Contains((int)item))
                    {
                        throw new ArgumentException("המייל מכיל תו לא תקני");
                    }
                }
                if (check == false) // We didnt find '@' in the mail adress.
                {
                    throw new ArgumentException(".המייל אינו תקין, אין סימן כרוכית");
                }
                if (dot == false) // We didnt find '.' after the '@' sign in the mail adress.
                {
                    throw new ArgumentException(".המייל אינו תקין, אין נקודה לאחר סימן הכרוכית");
                }
                mail = value; // Set.
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                List<int> invalid1 = new List<int>();
                int[] invalid = { 37, 38, 35, 123, 125, 60, 62, 42, 63, 47, 32, 36, 33, 92, 58, 64, 43, 96, 124, 61 };
                foreach (var item in invalid)
                {
                    invalid1.Add(item);
                }
                List<char> replace = new List<char>();
                foreach (char item in value) // Check every char in the mail string.
                {
                    if (invalid1.Contains((int)item))
                    {
                        replace.Add(item);
                    }
                }
                foreach (var item in replace)
                {
                    value = value.Replace(item, 'a');
                }
                username = value;
            }
        }

        public Dictionary<int, object> Info
        {
            get
            {
                return info;
            }
        }

        public List<object> Questions
        {
            get
            {
                return questions;
            }
        }


        // The function recives no argument and is a void type.
        // The aim of the function is to sort the issue of returning players.
        public void CheckDirectory()
        {
            if (Directory.Exists(path)) // Check if there is already a directory in our Data directory that is named after the player mail.
            {
                return;
            }
            else
            {
                Directory.CreateDirectory(path); // Its is new player, create a directory for him.
            }
        }
        // The function recives no argument and it is a void type.
        // The aim of the function is to collect all of the player previous data(if there is such a thing).
        public List<int> GetInfo()
        {
            string[] a;
            string mistakes; // String.
            foreach (string fi in Directory.GetFiles(path)) // Go through all of the files in the directory.
            {
                mistakes = File.ReadAllLines($@"{path}\\{fi}").Last(); // Save the info of the last line in the file.
                a = mistakes.Split(' ');
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (!mistake.Contains(int.Parse(a[i])))
                    {
                        mistake.Add(int.Parse(a[i])); // Add it to the array list
                    }
                }
            }
            return mistake;
        }
        // The function gets an integer and returns a list of objects.
        // The function aim is to create a list of random question for the game.
        public List<object> Game(int amount)
        {
            Pool pool = new Pool();
            List<object> game = pool.ChooseQuestions(questions, amount);
            return game;
        }
        // The function gets no variables is void.
        // The function aim is to create the questions pool.
        public void IntializePool()
        {
            Pool t = new Pool();
            t.CreateQuestions();
            questions = t.questions();
        }
    }
}


