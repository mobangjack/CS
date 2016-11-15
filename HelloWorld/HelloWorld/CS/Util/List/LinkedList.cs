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

using CS.Util.Link;

namespace CS.Util.List
{
	public class LinkedList<T> : List<T>
	{
		protected Link<T> first, last;
		protected int len;

		public LinkedList()
		{
			first = last = null;
			len = 0;
		}

		public int IndexOf(T item)
		{
			Link<T> link = first;
			for (int i = 0; i < len; i++) {
				if (link == null)
					break;
				if (item == null ? link.data == null : item.Equals(link.data))
					return i;
				link = link.Right;
				if (link == first)
					break;
			}
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

		protected Link<T> Search(int index)
		{
			if (index < 0 || index > len - 1)
				throw new System.IndexOutOfRangeException();
            Link<T> link = first;
			for (int i = 0; i < len; i++)
				if (link == null)
					break;
				if (i == index)
					return link;
				else
					link = link.next;
			return null;
		}

		protected Link<T> Search(T item)
		{
			Link<T> link = first;
			for (int i = 0; i < len; i++) {
				if (link == null)
					break;
				else if(item == null ? link.data == null : item.Equals(link.data))
					return link;
				else
					link = link.next;
			}
			return null;
		}

		public T Get(int index)
		{
			Link<T> link = Search (index);
			return link == null ? null : link.Data;
		}

		public void Set(int index, T value)
		{
			if(index < 0 || index > len - 1)
				throw new System.IndexOutOfRangeException();
			Link<T> link = Search (index);
			T replaced = link.Data;
			link.Data = value;
			return replaced;
		}

		public void Add(int index, T item)
		{
			if (index < 0 || index > len)
				throw new System.IndexOutOfRangeException();
			Link<T> added = new Link<T> (item);
			Link<T> link = Search (index);
			if (index == 0) {
				added.Right = first;
				first.Left = added;
				first = added;
			} else if (index == len) {
				added.Left = last;
				last.Right = added;
				last = added;
			} else {
				added.Left = link.Left;
				added.Right = link;
				link.Left.Right = added;
				link.Right.Left = added;
			}
			len++;
		}

		public void Add(T item)
        {
			Link<T> link = new Link<T> (item);
			last.Right = link;
			link.Left = last;
			last = added;
			len++;
			if (first == null)
				first = link;
        }

		protected void Remove(Link<T> link)
		{
			if(link.Equals(first)) {
				first = first.Right;
				first.Left = null;
			} else if (link.Equals(last)) {
				last = last.Left;
				last.Right = null;
			} else {
				link.Left.Right = link.Right;
				link.Right.Left = link.Left;
			}
			len--;
		}

		public bool Remove(T item)
		{
			Link<T> link = Search (item);
			if (link == null)
				return false;
			Remove (link);
			return true;
		}

		public T Remove(int index)
		{
			Link<T> link = Search (index);
			Remove (link);
			return link.Data;
		}

		public T[] ToArray()
		{
			Link<T> link = first;
			T[] _arr = new T[len];
			for (int i = 0; i < len; link = link.Right, i++)
				_arr [i] = link.Data;
			return _arr;
		}
	}
}

