using System;
using System.Collections.Generic;
using System.Text;

namespace EnumerateLogAndCode
{
	/// <summary>ログ(1回分)</summary>
	public readonly struct LogTextOne
	{
		public LogTextOne(in DateTime _Date, in List<string> _Log)
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
		//------------------------------------------------------------//
		//field
		//------------------------------------------------------------//

		private string _LogName;
		private List<LogTextOne> _LogList;

		//------------------------------------------------------------//
		//public method
		//------------------------------------------------------------//

		/// <summary>_Readerを利用し、ログを読み込む</summary>
		/// <param name="_Reader"></param>
		public void Read(in LogTextReader _Reader)
		{
			if (_Reader is null)
			{
				throw new ArgumentNullException(nameof(_Reader));
			}

			(_LogName, _LogList) = _Reader.Read();
		}

		//------------------------------------------------------------//
		//propaty
		//------------------------------------------------------------//

		public string Name => _LogName;
		public ref readonly List<LogTextOne> Log => ref _LogList;

		//------------------------------------------------------------//
	}
}
