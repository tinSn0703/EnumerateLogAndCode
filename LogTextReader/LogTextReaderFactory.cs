using System;
using System.Collections.Generic;
using System.Text;

namespace EnumerateLogAndCode
{
	public enum IndexLogTextReader
	{ TEXT_FILE, SELECT_DATE }

	class LogTextReaderFactory
	{
		public LogTextReaderFactory()	{}

		public LogTextReader Create(in IndexLogTextReader _Index)
		{
			switch (_Index)
			{
				case IndexLogTextReader.TEXT_FILE:
					return new LogTextReaderTextFile();
				case IndexLogTextReader.SELECT_DATE:
					return new LogTextReaderSelectDate();
				default:
					throw new ArgumentException(
						$"'{nameof(LogTextReaderFactory)}'\n'" +
						$"{nameof(_Index)}' : の値が不正です",
						nameof(_Index));
			}
		}
	}
}
