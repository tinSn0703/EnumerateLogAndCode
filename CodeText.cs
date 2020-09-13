using System;
using System.Collections.Generic;
using System.Text;

namespace EnumerateLogAndCode
{
	/// <summary>チェッカー検査コード(1行)</summary>
	public readonly struct CodeTextLine
	{
		public CodeTextLine(in Int16 _CheckCodeLineNum, in Int16 _CheckCommand, in string _CheckCode, in string _Comment)
		{
			if (string.IsNullOrEmpty(_CheckCode))
				throw new ArgumentException(
					$"'{nameof(CodeTextLine)}'\n'{nameof(_CheckCode)}' は null / 空 にはできません", 
					nameof(_CheckCode));

			if (string.IsNullOrEmpty(_Comment))
				throw new ArgumentException(
					$"'{nameof(CodeTextLine)}'\n'{nameof(_Comment)}' は null / 空 にはできません", 
					nameof(_Comment));

			CheckCodeLineNum = _CheckCodeLineNum;
			CheckCommand = _CheckCommand;
			CheckCode = _CheckCode;
			Comment= _Comment;
		}

		public Int16 CheckCodeLineNum { get; }
		public Int16 CheckCommand { get; }
		public string CheckCode { get; }
		public string Comment { get; }
	}

	/// <summary>チェッカー検査コードを表す</summary>
	class CodeText
	{
		private string _CodeName;
		private List<CodeTextLine> _Text;

		public CodeText(in CodeTextReader _Reader) => this.Read(_Reader);

		public void Read(in CodeTextReader _Reader)
		{
			if (_Reader is null)
			{
				throw new ArgumentNullException(nameof(_Reader));
			}

			(_CodeName, _Text) = _Reader.Read();
		}

		public string Name => _CodeName;
		public ref readonly List<CodeTextLine> Text => ref _Text;
	}
}
