using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Hada
    /// </summary>
    public class Fairy : Character
    {
        public Fairy(string name)
            : base(name)
        {
            this.Health = 140;
            this.AddItem(new Magic());
        }
    }
}
