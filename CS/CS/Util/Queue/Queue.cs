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

using CS.Util.Container;
using CS.Util.Iterator;

namespace CS.Util.Queue
{
	public class Queue<T> : AbstractContainer<T>
	{
		protected T[] arr;
		protected int r, w;

		public Queue(int initialCapacity)
		{
			arr = new T[initialCapacity];
			r = w = 0;
		}

		public int Capacity
		{
			get { return arr.Length; }
			set {
				T[] _arr = new T[value];
				for (int i = r; i != w; i = (i + 1) % arr.Length)
					_arr [i > r ? i - r : i - r + arr.Length] = arr [i];
				arr = _arr;
				w -= r;
				r = 0;
			}
		}

		public void Enqueue(T item)
		{
			if (cnt > arr.Length - 1)
				Capacity *= 2;
			arr [w] = item;
			w = (w + 1) % arr.Length;
			cnt++;
		}

		public T Dequeue()
		{
			T ret = arr [r];
			r = (r + 1) % arr.Length;
			cnt--;
			return ret;
		}

		public override void Clear ()
		{
			base.Clear ();
			r = w = 0;
		}

		public override IIterator<T> Iterator()
		{
			return Array.Iterator (Array.ReverseOfRange (arr, 0, cnt));
		}
	}
}
