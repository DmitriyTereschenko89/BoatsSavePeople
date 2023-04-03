namespace BoatsSavePeople
{
    internal class Program
    {
        public class BoatsSavePeople
        {
            public int NumRescueBoats(int[] people, int limit)
            {
                Array.Sort(people);
                int numRescueBoats = 0;
                int l = 0;
                int r = people.Length - 1;
                while (l <= r)
                {
                    ++numRescueBoats;
                    if (people[l] + people[r] <= limit)
                    {
                        ++l;
                    }
                    --r;
                }
                return numRescueBoats;
            }
        }
        static void Main(string[] args)
        {
            BoatsSavePeople boatsSavePeople = new();
            Console.WriteLine(boatsSavePeople.NumRescueBoats(new int[] { 1, 2 }, 3));
            Console.WriteLine(boatsSavePeople.NumRescueBoats(new int[] { 3, 2, 2, 1 }, 3));
            Console.WriteLine(boatsSavePeople.NumRescueBoats(new int[] { 3, 5, 3, 4 }, 5));
            Console.WriteLine(boatsSavePeople.NumRescueBoats(new int[] { 5, 1, 4, 2 }, 6));
            Console.WriteLine(boatsSavePeople.NumRescueBoats(new int[] { 21, 40, 16, 24, 30 }, 50));
        }
    }
}