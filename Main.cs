class Program
{
static void Main()
{
    Fighter thor= new Viking("Thor, Son of Odin");
    Fighter Gustavo= new Caveman("Gustavo");

    BattleArena battle = new BattleArena(thor, Gustavo);
    battle.Fight();
}
}