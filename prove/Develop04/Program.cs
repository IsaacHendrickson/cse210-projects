using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();
        int input = 0;
        BreathingActivity breathingActivity = new("Breathing Activity", "An activity to help you breathe");
        ListingActivity listingActivity = new("Listing Activity", "An activity to help you list");
        ReflectionActivity reflectionActivity = new("Reflection Activity", "An activity to help you reflect");

        while(input != 4)
        {
            input = menu.DisplayMenu();
            if(input == 1)
            {
                breathingActivity.Run();
            }else if(input == 2)
            {
                reflectionActivity.Run();
            }else if(input == 3)
            {
                listingActivity.Run();
            }
        }
    }
}