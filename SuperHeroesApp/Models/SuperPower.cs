using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperPower
    {
        public string Name;
        public string Descripcion;
        public LevelPower Level;

        public SuperPower()
        {
            Level = LevelPower.LevelTwo;
        }
    }
}
