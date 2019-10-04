namespace RoleplayGame.Items
{
    /// <summary>
    /// Item de ataque, Ballesta
    /// </summary>
    public class Ballesta : IAttackItem
    {
        
        
        public override string ToString()
        {
            return "Ballesta";
        }
        public int AttackPower
        {
            get
            {
                return 75;
            }
        }
       
    }
}