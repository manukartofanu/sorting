using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
	public class CocktailShakerSort : ISorting
	{
		public void Sort(int[] array)
		{
			if (array == null)
			{
				throw new ArgumentNullException(nameof(array));
			}
			bool hadSwap;
			int iteration = 0;
			do
			{
				hadSwap = false;
				for (int i = iteration; i < array.Length - 1; ++i)
				{
					if (array[i] > array[i + 1])
					{
						int swap = array[i + 1];
						array[i + 1] = array[i];
						array[i] = swap;
						hadSwap = true;
					}
				}
				for (int i = array.Length - iteration - 1; i > iteration; --i)
				{
					if (array[i] < array[i - 1])
					{
						int swap = array[i - 1];
						array[i - 1] = array[i];
						array[i] = swap;
						hadSwap = true;
					}
				}
				iteration++;
			} while (hadSwap);
		}
	}
}
