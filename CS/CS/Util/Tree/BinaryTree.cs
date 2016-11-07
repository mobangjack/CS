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
using CS.Util.Iter;
using CS.Util.Queue;

namespace CS.Util.Tree
{
	public class BinaryTree<T> : Link<T>
	{
		protected BinaryTree<T> parent, left, right;

		public BinaryTree(T data, BinaryTree<T> parent, BinaryTree<T> left, BinaryTree<T> right)
		{
			this.data = data;
			this.parent = parent;
			this.left = left;
			this.right = right;
		}

		public BinaryTree(T data, BinaryTree<T> left, BinaryTree<T> right)
		{
			this (data, null, left, right);
		}

		public BinaryTree(T data)
		{
			Node (data, null, null);
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

		public void IterPreOrder(Iter<BinaryTree<T>> iter)
		{
			iter.Iter(this);
			if(left != null)
			{
				left.IterPreOrder(iter);
			}
			iter.Iter(left);
			if(right != null)
			{
				right.IterPreOrder(iter);
			}
			iter.Iter(right);
		}

		public void IterMidOrder(iter<BinaryTree<T>> iter)
		{
			iter.Iter(left);
			if(left != null)
			{
				left.IterMidOrder(iter);
			}
			iter.Iter(this);
			if(right != null)
			{
				right.IterMidOrder(iter);
			}
			iter.Iter(right);
		}

		public void IterPostOrder(iter<BinaryTree<T>> iter)
		{
			iter.Iter(left);
			if(left != null)
			{
				left.IterPostOrder(iter);
			}
			iter.Iter(right);
			if(right != null)
			{
				right.IterPostOrder(iter);
			}
			iter.Iter(this);
		}

		public void IterLevel(iter<BinaryTree<T>> iter)
		{
			Queue<T> queue = new Queue<T> (10);
			queue.Enqueue (this);
			while (queue.NotEmpty ()) {
				BinaryTree<T> node = queue.Dequeue ();
				iter.Iter (node);
				queue.Enqueue (node.left);
				queue.Enquue (node.right);
			}
		}
	}
}

