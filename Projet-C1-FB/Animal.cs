using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_C1_FB
{
    public enum Gender
    {
        M,
        F
    }
    public class Animal
    {
        public Animal()
        {
        }

        public Animal(string nom, Espece espece, string race, Gender genre, int age, string regionHabitat)
        {
            Nom = nom;
            Espece = espece;
            Race = race;
            Genre = genre;
            Age = age;
            RegionHabitat = regionHabitat;
        }

        public string Nom { get; set; }
        [Key, Column(Order = 1)]
        public int Id { get; set; }
        public int EspeceId { get; set; }
        [ForeignKey("EspeceId")]
        public Espece Espece { get; set; }
        public string Race { get; set; }
        public Gender Genre { get; set; }
        public int Age { get; set; }
        public string RegionHabitat { get; set; }
    }
}
