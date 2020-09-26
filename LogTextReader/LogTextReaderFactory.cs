using System;
using System.Collections.Generic;
using System.Text;

namespace EnumerateLogAndCode.LogText
{
	public enum ReaderIndex
	{ TEXT_FILE, SELECT_DATE }

	class ReaderFactory
	{
		public ReaderFactory()	{}

		public Reader Create(in ReaderIndex _Index)
		{
			switch (_Index)
			{
				case ReaderIndex.TEXT_FILE:
					return new ReaderTextFile();
				case ReaderIndex.SELECT_DATE:
					return new ReaderSelectDate();
				default:
					throw new ArgumentException($"'{nameof(ReaderFactory)}'\n'" +
						$"{nameof(_Index)}' : の値が不正です", nameof(_Index));
			}
		}
	}
}
