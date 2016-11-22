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

namespace CS.Util.Matrix
{
	public class Matrix<T>
	{
		private T[,] mat;

		public Matrix (int w, int h)
		{
			this.mat = new T[w,h];
		}

		public T this[int i, int j]
		{
			get { return mat [i, j]; }
			set { mat [i, j] = value; }
		}

		public T[,] Mat
		{
			get { return mat; }
			set { mat = value; }
		}
	}
}

