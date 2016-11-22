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

using CS.Util.Iterator;

namespace CS.Util.List
{
	public class ArrayList<T> : AbstractList<T>
	{
		protected T[] arr;

		public ArrayList(int initialCapacity)
		{
			arr = new T[initialCapacity];
		}

		public override int IndexOf(T item)
		{
			for(int i = 0; i < cnt; i++)
				if(Equalty.Equal(item, arr[i]))
					return i;
			return -1;
		}

		public bool Contains(T item)
		{
			return IndexOf(item) > 0;
		}

		public int Capacity
		{
			get { return arr.Length; }
			set { arr = CS.Util.Array.Enlarge(arr, value); }
		}

		public T Get(int index)
		{
			Validator.CheckRange (index, 0, cnt - 1);
			return arr[index];
		}

		public T Set(int index, T value)
		{
			Validator.CheckRange (index, 0, cnt - 1);
			if (cnt > arr.Length - 1)
				Capacity *= 2;
			T replaced = arr[index];
			arr[index] = value;
			return replaced;
		}

		public override T this[int index]
		{
			get { return Get(index); }
			set { Set (index, value); }
		}

		public override void Add(int index, T item)
		{
			Validator.CheckRange (index, 0, cnt);
			if (cnt > arr.Length - 1)
				Capacity *= 2;
			for (int i = cnt; i > index; i--)
				arr [i] = arr [i - 1];
			arr [index] = item;
			cnt++;
		}

		public override void Add(T item)
        {
			Add (cnt, item);
        }

		public override T Remove(int index)
		{
			Validator.CheckRange (index, 0, cnt - 1);
			T removed = Get(index);
			for(int i = index; i < cnt - 1; i++)
				arr[i] = arr[i+1];
			cnt--;
			return removed;
		}

		public override bool Remove(T item)
		{
			int index = IndexOf(item);
			if(index < 0) return false;
			Remove(index);
			return true;
		}

		public override T[] ToArray()
		{
			return Array.CopyOfRange(arr, 0, cnt);
		}

		public override IIterator<T> Iterator()
		{
			return Array.Iterator (ToArray());
		}
	}
}
