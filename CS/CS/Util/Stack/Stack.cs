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

namespace CS.Util.Stack
{
	public class Stack<T> : AbstractContainer<T>
	{
		protected T[] arr;

		public Stack(int initialCapacity) : base()
		{
			arr = new T[initialCapacity];
		}

		public int Capacity
		{
			get { return arr.Length; }
			set { arr = Array.Enlarge (arr, value); }
		}

		public void Push(T item)
		{
			if (cnt > arr.Length - 1)
				Capacity *= 2;
			arr [cnt++] = item;
		}

		public T Pop()
		{
			return arr [--cnt];
		}

		public override IIterator<T> Iterator()
		{
			return Array.Iterator (Array.ReverseOfRange (arr, 0, cnt));
		}
	}
}
