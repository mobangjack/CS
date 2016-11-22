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

namespace CS.Util.Tree
{
	public class BinarySearchTree<T> : BinaryTree<T> where T:System.IComparable
	{
		public BinarySearchTree ()
		{
		}

		public BinarySearchTree (T[] arr)
		{
			for (int i = 0; i < arr.Length; i++) {
				
			}
		}

		public void Add(T item) 
		{
			if (Data == null) {
				Data = item;
			} else if (item.CompareTo (Data) < 0) {
				if (Left == null)
					Left = new BinaryTree<T> (item);
				else
					Left.Data = item;
			} else {
				//if(
			}
		}
	}
}

