using System;
using System.Collections.Generic;
using System.Text;

namespace EnumerateLogAndCode.LogText
{
	/// <summary>ログ内から、指定した時間のログのみを取り出す</summary>
	class ReaderSelectDate : Reader
	{
		private DateTime _HeadDate;
		private DateTime _TailDate;
		private LogText _LogText;

		public ReaderSelectDate()
		{

		}

		public ReaderSelectDate(in LogText _LogText, in DateTime _HeadDate, in DateTime _TailDate)
		{
			Set(_LogText, _HeadDate, _TailDate);
		}

		public override (string _LogName, List<LogTextOne> _LogList) Read()
		{
			var _Log = new List<LogTextOne>();

			//throw new NotImplementedException();
			return (_LogText.Name, _Log);
		}

		public override void Set() => throw new NotImplementedException();

		/// <summary>ログの中から、取り出したい日付の範囲を指定する。</summary>
		/// <param name="_LogText">ログ</param>
		/// <param name="_HeadDate">取り出したいログの最小日付</param>
		/// <param name="_TailDate">取り出したいログの最大日付</param>
		public void Set(in LogText _LogText, in DateTime _HeadDate, in DateTime _TailDate)
		{
			this._LogText = _LogText;
			this._HeadDate = _HeadDate;
			this._TailDate = _TailDate;
		}
	}
}
