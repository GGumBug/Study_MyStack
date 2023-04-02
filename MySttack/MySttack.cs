using System;
namespace MySttack
{
	public class MySttack<T>
	{
		private T[] elements;
		private int rear;

		public MySttack(int size)
		{
			elements = new T[size];
			rear = -1;
		}

		public void Push(T item)
		{
			if(rear >= elements.Length)
			{
				Console.WriteLine("Sttack overflow");
				return;
			}

			elements[++rear] = item;
		}

		public T Pop()
		{
			if (rear < 0)
			{
				Console.WriteLine("Sttack underflow");
				return default(T);
			}

			T itme = elements[rear];
			elements[rear--] = default(T);

			return itme;

        }

		public void Print()
		{
			if (rear < 0)
			{
				Console.WriteLine("Sttack is Empty");
				return;
			}

			for (int i = 0; i < elements.Length; i++)
			{
				Console.Write($"{elements[i]} ");
			}
			Console.WriteLine();
		}
	}
}

