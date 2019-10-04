using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Troll, nace con un palo y una coraza que lo proteje de los ataques
    /// </summary>
    public class Troll : Character
    {
        public Troll(string name)
            : base(name)
        {
            this.Health = 150;
            this.AddItem(new Palo());
            this.AddItem(new Coraza());

        }
    }
}