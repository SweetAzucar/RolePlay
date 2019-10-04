namespace RoleplayGame.Items
{
    public class Palo : IAttackItem
    {
        /// <summary>
        /// El palo del troll
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 10;
            }
        }
        public override string ToString()
        {
            return "Palo";
        }
    }
}