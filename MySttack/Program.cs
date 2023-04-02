using System;
namespace MySttack
{
	public class Program
	{
		static void Main(string[] args)
		{
			MySttack<int> mySttack = new MySttack<int>(5);

			mySttack.Push(1);
            mySttack.Push(2);
            mySttack.Push(3);
            mySttack.Push(4);
            mySttack.Push(5);
			mySttack.Pop();
            mySttack.Pop();
            mySttack.Pop();
            mySttack.Pop();
            mySttack.Push(5);
            mySttack.Push(5);
            mySttack.Push(5);

            mySttack.Print();
        }
	}
}

