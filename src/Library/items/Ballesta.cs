namespace RoleplayGame.Items
{
    /// <summary>
    /// Túnica. Permite defenderse levemente.
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