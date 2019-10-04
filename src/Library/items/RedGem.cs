namespace RoleplayGame.Items
{
    /// <summary>
    /// Gema roja.
    /// </summary>
    public class RedGem : IGem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AddedPower
        {
            get
            {
                return 45;
            }
        }

        public override string ToString()
        {
            return "Gema Roja";
        }

    }
}
