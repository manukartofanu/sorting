using Sorting;
using System;
using Xunit;

namespace SortingTest
{
	public class SortingTest
	{
		[Theory]
		[InlineData(typeof(BubbleSort))]
		[InlineData(typeof(InsertionSort))]
		[InlineData(typeof(CocktailShakerSort))]
		public void NullArray(Type sorting)
		{
			int[] initial = null;
			Exception ex = Assert.Throws<ArgumentNullException>(() => AssertAfterSort(sorting, initial, null));
			Assert.Equal($"Value cannot be null.{Environment.NewLine}Parameter name: array", ex.Message);
		}

		[Theory]
		[InlineData(typeof(BubbleSort))]
		[InlineData(typeof(InsertionSort))]
		[InlineData(typeof(CocktailShakerSort))]
		public void EmptyArray(Type sorting)
		{
			int[] initial = new int[0];
			int[] sorted = new int[0];
			AssertAfterSort(sorting, initial, sorted);
		}

		[Theory]
		[InlineData(typeof(BubbleSort))]
		[InlineData(typeof(InsertionSort))]
		[InlineData(typeof(CocktailShakerSort))]
		public void ReverseArray(Type sorting)
		{
			int[] initial = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			int[] sorted = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			AssertAfterSort(sorting, initial, sorted);
		}

		[Theory]
		[InlineData(typeof(BubbleSort))]
		[InlineData(typeof(InsertionSort))]
		[InlineData(typeof(CocktailShakerSort))]
		public void EqualArray(Type sorting)
		{
			int[] initial = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			int[] sorted = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			AssertAfterSort(sorting, initial, sorted);
		}

		[Theory]
		[InlineData(typeof(BubbleSort))]
		[InlineData(typeof(InsertionSort))]
		[InlineData(typeof(CocktailShakerSort))]
		public void RandomArray(Type sorting)
		{
			int[] initial = new int[] { 99, 5, 7, 3, 5 };
			int[] sorted = new int[] { 3, 5, 5, 7, 99 };
			AssertAfterSort(sorting, initial, sorted);
		}

		private void AssertAfterSort(Type sorting, int[] initial, int[] sorted)
		{
			object sortingInstance = Activator.CreateInstance(sorting);
			((ISorting)sortingInstance).Sort(initial);
			Assert.Equal(sorted, initial);
		}
	}
}
