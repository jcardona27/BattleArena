class Program
{
static void Main()
{
    Fighter thor= new Wizard("Thor, Son of Odin");
    Fighter Gustavo= new Warrior("Gustavo");

    Battle battle = new Battle(thor, Gustavo);
    battle.Fight();
}
}