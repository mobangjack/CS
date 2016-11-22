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
	public class AdjacencyLinkedGraphNode<T> : AdjacencyMatrixGraphNode<T>
	{
		private IList<AdjacencyLinkedGraphNode<T>> neighbors;
		private IList<int> costs;

		public AdjacencyLinkedGraphNode () : base()
		{
			neighbors = null;
			costs = null;
		}

		public AdjacencyLinkedGraphNode (T data) : base(data)
		{
			neighbors = null;
			costs = null;
		}

		public AdjacencyLinkedGraphNode (T data, bool visited) : base(data)
		{
			neighbors = null;
			costs = null;
		}

		public IList<AdjacencyLinkedGraphNode<T>> Neighbors
		{
			get { return neighbors; }
			set { neighbors = value; }
		}

		public IList<int> Costs
		{
			get { return costs; }
			set { costs = value; }
		}
	}
}

