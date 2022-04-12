using System;

static class AssemblyLine
{
    const int baseCarsProductionRatePerHour = 221;
    public static double SuccessRate(int speed)
    {
        switch (speed)
        {
            case 0: 
                return 0.00;
                break;
            case <= 4: 
                return 1.00;
                break;
            case <= 8: 
                return 0.90;
                break;
            case 9: 
                return 0.80;
                break;
            case 10: 
                return 0.77;
                break;
            default:
                return 0.00;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return baseCarsProductionRatePerHour * speed * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)(ProductionRatePerHour(speed) / 60.00);
    }
}
