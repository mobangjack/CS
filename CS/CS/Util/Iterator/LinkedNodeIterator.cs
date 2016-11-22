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

namespace CS.Util.Iterator
{
	public class LinkedNodeIterator<T> : IIterator<T>
	{
		protected LinkedNode<T> next;

		public LinkedNodeIterator (LinkedNode<T> next)
		{
			this.next = next;
		}

		public virtual bool HasNext()
		{
			return next != null;
		}

		public virtual T Next
		{
			get {
				T data = next.Data;
				next = next.Right;
				return data;
			}
		}
	}
}

