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
	public class BinaryTree<T> : DataBox<T>
	{
		private BinaryTree<T> parent, left, right;

		public BinaryTree()
		{
			data = default(T);
			parent = left = right = null;
		}

		public BinaryTree(T data)
		{
			this.data = data;
			parent = left = right = null;
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

		public void ShowPreOrder()
		{
			System.Console.Write (data);
			if(left != null)
				left.ShowPreOrder ();
			if(right != null)
				right.ShowPreOrder();
		}

		public void ShowMidOrder()
		{
			if(left != null)
				left.ShowMidOrder();
			System.Console.Write (data);
			if(right != null)
				right.ShowMidOrder();
		}

		public void ShowPostOrder()
		{
			if(left != null)
				left.ShowPostOrder();
			if(right != null)
				right.ShowPostOrder();
			System.Console.Write (data);
		}

		public void ShowByLevel()
		{
			Queue<BinaryTree<T>> queue = new Queue<BinaryTree<T>> (10);
			queue.Enqueue (this);
			while (queue.NotEmpty ()) {
				BinaryTree<T> btree = queue.Dequeue ();
				if (btree == null)
					continue;
				System.Console.Write (btree.Data);
				queue.Enqueue (btree.Left);
				queue.Enqueue (btree.Right);
			}
		}

		public int Level()
		{
			if (parent == null)
				return 0;
			else
				return 1 + parent.Level ();
		}

		public int Depth()
		{
			if (left == null && right == null)
				return 0;
			else if (left != null && right != null)
				return 1 + System.Math.Max(left.Depth(), right.Depth());
			else if (left != null)
				return 1 + left.Depth ();
			else
				return 1 + right.Depth ();
		}

		public int Size()
		{
			if (left == null && right == null)
				return 1;
			else if (left != null && right != null)
				return 1 + left.Size() + right.Size();
			else if (left != null)
				return 1 + left.Size ();
			else
				return 1 + right.Size ();
		}

		public bool IsFull()
		{
			if (left == null && right == null)
				return true;
			else if (left != null && right != null)
				return left.IsFull () && right.IsFull ();
			else
				return false;
		}

		public override string ToString()
		{
			string s = data == null ? null : data.ToString();
			for (int i = 0; i < Level (); i++)
				s = "   " + s;
			if (left == null && right == null)
				return s;
			else if (left != null && right != null)
				return s + "\n" + left.ToString() + "\n" + right.ToString();
			else if (left != null)
				return s + "\n" + left.ToString ();
			else
				return s + "\n" + right.ToString ();
		}
	}
}

