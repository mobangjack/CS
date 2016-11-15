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

		protected Node first, last;
		protected int len;

		public LinkedList()
		{
			first = last = null;
			len = 0;
		}

		public int IndexOf(T item)
		{
			Node node = first;
			for (int i = 0; i < len; i++) {
				if (node == null)
					break;
				if (item == null ? node.Data == null : item.Equals(node.Data))
					return i;
				node = node.Right;
				if (node == first)
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

		protected Node Search(int index)
		{
			if (index < 0 || index > len - 1)
				throw new System.IndexOutOfRangeException();
            Node node = first;
			for (int i = 0; i < len; i++)
				if (node == null)
					break;
				else if (i == index)
					return node;
				else
					node = node.Right;
			return null;
		}

		protected Node Search(T item)
		{
			Node node = first;
			for (int i = 0; i < len; i++) {
				if (node == null)
					break;
				else if(item == null ? node.Data == null : item.Equals(node.Data))
					return node;
				else
					node = node.Right;
			}
			return null;
		}

		public T Get(int index)
		{
			Node node = Search (index);
			return node == null ? default(T) : node.Data;
		}

		public void Set(int index, T value)
		{
			if(index < 0 || index > len - 1)
				throw new System.IndexOutOfRangeException();
			Node node = Search (index);
			node.Data = value;
		}

		public void Add(int index, T item)
		{
			if (index < 0 || index > len)
				throw new System.IndexOutOfRangeException();
			Node added = new Node (item);
			Node node = Search (index);
			if (index == 0) {
				added.Right = first;
				first.Left = added;
				first = added;
			} else if (index == len) {
				added.Left = last;
				last.Right = added;
				last = added;
			} else {
				added.Left = node.Left;
				added.Right = node;
				node.Left.Right = added;
				node.Right.Left = added;
			}
			len++;
		}

		public void Add(T item)
        {
			Add (len, item);
        }

		protected void Remove(Node node)
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
			Node node = Search (item);
			if (node == null)
				return false;
			Remove (node);
			return true;
		}

		public T Remove(int index)
		{
			Node node = Search (index);
			Remove (node);
			return node.Data;
		}

		public T[] ToArray()
		{
			Node node = first;
			T[] _arr = new T[len];
			for (int i = 0; i < len; node = node.Right, i++)
				_arr [i] = node.Data;
			return _arr;
		}
	}
}

