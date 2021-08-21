using System;

namespace Sorting
{
	public class BubbleSort : ISorting
	{
		public void Sort(int[] array)
		{
			if (array == null )
			{
				throw new ArgumentNullException(nameof(array));
			}
			for (int i = 0; i < array.Length - 1; ++i)
			{
				bool exit = true;
				for (int j = 0; j < array.Length - i - 1; ++j)
				{
					if (array[j] > array[j + 1])
					{
						int swap = array[j];
						array[j] = array[j + 1];
						array[j + 1] = swap;
						exit = false;
					}
				}
				if (exit)
				{
					break;
				}
			}
		}
	}
}
