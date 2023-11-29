using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHeroe : Heroe, ISuperHeroe
    {
        private string _Name;
        public int Id { get; set; } = 1;
        public override string Name { get 
            {
                return _Name;
            }
            set
            {
                _Name = value.Trim();
            }
        }

        public string NameandSecretIdentify
        {
            get
            {
                return $"{Name} ({SecretIdentify})";
            }
        }
        public string SecretIdentify { get; set; }
        public string City;
        public List<SuperPower> SuperPowers;
        public bool PuedeVolar;

        public SuperHeroe()
        {
            Id = 1;
            SuperPowers = new List<SuperPower>();
            PuedeVolar = false;
        }

        public string UseSuperPower()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (var power in SuperPowers)
            {
                sb.AppendLine($"{NameandSecretIdentify} esta usando el super poder de {power.Name}!!");
            }
            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{NameandSecretIdentify} ha salvado el mundo"; 
        }

        public override string SalvarPersonas()
        {
            //return base.SalvarLaTierra();
            return $"{NameandSecretIdentify} Ha salvado muchas personas.";
        }

    }
}
