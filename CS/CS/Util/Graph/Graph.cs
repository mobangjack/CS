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

namespace CS.Util.Graph
{
	public class Graph<T>
	{
		public class Node
		{
			private T data;
			private bool visited;
			private ArrayList<Node> neighbors;
			private ArrayList<int> costs;

			public Node(T data)
			{
				this.data = data;
			}

			public Node(T data, ArrayList<Node> neighbors, ArrayList<int> costs)
			{
				this.data = data;
				this.neighbors = neighbors;
				this.costs = costs;
			}

			public T Data
			{
				get { return data; }
				set { data = value; }
			}

			public bool Visited
			{
				get { return visited; }
				set { visited = value; }
			}

			public ArrayList<Node> Neighbors
			{
				get { return neighbors; }
				set { neighbors = value; }
			}

			public ArrayList<int> Costs
			{
				get { return costs; }
				set { costs = value; }
			}
		}

		private ArrayList<Node> nodes;

		public Graph (ArrayList<Node> nodes)
		{
			this.nodes = nodes;
		}

		public int IndexOf(T item)
		{
			for (int i = 0; i < nodes.Size (); i++)
				if(item.Equals(nodes[i]))
					return i;
			return -1;
		}

		private void CheckIndexRange(int index, int max)
		{
			if (index < 0 || index > max)
				throw new System.IndexOutOfRangeException ();
		}

		public T this[int index]
		{
			get { return nodes.Get (index).Data; }
			set { nodes [index].Data = value; }
		}

		public int Size()
		{
			return nodes.Size ();
		}

		public ArrayList<Node> Nodes
		{
			get { return nodes; }
			set { nodes = value; }
		}

		public void AddNode(Node node)
		{
			nodes.Add (node);
		}

		public override string ToString ()
		{
			string s = "";
			for (int i = 0; i < nodes.Size (); i++)
				if (nodes [i].Neighbors != null)
					for (int j = 0; j < nodes [i].Neighbors.Size (); j++)
						s += nodes [i].Data + "-" + nodes [i].Neighbors [j].Data + ", " + nodes [i].Costs[j] + "\n";
			return s;
		}
	}
}

