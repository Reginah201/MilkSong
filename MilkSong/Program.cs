namespace MilkSong
{
    class MilkSong
    {
        public void Sing()
        {
            for (int bottles = 99; bottles > 0; bottles--)
            {
                if (bottles > 1)
                {
                    Console.WriteLine($"{bottles} bottles of milk on the wall, {bottles} bottles of milk.");
                    Console.WriteLine($"Take one down and pass it around, {bottles - 1} bottles of milk on the wall.\n");
                }
                else
                {
                    Console.WriteLine($"{bottles} bottle of milk on the wall, {bottles} bottle of milk.");
                    Console.WriteLine("Take one down and pass it around, no more bottles of milk on the wall.\n");
                }
            }
             
        }
    }
}