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

namespace CS.Util.Map
{
	public class Entry<K,V>
	{
		private K key;
		private V val;
		private Entry<K,V> next;

		public Entry() {
		}

		public Entry(K k, V v)
		{
			this.key = k;
			this.val = v;
		}

		public Entry(K k, V v, Entry<K,V> n) : this(k, v)
		{
			this.next = n;
		}
			
		public K Key
		{
			get { return key; }
			set { key = value; }
		}

		public V Val
		{
			get { return val; }
			set { val = value; }
		}

		public Entry<K,V> Next
		{
			get { return next; }
			set { next = value; }
		}
	}
}

