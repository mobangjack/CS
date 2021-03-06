﻿// /**
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
	public class AdjacencyMatrixGraph<T>
	{
		private IList<AdjacencyMatrixGraphNode<T>> nodes;
		private int[,] adjMat;

		public AdjacencyMatrixGraph(IList<AdjacencyMatrixGraphNode<T>> nodes, int[,] adjMat){
			if (adjMat.GetLength (0) != adjMat.GetLength (1))
				throw new System.ArgumentException ("The given adjMat should be a square matrix");
			this.nodes = nodes;
			this.adjMat = adjMat;
		}

		public IList<AdjacencyMatrixGraphNode<T>> Nodes
		{
			get { return nodes; }
			set { nodes = value; }
		}

		public int[,] AdjMat
		{
			get { return adjMat; }
			set { adjMat = value; }
		}

		public override string ToString ()
		{
			string s = "";
			for (int i = 0; i < adjMat.GetLength (0); i++)
				for (int j = 0; j < adjMat.GetLength (1); j++)
					if (adjMat [i, j] > 0)
						s += string.Format ("{0}->{1}, {2}\n", nodes [i].Data, nodes [j].Data, adjMat [i, j]);
			return s;
		}
	}
}

