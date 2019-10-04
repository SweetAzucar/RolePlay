using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Mago
    /// </summary>
    public class Dwarf: Character
    {
        public Dwarf(string name)
            : base(name)
        {
            this.Health = 140;
            this.AddItem(new Canionaso());
        }
    }
}