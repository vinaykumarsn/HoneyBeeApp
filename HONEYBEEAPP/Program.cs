


using HONEYBEEAPP;

List<Bee> BeeList = new List<Bee>();


Bee wBee = new Worker();
Bee qBee = new Queen();
Bee dBee = new Drone();

bool allDead = false;
while (!allDead)
{
    Random rand = new Random();
    int randNum = rand.Next(0, 100);
    wBee.Damage(randNum);

    randNum = rand.Next(0, 100);
    qBee.Damage(randNum);

    randNum = rand.Next(0, 100);
    dBee.Damage(randNum);

    if (wBee.Dead && qBee.Dead && dBee.Dead)
        allDead = true;

    Console.WriteLine("BeeType - " + wBee.BeeType + " BeeHealth - " + wBee.Health + " DeadStatus - " + wBee.Dead);
    Console.WriteLine("BeeType - " + qBee.BeeType + " BeeHealth - " + qBee.Health + " DeadStatus - " + qBee.Dead);
    Console.WriteLine("BeeType - " + dBee.BeeType + " BeeHealth - " + dBee.Health + " DeadStatus - " + dBee.Dead);

}



Console.ReadLine();