﻿using Day2;

var config = new Config
{
    RedCubes = 12,
    GreenCubes = 13,
    BlueCubes = 14
};

const string testText = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\n" +
                        "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\n" +
                        "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\n" +
                        "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\n" +
                        "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";
const string text =
    "Game 1: 4 blue, 7 red, 5 green; 3 blue, 4 red, 16 green; 3 red, 11 green\nGame 2: 20 blue, 8 red, 1 green; 1 blue, 2 green, 8 red; 9 red, 4 green, 18 blue; 2 green, 7 red, 2 blue; 10 blue, 2 red, 5 green\nGame 3: 2 red, 5 green, 1 blue; 3 blue, 5 green; 8 blue, 13 green, 2 red; 9 green, 3 blue; 12 green, 13 blue; 3 green, 3 blue, 1 red\nGame 4: 1 red, 6 green, 4 blue; 3 green, 1 blue, 1 red; 7 blue, 1 red, 2 green\nGame 5: 2 green, 9 blue, 1 red; 3 green, 1 blue, 3 red; 1 red, 4 blue, 9 green\nGame 6: 2 blue, 5 red, 7 green; 5 blue, 8 red, 3 green; 2 red, 9 blue, 2 green\nGame 7: 7 green, 7 blue, 2 red; 2 red, 7 green, 16 blue; 17 blue, 3 green, 3 red; 2 blue, 5 green, 3 red\nGame 8: 4 red, 3 green; 9 green, 2 red, 2 blue; 1 red, 3 blue, 6 green\nGame 9: 5 red, 3 green, 13 blue; 11 red, 15 blue, 1 green; 7 red, 2 blue\nGame 10: 15 red, 3 green; 7 green, 4 blue, 11 red; 13 red, 13 blue; 2 blue, 5 green, 8 red\nGame 11: 7 red, 3 green; 7 blue, 16 red, 4 green; 6 green, 6 blue, 12 red; 11 red, 4 green, 4 blue; 10 red, 6 blue, 2 green; 3 green, 7 red, 6 blue\nGame 12: 1 blue, 2 red; 2 green, 15 blue; 6 green, 5 blue; 6 blue, 4 green; 5 blue, 3 green; 3 red, 3 blue, 10 green\nGame 13: 10 red, 4 green; 9 red, 2 blue, 3 green; 6 red, 7 green, 1 blue; 9 red, 7 green, 1 blue; 3 blue; 3 blue, 3 red, 8 green\nGame 14: 12 blue, 3 red, 4 green; 3 green, 1 red; 6 green, 16 blue\nGame 15: 2 green, 3 red, 2 blue; 14 blue, 1 red, 17 green; 13 blue, 11 green, 10 red; 5 green, 7 red, 5 blue; 2 green, 3 blue, 6 red; 9 green, 2 blue, 5 red\nGame 16: 2 blue, 1 red; 1 red, 2 green, 3 blue; 4 green, 9 blue, 3 red; 1 green, 4 red, 8 blue; 7 blue, 11 red, 1 green\nGame 17: 9 green, 8 blue, 6 red; 8 red, 18 green, 1 blue; 18 red, 19 green, 1 blue\nGame 18: 1 green, 4 red, 5 blue; 10 green, 8 blue; 12 green, 10 blue\nGame 19: 3 red, 11 green, 12 blue; 16 green, 1 red, 20 blue; 9 green, 2 red, 14 blue; 5 blue, 2 green, 2 red; 20 blue, 3 red, 10 green; 4 green, 3 blue\nGame 20: 17 red, 3 blue, 9 green; 6 green, 1 red, 7 blue; 6 red, 2 blue; 1 blue, 4 green, 5 red; 6 green, 5 red; 10 blue, 11 green, 2 red\nGame 21: 9 red, 4 blue, 6 green; 14 red, 9 green; 1 red, 1 blue, 12 green\nGame 22: 5 green, 4 red; 1 green, 1 red, 2 blue; 5 red, 4 green, 4 blue; 2 green, 2 blue, 5 red; 8 green, 4 blue, 16 red; 15 red, 3 green\nGame 23: 5 green, 14 red; 6 blue, 2 green, 14 red; 4 blue, 8 red, 4 green; 4 blue, 9 red, 8 green; 9 blue, 3 green\nGame 24: 13 blue, 9 green, 13 red; 11 blue, 14 red, 10 green; 12 green, 5 blue, 14 red\nGame 25: 11 green, 1 blue; 12 red, 8 green, 5 blue; 1 blue, 8 green, 6 red\nGame 26: 4 blue, 1 green; 1 green, 5 red, 6 blue; 8 green, 5 blue, 6 red; 2 blue, 2 red, 8 green; 8 green, 2 red, 4 blue; 7 red, 2 blue, 7 green\nGame 27: 8 red, 1 blue, 8 green; 5 red, 2 green; 2 blue, 9 green, 9 red; 2 blue\nGame 28: 2 green, 1 blue; 2 green; 1 blue; 1 blue, 1 red; 1 blue; 1 green\nGame 29: 12 red, 8 green, 13 blue; 13 green, 15 red; 12 red, 18 green, 10 blue; 7 green, 20 red, 5 blue; 20 red, 7 green, 10 blue; 9 green, 13 blue\nGame 30: 5 red, 3 blue; 2 red; 2 green, 6 blue, 7 red; 5 red\nGame 31: 14 red, 7 blue, 2 green; 1 green, 11 red, 9 blue; 3 red, 2 green, 5 blue; 1 green, 9 blue, 8 red; 8 blue, 8 red, 1 green\nGame 32: 2 green, 6 blue, 2 red; 2 blue, 4 red; 1 green, 9 blue, 1 red; 3 red, 13 blue, 1 green\nGame 33: 6 green, 8 blue, 7 red; 3 blue, 1 green, 8 red; 6 red, 11 blue; 10 blue, 3 red, 7 green; 1 blue, 3 red, 6 green\nGame 34: 1 red, 1 blue, 8 green; 5 blue, 10 red, 11 green; 2 green, 10 red, 2 blue\nGame 35: 2 blue, 15 green; 3 red, 3 blue, 6 green; 13 green, 17 red, 3 blue; 18 green, 1 blue, 18 red; 16 green, 3 blue; 11 green, 15 red\nGame 36: 16 red, 4 green, 1 blue; 8 red, 2 blue, 5 green; 5 green, 2 blue, 9 red\nGame 37: 3 green, 7 blue; 8 blue, 5 red, 6 green; 5 blue, 1 red, 13 green\nGame 38: 6 green, 6 blue; 11 blue, 8 green, 1 red; 5 blue, 16 green\nGame 39: 2 red, 4 blue, 5 green; 1 red, 2 green, 8 blue; 16 green, 15 blue, 2 red; 6 green, 16 blue, 1 red; 16 green, 18 blue, 1 red\nGame 40: 3 green, 6 blue, 7 red; 1 blue, 17 red; 4 green, 6 red; 13 red\nGame 41: 6 red, 5 green, 6 blue; 4 green, 2 blue; 6 red, 1 blue, 4 green; 4 blue, 13 green; 3 blue, 2 red; 2 blue, 5 red, 3 green\nGame 42: 8 red, 5 blue; 15 blue, 13 red, 3 green; 6 red, 18 blue, 4 green\nGame 43: 5 red, 1 green, 1 blue; 2 red, 2 green, 3 blue; 4 blue, 3 red, 1 green\nGame 44: 6 blue, 12 green; 7 blue, 12 red, 11 green; 12 green, 2 blue, 13 red; 8 green, 8 blue, 12 red\nGame 45: 18 blue, 15 red, 8 green; 17 red, 3 blue; 1 green, 2 red, 15 blue\nGame 46: 3 blue, 2 green, 5 red; 11 blue, 2 green, 19 red; 3 green, 19 red, 13 blue\nGame 47: 9 green, 2 red; 7 red, 10 green; 2 blue, 9 green, 1 red; 5 blue\nGame 48: 8 blue, 8 green; 1 red, 17 green; 9 green, 6 red, 8 blue; 13 green, 3 red, 1 blue\nGame 49: 17 blue, 2 red, 1 green; 12 blue, 1 green, 4 red; 1 green, 2 red, 13 blue\nGame 50: 4 red, 2 blue, 9 green; 8 green, 2 blue, 6 red; 9 green, 2 blue, 14 red\nGame 51: 6 red, 3 green, 8 blue; 5 green, 16 blue, 1 red; 2 green, 13 red, 14 blue; 14 red, 12 green, 19 blue; 19 blue, 13 green, 9 red; 6 red, 15 blue, 7 green\nGame 52: 18 blue, 2 red, 5 green; 2 green, 5 red; 6 red, 10 green, 3 blue; 3 green, 6 blue, 6 red\nGame 53: 11 red, 4 green; 2 blue, 3 red; 3 blue, 13 red, 11 green; 11 blue, 8 red, 5 green\nGame 54: 4 green, 1 red, 7 blue; 4 green, 8 red, 8 blue; 4 red, 5 green; 8 blue, 4 green, 2 red; 4 green, 3 blue; 3 blue, 3 green, 3 red\nGame 55: 9 red, 1 green, 1 blue; 1 green, 8 red; 4 red; 7 blue, 7 green; 6 blue, 5 green, 6 red; 5 blue, 8 red, 4 green\nGame 56: 1 blue; 3 red, 2 blue; 1 red, 2 green\nGame 57: 7 green, 2 red, 5 blue; 6 green, 1 red; 1 green, 6 red; 1 red, 20 green; 1 green, 4 red, 2 blue; 15 green, 7 red\nGame 58: 3 green, 8 red, 5 blue; 2 red, 3 green; 2 blue, 2 green, 12 red; 1 blue, 3 green, 16 red; 4 blue, 9 red, 3 green\nGame 59: 2 red, 5 blue, 1 green; 2 red, 3 green; 12 red, 5 blue; 7 green, 3 blue, 4 red; 1 green, 5 blue, 14 red; 8 red, 11 green, 2 blue\nGame 60: 12 blue, 3 red, 2 green; 2 green, 6 blue, 1 red; 1 blue, 2 red, 3 green; 7 green, 1 blue, 2 red\nGame 61: 6 blue, 6 red, 7 green; 2 green, 5 red, 5 blue; 1 blue, 3 green, 15 red; 6 blue, 8 green, 14 red\nGame 62: 1 blue, 6 red, 2 green; 5 green, 5 red, 11 blue; 5 red, 6 green, 8 blue; 2 green, 17 blue; 2 red, 7 green, 5 blue; 3 blue, 5 green, 8 red\nGame 63: 6 red, 1 green, 9 blue; 7 red, 1 green, 11 blue; 3 green, 4 red; 4 green, 10 blue, 7 red; 13 blue, 11 green, 5 red; 14 green\nGame 64: 13 green, 11 red, 1 blue; 1 red, 2 green; 3 blue, 9 green, 19 red\nGame 65: 2 blue, 11 red, 3 green; 5 green, 6 red; 2 blue, 9 green, 9 red; 1 green, 5 blue, 3 red; 4 red, 4 blue, 6 green; 2 blue, 7 green, 1 red\nGame 66: 4 red, 7 blue, 3 green; 1 green, 6 blue, 7 red; 1 green, 1 red, 1 blue\nGame 67: 1 green, 8 red; 4 green, 1 blue, 3 red; 8 red, 3 green\nGame 68: 3 blue, 4 red; 1 blue, 1 green; 2 blue, 6 red, 3 green; 1 blue, 1 green, 3 red; 7 red, 1 blue, 4 green; 1 green, 2 red, 3 blue\nGame 69: 6 green, 2 blue, 3 red; 3 blue, 3 red; 1 green; 1 blue, 2 red, 8 green; 1 green, 1 red\nGame 70: 7 blue, 15 green, 3 red; 8 green, 6 blue, 5 red; 7 blue, 1 red, 3 green\nGame 71: 4 green, 3 blue, 7 red; 6 red, 6 green, 10 blue; 3 red, 9 green; 7 blue, 1 red, 13 green; 3 blue, 5 red, 11 green; 8 blue, 8 red, 5 green\nGame 72: 10 green, 4 blue; 4 blue, 8 green, 2 red; 2 red, 6 green, 6 blue; 1 red, 5 blue; 13 green, 5 blue; 8 green, 3 blue, 2 red\nGame 73: 9 blue, 1 red, 13 green; 2 red, 16 green, 6 blue; 1 red, 8 blue, 17 green; 7 green, 1 blue; 8 blue, 1 green, 1 red\nGame 74: 2 green, 2 red; 1 red, 5 blue; 7 blue, 3 green; 7 blue, 3 green, 7 red\nGame 75: 3 green, 5 blue; 2 green, 1 red, 9 blue; 17 green, 13 blue, 3 red; 3 blue, 2 red, 8 green; 7 green, 2 red, 8 blue; 1 green, 14 blue\nGame 76: 19 red; 2 blue, 20 red; 3 blue, 3 red; 20 red, 3 blue; 6 red, 4 blue, 1 green\nGame 77: 2 red, 5 green; 2 red, 2 green; 4 green; 4 green, 3 red, 3 blue; 2 red\nGame 78: 4 green, 16 red; 5 green, 2 red, 2 blue; 4 green, 2 blue, 11 red; 1 blue, 1 green, 6 red; 2 blue, 7 red\nGame 79: 8 blue, 2 green; 3 red, 3 green; 3 red, 9 blue, 4 green; 1 red, 2 blue, 4 green; 8 green, 6 red, 9 blue; 2 red, 10 blue, 9 green\nGame 80: 9 red, 17 blue, 2 green; 5 red, 1 green, 6 blue; 2 red, 20 blue; 6 red, 12 blue\nGame 81: 5 red, 4 blue, 1 green; 15 green, 8 blue, 2 red; 5 blue, 2 red, 9 green; 11 green, 1 blue, 3 red; 15 green, 1 red, 3 blue\nGame 82: 2 blue, 12 green; 12 blue, 12 green, 14 red; 4 blue, 16 green, 7 red\nGame 83: 6 blue, 7 red, 11 green; 2 red, 6 green, 4 blue; 6 blue, 1 red; 7 blue, 12 red, 13 green; 10 green, 6 blue, 10 red; 6 red, 4 green\nGame 84: 2 green, 5 red, 1 blue; 4 green, 3 blue, 2 red; 2 green, 1 red, 1 blue; 5 red, 4 blue, 4 green\nGame 85: 1 blue; 1 green, 2 red; 3 red, 11 green; 6 green, 14 red, 1 blue\nGame 86: 3 green, 1 blue, 3 red; 3 red, 6 blue, 2 green; 4 blue, 1 red; 5 blue, 4 green, 3 red; 2 blue, 3 red, 4 green; 7 blue, 2 green, 3 red\nGame 87: 1 green, 5 red, 5 blue; 6 red, 4 green, 1 blue; 2 green, 4 red, 1 blue; 7 red, 4 green, 5 blue; 3 green, 4 red, 1 blue\nGame 88: 3 blue, 18 red, 14 green; 11 red, 14 green; 2 blue, 10 red, 4 green\nGame 89: 5 red, 4 green; 3 red, 2 blue, 1 green; 2 blue, 4 green, 3 red; 2 green, 2 blue, 2 red\nGame 90: 14 blue, 10 red, 2 green; 11 blue, 3 red, 1 green; 5 blue, 2 green, 14 red\nGame 91: 9 blue, 4 red, 4 green; 4 red, 1 blue; 3 blue, 20 red\nGame 92: 3 red, 2 green, 7 blue; 2 green, 10 red, 8 blue; 9 red, 5 blue, 5 green; 1 blue, 2 green, 3 red; 10 red, 13 blue, 9 green; 11 blue, 7 red\nGame 93: 9 red, 2 blue, 1 green; 6 red, 2 blue, 11 green; 1 green, 1 blue, 10 red; 9 red, 8 green\nGame 94: 18 green, 3 red; 2 blue, 4 green, 12 red; 5 red, 1 blue, 13 green; 2 blue, 15 green, 7 red\nGame 95: 12 green; 1 red, 3 green, 1 blue; 13 green, 2 red, 1 blue; 9 green; 2 green, 1 blue; 1 blue, 4 green, 1 red\nGame 96: 5 red, 4 green, 2 blue; 10 red, 3 blue, 5 green; 14 blue, 11 green, 4 red; 14 green, 7 blue, 13 red; 17 red, 9 green, 6 blue; 8 red, 4 blue, 13 green\nGame 97: 3 green, 7 blue; 7 red, 4 blue; 5 blue, 6 red, 2 green\nGame 98: 9 green; 8 green, 4 blue; 6 blue, 2 red, 1 green; 4 green, 1 blue; 5 blue, 2 green, 2 red\nGame 99: 3 red, 1 green, 5 blue; 1 red; 3 blue, 4 red; 3 blue, 1 green, 5 red\nGame 100: 3 red, 3 blue, 10 green; 3 green, 1 blue, 6 red; 5 red, 4 green, 7 blue";

