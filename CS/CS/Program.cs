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

using CS.Util;
using CS.Util.List;
using CS.Util.Stack;
using CS.Util.Queue;
using CS.Util.Tree;
using CS.Util.Matrix;
using CS.Util.Graph;
using CS.Util.Iterator;

namespace CS
{
	class Test
	{
		public static void TestArrayList()
		{
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestArrayList***********************");
			System.Console.WriteLine ();

			IList<string> list = new ArrayList<string> (10);
			list.Add ("1.Linear: One to One");
			list.Add ("2.Tree: One to Many");
			list.Add ("3.Map: Many to Many");

			IIterator<string> it = list.Iterator ();
			while(it.HasNext())
				System.Console.WriteLine (it.Next);
		}

		public static void TestLinkedList()
		{
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestLinkedList***********************");
			System.Console.WriteLine ();

			IList<string> list = new LinkedList<string> ();
			list.Add ("1.Linear: One to One");
			list.Add ("2.Tree: One to Many");
			list.Add ("3.Map: Many to Many");

			IIterator<string> it = list.Iterator ();
			while(it.HasNext())
				System.Console.WriteLine (it.Next);
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

		public static void TestMatrix()
		{
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestMatrix***********************");
			System.Console.WriteLine ();

			Matrix<int> matrix = new Matrix<int> ();
			for (int i = 0; i < 5; i++)
				matrix [i, i] = i + 1;

			System.Console.WriteLine ("Matrix");
			System.Console.WriteLine (matrix.ToString());
			System.Console.WriteLine ();

		}

		public static void TestSparseMatrix()
		{
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestSparseMatrix***********************");
			System.Console.WriteLine ();

			SparseMatrix matrix = new SparseMatrix ();
			for (int i = 0; i < 5; i++)
				matrix [i, i] = i + 1;
			
			System.Console.WriteLine ("SparseMatrix");
			System.Console.WriteLine (matrix.ToString());
			System.Console.WriteLine ();
			
		}

		public static void TestAdjacencyMatrixGraph()
		{
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestAdjacencyMatrixGraph***********************");
			System.Console.WriteLine ();

			ArrayList<AdjacencyMatrixGraphNode<string>> nodes = new ArrayList<AdjacencyMatrixGraphNode<string>> (4);
			for (int i = 0; i < nodes.Capacity; i++) {
				AdjacencyMatrixGraphNode<string> node = new AdjacencyMatrixGraphNode<string> ("" + (char)('A' + i));
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

		public static void TestAdjacencyLinkedGraph()
		{
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestAdjacencyLinkedGraph***********************");
			System.Console.WriteLine ();

			ArrayList<AdjacencyLinkedGraphNode<string>> nodes = new ArrayList<AdjacencyLinkedGraphNode<string>> (4);
			for (int i = 0; i < nodes.Capacity; i++) {
				AdjacencyLinkedGraphNode<string> node = new AdjacencyLinkedGraphNode<string> ("" + (char)('A' + i));
				nodes.Add (node);
			}

			for (int i = 0; i < nodes.Capacity; i++) {
				ArrayList<AdjacencyLinkedGraphNode<string>> neighbors = new ArrayList<AdjacencyLinkedGraphNode<string>> (nodes.Capacity - 1);
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

			AdjacencyLinkedGraph<string> graph = new AdjacencyLinkedGraph<string> (nodes);
			System.Console.WriteLine (graph);

		}

		public static void PrintArray<T>(T[] arr)
		{
			for (int i = 0; i < arr.Length; i++) {
				System.Console.Write (string.Format("{0} ", arr [i]));
			}
		}

		public static void TestSort()
		{
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestSort***********************");
			System.Console.WriteLine ();

			int size = 30;
			int[] arr = new int[size];
			System.Random random = new System.Random ();
			for (int i = 0; i < size; i++) {
				arr [i] = random.Next (0, size);
			}
			System.Console.WriteLine ("Original:");
			PrintArray (arr);
			System.Console.WriteLine ();

			Array.BubbleSort (arr);

			System.Console.WriteLine ("BubbleSort:");
			PrintArray (arr);
			System.Console.WriteLine ();

			Array.InsertSort (arr);

			System.Console.WriteLine ("InsertSort:");
			PrintArray (arr);
			System.Console.WriteLine ();

			/*
			Array.HeapSort (arr);

			System.Console.WriteLine ("HeapSort:");
			System.Console.WriteLine (arr);
			System.Console.WriteLine ();
			*/
		}

		public static void TestSearch()
		{
			System.Console.WriteLine ();
			System.Console.WriteLine ("***********************TestSearch***********************");
			System.Console.WriteLine ();

			int size = 100;
			int[] arr = new int[size];
			for (int i = 0; i < size; i++) {
				arr [i] = new System.Random ().Next (size);
			}
			System.Console.WriteLine ("Original:");
			System.Console.WriteLine (arr);
			System.Console.WriteLine ();

			Array.BubbleSort (arr);

			System.Console.WriteLine ("LinearSearch:");
			System.Console.WriteLine (arr);
			System.Console.WriteLine ();

			Array.InsertSort (arr);

			System.Console.WriteLine ("BinarySearch:");
			System.Console.WriteLine (arr);
			System.Console.WriteLine ();
		}

		public static void Main (string[] args)
		{
			TestArrayList ();
			TestLinkedList ();
			TestStack ();
			TestQueue ();
			TestBinaryTree ();
			TestMatrix ();
			TestSparseMatrix();
			TestAdjacencyMatrixGraph ();
			TestAdjacencyLinkedGraph ();

			TestSort ();
			//TestSearch ();
		}

	}
}
