using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class Pool
    {
        List<object> pools;
        List<int> numbers;
        List<object> game;
        List<Questions> pool;
        public Pool() // Constructor.
        {
            pool = new List<Questions>(); // Intialize
            numbers = new List<int>(); // Intialize
            game = new List<object>(); // Intialize
            pools = new List<object>(); // Intialize
            for (int i =0; i< 41; i++) // Set numbers basic values.
            {
                numbers.Add(i);
            }
        }
        // The function recives no variables and is void.
        // The aim of the function is to create the questions pool for later use.
        public void CreateQuestions()
        {
            StreamReader info = new StreamReader(@"..\\..\\Data\\gameData.txt"); // Read file.
            string str = null; // Reader.
            string[] a; // Array for the text.
            bool answer = false;
            while ((str = info.ReadLine()) != null) // Read file.
            {
                a = str.Split(';'); // Split the line by ';'
                if (str.Contains("TYPE0")) // Check question type.
                {
                    if (a[3] == " אמת") // Get correct answer.
                    {
                        answer = true;
                    }
                    else
                    {
                        answer = false;
                    }
                    pool.Add(new QType0(a[2], 0, answer)); // Create object.
                }
                if (str.Contains("TYPE1")) // Check question type.
                {
                    pool.Add(new QType1(a[2], 1, a[3], a[4], a[5])); // Create object due to us knowing the right answer position.
                }
                if (str.Contains("TYPE2")) // Check type.
                {
                    if (a[3] == "אמת") // Get correct answer.
                    {
                        answer = true;
                    }
                    else
                    {
                        answer = false;
                    }
                    pool.Add(new QType2(a[2], 2, answer,a[a.Length - 1])); // Create object.
                }
                if (str.Contains("TYPE3")) // Check type.
                {
                    pool.Add(new QType3(a[2], 3, a[3], a[4], a[5])); // Create object due to us knowing the right answer postion.
                }
            }
            info.Close(); // Close txt file.
        }
        // The function recives no arguments and returns a list of objects.
        // The function returns a list of all the questions as objects so it is a public class. 
        public List<object> questions()
        {
            if(pool.Count == 0) // Check if the pool is already intialized.
            {
                return null;
            }
            foreach (var item in pool) // copy
            {
                pools.Add(item);
            }
            return pools;
        }
        // The function recives a list of objects and an integer of amount, the function returns a list of objects.
        // The aim of the function is to randomized a list of questions in the deiserd size.
        public List<object> ChooseQuestions(List<object> pools, int amount)
        {
            Random random = new Random(); // Create random object.
            int r;
            for (int i = 0; i < amount; i++)
            {
                r = random.Next(1, pools.Count);
                while (!numbers.Contains(r)) // check if we already randomized this number.
                {
                    r = random.Next(1, pools.Count); // Random again beacuse we already randomed this number.
                }
                game.Add(pools[r]);
                numbers.Remove(r);
            }
            return game;
        }
    }
}
