namespace RoleplayGame.Characters
{
    /// <summary>
    /// Tipos de personajes
    /// </summary>
    public enum CharacterType
    {
        Elf = 1,
        Wizard = 2,

        Troll = 3,
        Dwarf = 4,
        Fairy=5
    }

    /// <summary>
    /// Crea objetos de tipo Personaje
    /// </summary>
    public class CharacterFactory
    {
        /// <summary>
        /// Crea un personaje dado un tipo de personaje y un nombre
        /// </summary>
        public static Character GetCharacter(CharacterType type, string name)
        {
            switch (type)
            {
                case CharacterType.Elf: return new Elf(name);
                case CharacterType.Wizard: return new Wizard(name);
                case CharacterType.Troll: return new Troll(name);
                case CharacterType.Fairy: return new Fairy(name);
                case CharacterType.Dwarf: return new Dwarf(name);
                default: throw new System.Exception($"Invalid character {type}");
            }
        }
    }
}