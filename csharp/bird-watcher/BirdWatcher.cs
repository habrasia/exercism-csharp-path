using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[]{ 0, 2, 5, 3, 7, 8, 4 }; 
    }

    public int Today()
    {
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
         birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int birds = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            birds = birds + birdsPerDay[i];
            Console.WriteLine(birds);

        }
        return birds;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] >= 5)
            {
                busyDays++;
            }
        }
        return busyDays;
    }
}
