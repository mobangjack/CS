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

using CS.Util.Container;
using CS.Util.Iterator;

namespace CS.Util.Map
{
	public class HashMap<K,V> : AbstractContainer<Entry<K,V>>, IMap<K,V>
	{
		private Entry<K,V>[] tabs;
		private float re

		public HashMap (int initialCapacity)
		{
			tabs = new Entry<K, V>[initialCapacity];
		}

		private Entry<K,V> GetEntry(K k)
		{
			int index = indexFor (hash (k), tabs.Length - 1);
			Entry<K,V> entry = tabs [index];
			for(Entry<K,V> e = entry; e != null; e = e.Next) {
				if (Equalty.Check (k, e.Key))
					return e;
			}
			return null;
		}

		public V Get(K k)
		{
			Entry<K,V> e = GetEntry (k);
			return e == null ? null : e.Val;
		}

		public V Put(K k, V v)
		{
			int hash = hash (k);
			int index = hash;
			Entry<K,V> e = GetEntry (k);
			if (e == null) {
				tabs [index] = new Entry<K, V> (k, v);
				return null;
			} else {
				e.Next = new Entry<K, V> (k, v);
				return e;
			}
		}

		public override void Clear ()
		{
			base.Clear ();
			tabs = null;
		}

		public override IIterator<Entry<K,V>> Iterator ()
		{
		}

		static int hash(object obj)
		{
			int h;
			return obj == null? 0 : (h = obj.GetHashCode()) ^ (h >> 16);
		}

		static int indexFor(int h, int length)
		{
			return h & (length - 1);
		}
	}
}

