/**
 * Copyright (c) 2011-2016, Jack Mo 莫帮杰 (mobangjack@foxmail.com).
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace CS.Util.List
{
	public interface List<T>
	{
		int IndexOf(T item);
		bool Contains(T item);
		int Size();
		bool IsEmpty();
		bool NotEmpty();
		T Get(int index);
		void Set(int index, T value);
		void Add (int index, T item);
		void Add (T item);
		bool Remove (T item);
		T Remove (int index);
		T[] ToArray ();
	}
}
		
