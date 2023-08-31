using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Singleton_Pattern_Assignment
{
    public class PetDatabase
    {
        private static PetDatabase instance;
        
        private List<Pet> pets;

        private PetDatabase()
        {
            pets = new List<Pet>();
            LoadPetsFromFile();
        }

        public static PetDatabase Instance
        {
            get
            {
                if (instance == null)
                {
                    
                    instance = new PetDatabase();

                }
                return instance;
            }
        }

        private void LoadPetsFromFile()
        {
            try
            {
                string[] lines = File.ReadAllLines("C:\\ga\\Emma 6\\Singleton Pattern Assignment\\pets .txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split('-');
                    if (parts.Length == 3)
                    {
                        pets.Add(new Pet
                        {
                            Name = parts[0].Trim(),
                            Age = parts[1].Trim(),
                            Species = parts[2].Trim()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading pet data: " + ex.Message);
            }
        }
        public List<Pet> FindPetsByName(string name)
        {
            return pets.FindAll(pet => pet.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}