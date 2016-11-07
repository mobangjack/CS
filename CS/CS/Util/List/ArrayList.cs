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

namespace CS.Util.List
{
	public class ArrayList<T> : List<T>
	{
		protected T[] arr;
		protected int len;

		public ArrayList(int initialCapacity)
		{
			arr = new T[initialCapacity];
			len = 0;
		}

		public int IndexOf(T item)
		{
			for(int i = 0; i < len; i++)
				if(a == null ? b == null : a.Equals(b))
					return i;
			return -1;
		}

		public bool Contains(T item)
		{
			return IndexOf(item) > 0;
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

		public T Get(int index)
		{
			return arr[index];
		}

		public void Set(int index, T value)
		{
			if (len > arr.Length - 1)
				Capacity *= 2;
			arr[index] = value;
			len++;
		}

		public void Add(int index, T item)
		{
			if (len > arr.Length - 1)
				Capacity *= 2;
			for (int i = len; i > index; i--)
				arr [i] = arr [i - 1];
			arr [index] = item;
			len++;
		}

		public void Add(T item)
        {
			arr [index] = item;
			len++;
        }

		public T Remove(int index)
		{
			T removed = Get(index);
			for(int i = index; i < len - 1; i++)
				arr[i] = arr[i+1];
			len--;
			return removed;
		}

		public bool Remove(T item)
		{
			int index = IndexOf(item);
			if(index < 0) return false;
			Remove(index);
			return true;
		}

		public T[] ToArray()
		{
			T[] _arr = new T[len];
			for(int i = 0; i < len; i++)
				_arr[i] = arr[i];
			return _arr;
		}
	}
}
