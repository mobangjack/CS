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

using CS.Util.Queue;

namespace CS.Util.Tree
{
	public class BinaryTree<T>
	{
		private T data;
		private BinaryTree<T> parent, left, right;

		public BinaryTree()
		{
			data = default(T);
			left = right = null;
		}

		public BinaryTree(T data)
		{
			this.data = data;
			left = right = null;
		}

		public T Data
		{
			get { return data; }
			set { data = value; }
		}

		public BinaryTree<T> Parent
		{
			get { return parent; }
			set { parent = value; }
		}

		public BinaryTree<T> Left
		{
			get { return left; }
			set { left = value; }
		}

		public BinaryTree<T> Right
		{
			get { return right; }
			set { right = value; }
		}

		public void ShowByLevel()
		{
			Queue<BinaryTree<T>> queue = new Queue<BinaryTree<T>> (10);
			queue.Enqueue (this);
			while (queue.NotEmpty ()) {
				BinaryTree<T> btree = queue.Dequeue ();
				System.Console.Write (btree.Data);
				queue.Enqueue (btree.Left);
				queue.Enqueue (btree.Right);
			}
		}

		public void ShowPreOrder()
		{
			System.Console.Write (data);
			if(left != null)
			{
				left.ShowPreOrder ();
			}
			System.Console.Write (left.Data);
			if(right != null)
			{
				right.ShowPreOrder();
			}
			System.Console.Write (right.Data);
		}

		public void ShowMidOrder()
		{
			System.Console.Write (left.Data);
			if(left != null)
			{
				left.ShowMidOrder();
			}
			System.Console.Write (data);
			if(right != null)
			{
				right.ShowMidOrder();
			}
			System.Console.Write (right.Data);
		}

		public void ShowPostOrder()
		{
			System.Console.Write (left.Data);
			if(left != null)
			{
				left.ShowPostOrder();
			}
			System.Console.Write (right.Data);
			if(right != null)
			{
				right.ShowPostOrder();
			}
			System.Console.Write (data);
		}
	}
}

