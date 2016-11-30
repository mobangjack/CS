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
	public class LinkedList<T> : AbstractList<T>
	{
		private LinkedNode<T> first, last;

		public LinkedList()
		{
			first = last = null;
		}

		public override int IndexOf(T item)
		{
			LinkedNode<T> node = first;
			for (int i = 0; i < cnt && node != null; i++, node = node.Right)
				if (item == null ? node.Data == null : item.Equals(node.Data))
					return i;
			return -1;
		}

		public bool Contains(T item)
		{
			return IndexOf(item) > 0;
		}

		private LinkedNode<T> NodeAt(int index)
		{
			LinkedNode<T> node = first;
			for (int i = 0; i < cnt && node != null; i++, node = node.Right)
				if (i == index)
					return node;
			return null;
		}

		private LinkedNode<T> NodeOf(T item)
		{
			LinkedNode<T> node = first;
			for (int i = 0; i < cnt && node != null; i++, node = node.Right)
				if(Equalty.Check(item, node.Data))
					return node;
			return null;
		}

		public T Get(int index)
		{
			Validator.CheckRange (index, 0, cnt - 1);
			LinkedNode<T> node = NodeAt (index);
			return node == null ? default(T) : node.Data;
		}

		public T Set(int index, T value)
		{
			Validator.CheckRange (index, 0, cnt - 1);
			LinkedNode<T> node = NodeAt (index);
			T replaced = node.Data;
			node.Data = value;
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
			LinkedNode<T> added = new LinkedNode<T> (item);
			if (first == null)
				first = last = added;
			if (index == 0) {
				first.Left = added;
				added.Right = first;
				first = added;
			} else if (index == cnt) {
				last.Right = added;
				added.Left = last;
				last = added;
			} else {
				LinkedNode<T> node = NodeAt (index);
				node.Left.Right = added;
				added.Left = node.Left;
				added.Right = node;
				node.Left = added;
			}
			cnt++;
		}

		public override void Add(T item)
        {
			Add (cnt, item);
        }

		private void RemoveNode(LinkedNode<T> node)
		{
			if(node.Equals(first)) {
				first = first.Right;
				first.Left = null;
			} else if (node.Equals(last)) {
				last = last.Left;
				last.Right = null;
			} else {
				node.Left.Right = node.Right;
				node.Right.Left = node.Left;
			}
			cnt--;
		}

		public override bool Remove(T item)
		{
			LinkedNode<T> node = NodeOf (item);
			if (node == null)
				return false;
			RemoveNode (node);
			return true;
		}

		public override T Remove(int index)
		{
			Validator.CheckRange (index, 0, cnt - 1);
			LinkedNode<T> node = NodeAt (index);
			RemoveNode (node);
			return node.Data;
		}

		public override void Clear()
		{
			first = last = null;
			cnt = 0;
		}

		public override T[] ToArray()
		{
			if (first == null)
				return null;
			LinkedNode<T> node = first;
			T[] _arr = new T[cnt];
			for (int i = 0; i < cnt; node = node.Right, i++)
				_arr [i] = node.Data;
			return _arr;
		}
			
		public override IIterator<T> Iterator()
		{
			return new LinkedNodeIterator<T> (first);
		}
	}
}

