// /**
//  * Copyright (c) 2011-2016, Jack Mo 莫帮杰 (mobangjack@foxmail.com).
//  *
//  * Licensed under the Apache License, Version 2.0 (the "License");
//  * you may not use this file except in compliance with the License.
//  * You may obtain a copy of the License at
//  *
//  *      http://www.apache.org/licenses/LICENSE-2.0
//  *
//  * Unless required by applicable law or agreed to in writing, software
//  * distributed under the License is distributed on an "AS IS" BASIS,
//  * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  * See the License for the specific language governing permissions and
//  * limitations under the License.
//  */
//
//

namespace CS.Util
{
	public class Array
	{
		public static T[] CopyOf<T>(T[] arr)
		{
			return CopyOfRange (arr, 0, arr.Length);
		}

		public static T[] CopyOfRange<T>(T[] arr, int from, int to)
		{
			T[] copy = new T[to - from];
			for(int i = from; i < to; i++)
				copy [i - from] = arr [i];
			return copy;
		}

		public static T[] Reverse<T>(T[] arr)
		{
			return ReverseOfRange (arr, 0, arr.Length);
		}

		public static T[] ReverseOfRange<T>(T[] arr, int from, int to)
		{
			T[] reverse = new T[to - from];
			for (int i = from; i < to; i++)
				reverse [i - from] = arr [to - 1 - i];
			return reverse;
		}

		public static CS.Util.Iterator.IIterator<T> Iterator<T>(T[] arr)
		{
			return new CS.Util.Iterator.ArrayIterator<T> (arr, arr.Length);
		}

		public static T[] Enlarge<T>(T[] arr, int size)
		{
			T[] _arr = new T[size];
			for (int i = 0; i < arr.Length; i++)
				_arr [i] = arr [i];
			return _arr;
		}

		public static void IndexRangeCheck(int index, int max)
		{
			if (index < 0 || index > max)
				throw new System.IndexOutOfRangeException();
		}

		/**
		 * O(n^2)
		 */
		public static void BubbleSort<T>(T[] arr) where T:System.IComparable
		{
			for (int i = arr.Length - 1; i > 0; i--)
				for (int j = 0; j < i; j++)
					if (arr [j].CompareTo(arr [j + 1]) > 0) {
						T tmp = arr [j];
						arr [j] = arr [j + 1];
						arr [j + 1] = tmp;
					}
		}

		/**
		 * O(n^2)
		 */
		public static void InsertSort<T>(T[] arr) where T:System.IComparable
		{
			for (int i = 1; i < arr.Length; i++)
				for (int j = 0; j < i; j++)
					if (arr [i].CompareTo(arr [j]) < 0) {
						T tmp = arr [i];
						for (int k = i; k > j; k--)
							arr [k] = arr [k - 1];
						arr [j] = tmp;
					}
		}
		/**
		 * O(n^2)
		 */
		public static void HeapSort<T>(T[] arr) where T:System.IComparable
		{
			// todo
			for (int i = 1; i < arr.Length; i++)
				for (int j = 0; j < i; j++)
					if (arr [i].CompareTo(arr [j]) < 0) {
						T tmp = arr [i];
						for (int k = i; k > j; k--)
							arr [k] = arr [k - 1];
						arr [j] = tmp;
					}
		}


		public static int LinearSearch<T>(T[] arr, T obj, int from, int to) where T:System.IComparable
		{
			CS.Util.Validator.CheckRange (from, 0, arr.Length - 1);
			CS.Util.Validator.CheckRange (to, 0, arr.Length - 1);
			CS.Util.Validator.CheckRange (from, 0, to);
			for (int i = from; i < to; i++)
				if (CS.Util.Equalty.Equal (obj, arr [i]))
					return i;
			return -1;
		}

		public static int LinearSearch<T>(T[] arr, T obj) where T:System.IComparable
		{
			return LinearSearch(arr, obj, 0, arr.Length);
		}

		public static int BinarySearch<T>(T[] arr, T obj) where T:System.IComparable
		{
			int mid = arr.Length / 2;
			//int left = 0;
			//int right = 0;
			for (int i = 0; i < mid; i++)
				if (CS.Util.Equalty.Equal (obj, arr [i]))
					return i;
			for(int i = mid; i < arr.Length; i++)
				if (CS.Util.Equalty.Equal (obj, arr [i]))
					return i;
			return -1;
		}
	}
}

