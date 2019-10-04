namespace RoleplayGame.Items
{
    public class VaritaMagica: IAttackItem
    {
       private Magic magia = new Magic();
       public int AttackPower
       {
        get
        {
            return magia.AttackPower+15;
        }  
       }
    }
}