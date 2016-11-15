/**
 * Copyright (c) 2011-2016, Jack Mo 莫帮杰 (mobangjack@foxmail.com).
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace CS.Util.Stack
{
	public class Stack<T>
	{
		protected T[] arr;
		protected int len;

		public Stack(int initialCapacity)
		{
			this.arr = new T[initialCapacity];
			this.len = 0;
		}

		public int Capacity
		{
			get { return arr.Length; }
			set {
				T[] _arr = new T[value];
				for (int i = 0; i < arr.Length; i++)
					_arr [i] = arr [i];
				arr = _arr;
			}
		}

		public int Size()
		{
			return len;
		}

		public bool IsEmpty()
		{
			return len < 1;
		}

		public bool NotEmpty()
		{
			return len > 0;
		}

		public bool IsFull()
		{
			return len > arr.Length - 1;
		}

		public void Push(T item)
		{
			if (IsFull())
				Capacity *= 2;
			arr [len++] = item;
		}

		public T Pop()
		{
			return arr [len--];
		}
	}
}
