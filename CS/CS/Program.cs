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
using CS.Util.Matrix;
using CS.Util.Graph;

namespace CS
{
	class Test
	{
		public static void TestArrayList()
		{
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestArrayList***********************");
			System.Console.WriteLine ();

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
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestLinkedList***********************");
			System.Console.WriteLine ();

			LinkedList<string> list = new LinkedList<string> ();
			list.Add ("1.Linear: One to One");
			list.Add ("2.Tree: One to Many");
			list.Add ("3.Map: Many to Many");
			for (int i = 0; i < list.Size (); i++) {
				System.Console.WriteLine (list.Get (i));
			}
		}

		public static void TestStack()
		{
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestStack***********************");
			System.Console.WriteLine ();

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
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestQueue***********************");
			System.Console.WriteLine ();

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
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestBinaryTree***********************");
			System.Console.WriteLine ();

			/*******************************************/
			/*                   A                     */
			/*                 /  \                    */
			/*               B     C                   */
			/*              / \   / \                  */
			/*             D  E  F  G                  */
			/*******************************************/

			BinaryTree<string> A = new BinaryTree<string> ("A");
			BinaryTree<string> B = new BinaryTree<string> ("B");
			BinaryTree<string> C = new BinaryTree<string> ("C");
			BinaryTree<string> D = new BinaryTree<string> ("D");
			BinaryTree<string> E = new BinaryTree<string> ("E");
			BinaryTree<string> F = new BinaryTree<string> ("F");
			BinaryTree<string> G = new BinaryTree<string> ("G");

			A.Left = B;
			A.Right = C;
			B.Parent = C.Parent = A;

			B.Left = D;
			B.Right = E;
			D.Parent = E.Parent = B;

			C.Left = F;
			C.Right = G;
			F.Parent = G.Parent = C;

			System.Console.WriteLine ("Level of G");
			System.Console.WriteLine (G.Level ());
			System.Console.WriteLine ();

			System.Console.WriteLine ("Depth");
			System.Console.WriteLine (A.Depth ());
			System.Console.WriteLine ();

			System.Console.WriteLine ("Size");
			System.Console.WriteLine (A.Size ());
			System.Console.WriteLine ();

			System.Console.WriteLine ("IsFull");
			System.Console.WriteLine (A.IsFull ());
			System.Console.WriteLine ();

			System.Console.WriteLine ("ToString");
			System.Console.WriteLine (A.ToString ());
			System.Console.WriteLine ();

			System.Console.WriteLine ("PreOrder Traversal");
			A.ShowPreOrder ();
			System.Console.WriteLine ();

			System.Console.WriteLine ("MidOrder Traversal");
			A.ShowMidOrder ();
			System.Console.WriteLine ();

			System.Console.WriteLine ("PostOrder Traversal");
			A.ShowPostOrder ();
			System.Console.WriteLine ();

			System.Console.WriteLine ("Level Traversal");
			A.ShowByLevel ();
			System.Console.WriteLine ();
		}

		public static void TestSparseMatrix()
		{
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestSparseMatrix***********************");
			System.Console.WriteLine ();

			SparseMatrix matrix = new SparseMatrix ();
			for (int i = 0; i < 5; i++)
				matrix.Set (i, i, i + 1);
			
			System.Console.WriteLine ("SparseMatrix");
			System.Console.WriteLine (matrix.ToString());
			System.Console.WriteLine ();
			
		}

		public static void TestAdjacencyMatrixGraph()
		{
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestAdjacencyMatrixGraph***********************");
			System.Console.WriteLine ();

			ArrayList<AdjacencyMatrixGraph<string>.Node> nodes = new ArrayList<AdjacencyMatrixGraph<string>.Node> (4);
			for (int i = 0; i < 4; i++) {
				AdjacencyMatrixGraph<string>.Node node = new AdjacencyMatrixGraph<string>.Node ("" + (char)('A' + i));
				nodes.Add (node);
			}

			int[,] adjMat = new int[,] {
				{1, 1, 0, 0},
				{0, 1, 1, 0},
				{0, 0, 1, 1},
				{1, 0, 0, 1},
			};

			AdjacencyMatrixGraph<string> adjMatGraph = new AdjacencyMatrixGraph<string> (nodes, adjMat);
			System.Console.WriteLine (adjMatGraph);

		}

		public static void TestGraph()
		{
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestGraph***********************");
			System.Console.WriteLine ();

			ArrayList<Graph<string>.Node> nodes = new ArrayList<Graph<string>.Node> (4);
			for (int i = 0; i < nodes.Capacity; i++) {
				Graph<string>.Node node = new Graph<string>.Node ("" + (char)('A' + i));
				nodes.Add (node);
			}

			for (int i = 0; i < nodes.Capacity; i++) {
				ArrayList<Graph<string>.Node> neighbors = new ArrayList<Graph<string>.Node> (nodes.Capacity - 1);
				ArrayList<int> costs = new ArrayList<int> (nodes.Capacity - 1);
				for (int j = 0; j < nodes.Capacity - 1; j++) {
					if (!nodes [j].Equals (nodes [i])) {
						neighbors.Add (nodes [j]);
						costs.Add (j);
					}
				}
				nodes [i].Neighbors = neighbors;
				nodes [i].Costs = costs;
			}

			Graph<string> graph = new Graph<string> (nodes);
			System.Console.WriteLine (graph);

		}

		public static void Main (string[] args)
		{
			TestArrayList ();
			TestLinkedList ();
			TestStack ();
			TestQueue ();
			TestBinaryTree ();
			TestSparseMatrix();
			TestAdjacencyMatrixGraph ();
			TestGraph ();
		}

	}
}
