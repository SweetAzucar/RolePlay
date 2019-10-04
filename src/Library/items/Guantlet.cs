
using System.Collections.Generic;

namespace RoleplayGame.Items
{

    public class Guantlet : IAttackItem
    {
        
        /// <summary>
        ///  El guantelete por si sólo no tiene poder, debe implementar gemas para poder aumentar el mismo
        /// </summary>
        
        private List<IGem> Sockets{get; set;} //Socket es una lista de gemas, puede tener ninguna o puede tener varias

        public void AddGem(IGem gem)
        {
        ///<summary>
        /// Permite agregar gemas a los sockets
        ///</summary>
            this.Sockets.Add(gem); 
        }

        public override string ToString()
        {
            return "Guantelete del poder";
        }
        public int AttackPower
        {
            get
            {
                int totalDamage = 0;

                foreach (IGem gem in Sockets) //se recorren las gemas para ver el daño y retornar el mismo
                {
                    totalDamage += gem.AddedPower;
                }
                return totalDamage;
            }
        }
    }
}