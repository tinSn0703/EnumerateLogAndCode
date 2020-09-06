using System;
using System.Collections.Generic;
using System.Text;

namespace EnumerateLogAndCode
{
	/// <summary>ログ(1回)</summary>
	public readonly struct LogTestOne
	{
		public LogTestOne(in DateTime _Date, in List<string> _Log)
		{
			this.Date= _Date;
			this.Log = _Log;
		}

		public DateTime Date { get; }
		public List<string> Log { get; }
	}

	/// <summary>ログ</summary>
	class LogText
	{
		private string _LogName;
		private List<LogTestOne> _Text;

		public void Read()
		{
			_LogName = "";
		}

		public string Name => _LogName;
		public ref readonly List<LogTestOne> Text => ref _Text;
	}
}
