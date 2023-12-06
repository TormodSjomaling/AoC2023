using Day_6;

var exampleRaces = new List<Race>()
{
    new() { RaceNumber = 1, Time = 71530, Distance = 940200 }
};

var races = new List<Race>()
{
    new() { RaceNumber = 1, Time = 58819676, Distance = 434104122191218 }
};
    
int PartOneAndTwo(List<Race> races)
{
    var sum = 1;

    foreach (var race in races)
    {
        var numberOfWaysToWin = 0;

        for (var i = 0;  i< race.Time+1; i++)
        {
            var chargeTime = i;
            var remainingRaceTime = race.Time - chargeTime;

            var distanceTraveled = chargeTime * remainingRaceTime;

            if (distanceTraveled > race.Distance)
            {
                numberOfWaysToWin++;
            }
        }
    
        sum *= numberOfWaysToWin;
    }

    return sum;
}

Console.WriteLine(PartOneAndTwo(races));
