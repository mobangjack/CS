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

namespace CS.Util.Matrix
{
	public class SparseMatrix
	{
		public class Entry
		{
			private int row, col;
			private int data;
			private Entry next;

			public Entry(int row, int col, int data)
			{
				this.row = row;
				this.col = col;
				this.data = data;
			}

			public int Row
			{
				get { return row; }
				set { row = value; }
			}

			public int Col
			{
				get { return col; }
				set { col = value; }
			}

			public int Data
			{
				get { return data; }
				set { data = value; }
			}

			public Entry Next
			{
				get { return next; }
				set { next = value; }
			}

			public override string ToString ()
			{
				string s = string.Format ("({0}, {1}, {2})\n", Row, Col, Data);
				if (next != null)
					return s + next.ToString ();
				else
					return s;
			}
		}

		private Entry first;

		public SparseMatrix()
		{
			this.first = null;
		}

		public int Set(int row, int col, int data)
		{
			if (first == null) {
				first = new Entry (row, col, data);
				return 0;
			}
			else {
				int val = 0;
				Entry e = null;
				for (e = first; e != null; e = e.Next) {
					if (e.Row == row && e.Col == col) {
						val = e.Data;
						e.Data = data;
						return val;
					}
				}
				val = first.Data;
				e = new Entry (row, col, data);
				e.Next = first;
				first = e;
				return val;
			}
		}

		public int Get(int row, int col)
		{
			for (Entry e = first; e != null; e = e.Next)
				if (e.Row == row && e.Col == col)
					return e.Data;
			return 0;
		}

		public int this[int row, int col]
		{
			get { return Get(row, col); }
			set { Set (row, col, value); }
		}

		public int Size()
		{
			int size = 0;
			for (Entry e = first; e != null; e = e.Next)
				size++;
			return size;
		}

		public override string ToString ()
		{
			return first.ToString ();
		}
	}
}
