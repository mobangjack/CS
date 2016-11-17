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
	public class LinkedList<T>
	{
		public class Node
		{
			private T data;
			private Node left, right;

			public Node()
			{
				data = default(T);
				left = right = default(Node);
			}

			public Node(T data)
			{
				this.data = data;
				left = right = null;
			}

			public T Data
			{
				get { return data; }
				set { data = value; }
			}

			public Node Left
			{
				get { return left; }
				set { left = value; }
			}

			public Node Right
			{
				get { return right; }
				set { right = value; }
			}
		}

		private Node first, last;
		private int len;

		public LinkedList()
		{
			first = last = null;
			len = 0;
		}

		public int IndexOf(T item)
		{
			Node node = first;
			for (int i = 0; i < len && node != null; i++, node = node.Right)
				if (item == null ? node.Data == null : item.Equals(node.Data))
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

		private Node NodeAt(int index)
		{
            Node node = first;
			for (int i = 0; i < len && node != null; i++, node = node.Right)
				if (i == index)
					return node;
			return null;
		}

		private Node NodeOf(T item)
		{
			Node node = first;
			for (int i = 0; i < len && node != null; i++, node = node.Right)
				if(item == null ? node.Data == null : item.Equals(node.Data))
					return node;
			return null;
		}

		private void IndexRangeCheck(int index, int max)
		{
			if (index < 0 || index > max)
				throw new System.IndexOutOfRangeException();
		}

		public T Get(int index)
		{
			IndexRangeCheck (index, len - 1);
			Node node = NodeAt (index);
			return node == null ? default(T) : node.Data;
		}

		public T Set(int index, T value)
		{
			IndexRangeCheck (index, len - 1);
			Node node = NodeAt (index);
			T replaced = node.Data;
			node.Data = value;
			return replaced;
		}

		public T this[int index]
		{
			get { return Get(index); }
			set { Set (index, value); }
		}

		public void Add(int index, T item)
		{
			IndexRangeCheck (index, len);
			Node added = new Node (item);
			if (first == null)
				first = last = added;
			if (index == 0) {
				first.Left = added;
				added.Right = first;
				first = added;
			} else if (index == len) {
				last.Right = added;
				added.Left = last;
				last = added;
			} else {
				Node node = NodeAt (index);
				node.Left.Right = added;
				added.Left = node.Left;
				added.Right = node;
				node.Left = added;
			}
			len++;
		}

		public void Add(T item)
        {
			Add (len, item);
        }

		private void RemoveNode(Node node)
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
			len--;
		}

		public bool Remove(T item)
		{
			Node node = NodeOf (item);
			if (node == null)
				return false;
			RemoveNode (node);
			return true;
		}

		public T Remove(int index)
		{
			IndexRangeCheck (index, len - 1);
			Node node = NodeAt (index);
			RemoveNode (node);
			return node.Data;
		}

		public T[] ToArray()
		{
			if (first == null)
				return null;
			Node node = first;
			T[] _arr = new T[len];
			for (int i = 0; i < len; node = node.Right, i++)
				_arr [i] = node.Data;
			return _arr;
		}
	}
}

