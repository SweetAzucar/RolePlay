namespace RoleplayGame.Items
{

    public class ArcoMágico: IAttackItem
    {
       private Magic Magia= new Magic();
        public int AttackPower
        {
            get
            {
                return Magia.AttackPower + 20;
            }
        }
        public override string ToString()
        {
            return "Arco Magico";
        }
    }
}