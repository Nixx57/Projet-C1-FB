using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_C1_FB
{
    public class Espece
    {
        public Espece()
        {
        }

        public Espece(string nom, int nbMaxATuer)
        {
            Nom = nom;
            NbMaxATuer = nbMaxATuer;
        }

        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public int NbMaxATuer { get; set; }
    }
}
