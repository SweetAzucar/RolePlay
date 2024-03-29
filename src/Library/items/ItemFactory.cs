namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        Canionaso = 3,
        Ballesta = 4,
        VaritaMagica = 5,
        ArcoMagico = 6,
        Guantelete = 7,
        Coraza = 8,
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.Canionaso: return new Canionaso();
                case ItemType.Ballesta: return new Ballesta();
                case ItemType.VaritaMagica: return new VaritaMagica();
                case ItemType.ArcoMagico: return new ArcoMágico();
                case ItemType.Guantelete: return new Guantlet();
                case ItemType.Coraza: return new Coraza();
                default: return null;
            }
        }
    }
}