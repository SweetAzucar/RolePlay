namespace RoleplayGame.Items
{
    /// <summary>
    /// Gema azul.
    /// </summary>
    public class BlueGem : IGem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AddedPower
        {
            get
            {
                return 90;
            }
        }

        public override string ToString()
        {
            return "Gema Azul";
        }

    }
}
