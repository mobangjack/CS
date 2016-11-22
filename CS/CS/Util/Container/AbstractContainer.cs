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

using CS.Util.Iterator;

namespace CS.Util.Container
{
	public abstract class AbstractContainer<T> : IContainer<T>
	{
		protected int cnt;

		public AbstractContainer()
		{
			cnt = 0;
		}

		public virtual int Size()
		{
			return cnt;
		}

		public virtual bool IsEmpty()
		{
			return cnt < 1;
		}

		public virtual bool NotEmpty()
		{
			return cnt > 0;
		}

		public virtual void Clear()
		{
			cnt = 0;
		}

		public abstract IIterator<T> Iterator ();
	}
}

