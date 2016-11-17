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

namespace CS.Util.Graph
{
	public class Vertex<T>
	{
		private T data;
		private bool visited;

		public Vertex ()
		{
			this.data = default(T);
			this.visited = false;
		}

		public Vertex (T data)
		{
			this.data = data;
			this.visited = false;
		}

		public Vertex (T data, bool visited)
		{
			this.data = data;
			this.visited = visited;
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
	}
}