Record MapToRecord(string text)
{
    var stringSeparators = new [] { "\n" };
    var lines = text.Split(stringSeparators, StringSplitOptions.None);

    var record = new Record()
    {
        Games = new List<Game>()
    };
    
    foreach (var line in lines)
    {
        var seperators = new [] { ":", ";" };
        var gameString = line.Split(seperators, StringSplitOptions.None).ToList();
        var game = new Game()
        {
            Id = gameString[0],
            GameResults = new List<List<Tuple<int, string>>>()
        };
        gameString.RemoveAt(0);
        
        foreach (var entry in gameString)
        {
            var entry2 = entry.Split(",");
            var subsetOfCubes = new List<Tuple<int, string>>();
            foreach (var x in entry2)
            {
                var number = new string(x.Where(char.IsDigit).ToArray());
                var color = x.Replace(number, "").Trim();
                var tuple = new Tuple<int, string>(int.Parse(number), color);
                subsetOfCubes.Add(tuple);
            }
            game.GameResults.Add(subsetOfCubes);
        }
        record.Games.Add(game);
    }

    return record;
}    
    
int PartOne(Config config, Record record)
{
    var sum = record.Games.Sum(b => int.Parse(b.Id.Where(char.IsDigit).ToArray()));
    var skip = false;
    
    foreach (var game in record.Games)
    {
        skip = false;
        foreach (var gameResults in game.GameResults)
        {
            if(skip) continue;
            foreach (var g in gameResults)
            {
                if (skip) continue;
                switch (g.Item2)
                {
                    case "red":
                        if (g.Item1 > config.RedCubes)
                        {
                            sum -= int.Parse(game.Id.Where(char.IsDigit).ToArray());
                            skip = true;
                        }
                        break;
                    case "green":
                        if (g.Item1 > config.GreenCubes)
                        {
                            sum -= int.Parse(game.Id.Where(char.IsDigit).ToArray());
                            skip = true;
                        }
                        break;
                    case "blue":
                        if (g.Item1 > config.BlueCubes)
                        {
                            sum -= int.Parse(game.Id.Where(char.IsDigit).ToArray());
                            skip = true;
                        }
                        break;
                }
            }
        }
    }

    return sum;
}

int FindMinConfigNumber(Game game)
{
    var config = new Config()
    {
        BlueCubes = 0,
        RedCubes = 0,
        GreenCubes = 0
    };
    
    foreach (var result in game.GameResults)
    {
        foreach (var subsetResult in result)
        {
            switch (subsetResult.Item2)
            {
                case "red":
                    if (subsetResult.Item1 > config.RedCubes)
                    {
                        config.RedCubes = subsetResult.Item1;
                    }
                    break;
                
                case "green":
                    if (subsetResult.Item1 > config.GreenCubes)
                    {
                        config.GreenCubes = subsetResult.Item1;
                    }
                    break;
                
                case "blue":
                    if (subsetResult.Item1 > config.BlueCubes)
                    {
                        config.BlueCubes = subsetResult.Item1;
                    }
                    break;
            }
        }
    }

    var sum = config.BlueCubes * config.GreenCubes * config.RedCubes;
    
    return sum;
}

int PartTwo(Record record)
{
    var sum = 0;

    foreach (var game in record.Games)
    {
        sum += FindMinConfigNumber(game);
    }
    
    return sum;
}


Console.WriteLine(PartOne(config, MapToRecord(text)));
Console.WriteLine(PartTwo(MapToRecord(text)));
