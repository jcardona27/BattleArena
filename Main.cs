class Program
{
static void Main()
{
    Fighter thor= new Wizard("Thor, Son of Odin");
    Fighter Gustavo= new Warrior("Gustavo");

    BattleArena battle = new BattleArena(thor, Gustavo);
    battle.Fight();
}
}