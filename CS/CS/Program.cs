// /**
//  * Copyright (c) 2011-2016, Jack Mo 莫帮杰 (mobangjack@foxmail.com).
//  *
//  * Licensed under the Apache License, Version 2.0 (the "License");
//  * you may not use this file except in compliance with the License.
//  * You may obtain a copy of the License at
//  *
//  *      http://www.apache.org/licenses/LICENSE-2.0
//  *
//  * Unless required by applicable law or agreed to in writing, software
//  * distributed under the License is distributed on an "AS IS" BASIS,
//  * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  * See the License for the specific language governing permissions and
//  * limitations under the License.
//  */
//
//

using CS.Util.List;
using CS.Util.Stack;
using CS.Util.Queue;
using CS.Util.Tree;

namespace CS
{
	class Test
	{
		public static void TestArrayList()
		{
			ArrayList<string> list = new ArrayList<string> (10);
			list.Add ("1.Linear: One to One");
			list.Add ("2.Tree: One to Many");
			list.Add ("3.Map: Many to Many");
			for (int i = 0; i < list.Size (); i++) {
				System.Console.WriteLine (list.Get (i));
			}
		}

		public static void TestLinkedList()
		{
			LinkedList<string> list = new LinkedList<string> ();
			list.Add ("1.Linear: One to One");
			//list.Add ("2.Tree: One to Many");
			//list.Add ("3.Map: Many to Many");
			for (int i = 0; i < list.Size (); i++) {
				System.Console.WriteLine (list.Get (i));
			}
		}

		public static void TestStack()
		{
			Stack<string> stack = new Stack<string> (10);
			stack.Push ("1.Linear: One to One");
			stack.Push ("2.Tree: One to Many");
			stack.Push ("3.Map: Many to Many");
			while(stack.NotEmpty()) {
				System.Console.WriteLine (stack.Pop());
			}
		}

		public static void TestQueue()
		{
			Queue<string> queue = new Queue<string> (10);
			queue.Enqueue ("1.Linear: One to One");
			queue.Enqueue ("2.Tree: One to Many");
			queue.Enqueue ("3.Map: Many to Many");
			while(queue.NotEmpty()) {
				System.Console.WriteLine (queue.Dequeue());
			}
		}

		public static void TestBinaryTree()
		{
			BinaryTree<string> L00 = new BinaryTree<string> ("L0-0");
			BinaryTree<string> L11 = new BinaryTree<string> ("L1-1");
			BinaryTree<string> L12 = new BinaryTree<string> ("L1-2");

			L00.Left = L11;
			L00.Right = L12;

			L11.Parent = L00;
			L12.Parent = L00;

			BinaryTree<string> L23 = new BinaryTree<string> ("L2-3");
			BinaryTree<string> L24 = new BinaryTree<string> ("L2-4");
			BinaryTree<string> L25 = new BinaryTree<string> ("L2-5");
			BinaryTree<string> L26 = new BinaryTree<string> ("L2-6");

			L11.Left = L23;
			L11.Right = L24;

			L23.Parent = L11;
			L24.Parent = L11;

			L12.Left = L25;
			L12.Right = L26;

			L25.Parent = L12;
			L26.Parent = L12;

			System.Console.WriteLine ("PreOrder Traversal");
			L00.ShowPreOrder ();
			System.Console.WriteLine ();

			System.Console.WriteLine ("MidOrder Traversal");
			L00.ShowMidOrder ();
			System.Console.WriteLine ();

			System.Console.WriteLine ("PostOrder Traversal");
			L00.ShowPostOrder ();
			System.Console.WriteLine ();

			System.Console.WriteLine ("Level Traversal");
			L00.ShowByLevel ();
			System.Console.WriteLine ();
		}

		public static void Main (string[] args)
		{
			//TestArrayList ();
			//TestLinkedList ();
			//TestStack ();
			//TestQueue ();
			TestBinaryTree ();
		}

	}
}
