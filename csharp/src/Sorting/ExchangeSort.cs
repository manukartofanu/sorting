using System;

namespace Sorting
{
	public class ExchangeSort : ISorting
	{
		public void Sort(int[] array)
		{
			if (array == null)
			{
				throw new ArgumentNullException(nameof(array));
			}
			for (int i = 0; i < array.Length; ++i)
			{
				for (int j = i + 1; j < array.Length; ++j)
				{
					if (array[i] > array[j])
					{
						int swap = array[i];
						array[i] = array[j];
						array[j] = swap;
					}
				}
			}
		}
	}
}
