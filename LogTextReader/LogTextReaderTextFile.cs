using System;
using System.Collections.Generic;
using System.Text;

namespace EnumerateLogAndCode
{
	/// <summary>テキストファイルに記載された形式からログを取り出す。改行はCRLFの想定。</summary>
	class LogTextReaderTextFile : LogTextReader
	{
		private string _FileName;

		public LogTextReaderTextFile()	{}

		public LogTextReaderTextFile(in string _FileName)
		{
			Set(_FileName);
		}

		public override (string _LogName, List<LogTextOne> _LogList) Read()
		{
			var _Log = new List<LogTextOne>();

			//throw new NotImplementedException();
			return (_FileName, _Log);
		}

		public override void Set() => throw new NotImplementedException();

		public void Set(in string _FileName)
		{
			if (string.IsNullOrEmpty(_FileName))
			{
				throw new ArgumentException(
					$"'{nameof(CodeTextReaderTextFile)}'\n'{nameof(_FileName)}' が入力されていません。ディレクトリを指定してください。",
					nameof(_FileName));
			}

			this._FileName = _FileName;
		}
	}
}
