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
	public class AdjacencyLinkedGraph<T>
	{
		private IList<AdjacencyLinkedGraphNode<T>> nodes;

		public AdjacencyLinkedGraph (IList<AdjacencyLinkedGraphNode<T>> nodes)
		{
			this.nodes = nodes;
		}

		public IList<AdjacencyLinkedGraphNode<T>> Nodes
		{
			get { return nodes; }
			set { nodes = value; }
		}

		public override string ToString ()
		{
			string s = "";
			for (int i = 0; i < nodes.Size (); i++)
				if (nodes [i].Neighbors != null)
					for (int j = 0; j < nodes [i].Neighbors.Size (); j++)
						s += string.Format ("{0}->{1}, {2}\n", nodes [i].Data, nodes [i].Neighbors [j].Data, nodes [i].Costs [j]);
			return s;
		}
	}
}

