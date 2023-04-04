using System.Collections.Generic;

namespace DictionaryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "dog1");
            dict.Add(2, "as");
            dict.Add(3, "dog3");
            dict.Add(4, "dog4");

            Console.WriteLine("-----------------------------------------------");
            DisplayDicti(dict);

            dict.Remove(3);

            Console.WriteLine("-----------------------------------------------");
            DisplayDicti(dict);


            bool isContains = dict.ContainsKey(1);

            Console.WriteLine($"Is key 3 is contains: {isContains}");

            Console.WriteLine("Input value: ");
            string userInput = Console.ReadLine();

            bool isValueContains = dict.ContainsValue(userInput);

            Console.WriteLine($"Yes value is in Dictionary {isValueContains}");
            Console.WriteLine("Key value in Dictionary =======");
            foreach (KeyValuePair<int, string> keyValuePairEl in dict)
            {
               if (keyValuePairEl.Value == userInput)
                {
                    Console.WriteLine(keyValuePairEl.Key);
                }
            }

            List<Pet> pets = new List<Pet>();

            Pet pet = new Pet("Rex");

            pets.Add(pet);
            pets.Add(pet);
            pets.Add(pet);
            pets.Add(pet);

        }

        static void DisplayDicti(Dictionary<int, string> dictionary)
        {
            foreach(KeyValuePair<int, string> keyValuePairEl in dictionary )
            {
                Console.WriteLine($"KeyValue: {keyValuePairEl.Key} Value: {keyValuePairEl.Value}");
            }
        }
    }
}