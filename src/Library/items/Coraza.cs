namespace RoleplayGame.Items
{
    /// <summary>
    /// Defensa natural del Troll
    /// </summary>
    public class Coraza : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa de la coraza del Troll
        /// </summary>

        public int DefensePower
        {
            get
            {
                return 100;
            }
        }

        public override string ToString()
        {
            return "Coraza";
        }
    }
}