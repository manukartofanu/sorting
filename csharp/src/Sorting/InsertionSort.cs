using System;

namespace Sorting
{
	public class InsertionSort : ISorting
	{
		public void Sort(int[] array)
		{
			if (array == null)
			{
				throw new ArgumentNullException(nameof(array));
			}
			for (int i = 1; i < array.Length; ++i)
			{
				int x = array[i];
				int j = i - 1;
				for (; j >= 0 && x < array[j]; --j)
				{
					array[j + 1] = array[j];
				}
				array[j + 1] = x;
			}
		}
	}
}
