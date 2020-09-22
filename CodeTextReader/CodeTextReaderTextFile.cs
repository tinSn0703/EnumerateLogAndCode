using System;
using System.Collections.Generic;

namespace EnumerateLogAndCode
{
	/// <summary>ファイルから読み取った形式のテキストから検査コードを読み取る</summary>
	class CodeTextReaderTextFile : CodeTextReader
	{
		private const string LINE_SPLIT_PATTERN = @"[\r\n]??(.*?)[\r\n]";
		private const string CODE_SPLIT_PATTERN = @"^(\d{2})(.*?)(@??.*?){3}$";

		private string _FileName;
		
		public CodeTextReaderTextFile(in string _FileName)
		{
			Set(_FileName);
		}

		public override void Set() { throw new NotImplementedException(); }

		public void Set(in string _FileName)
		{
			if (string.IsNullOrEmpty(_FileName))
			{ 
				throw new ArgumentException(
					$"'{nameof(CodeTextReaderTextFile)}'\n'{nameof(_FileName)}' は null / 空 にはできません",
					nameof(_FileName));
			}

			this._FileName = _FileName;
		}

		public override (string _CodeName, List<CodeTextLine> _Text) Read()
		{
			var _Text = new List<CodeTextLine>();



			throw new NotImplementedException();

			//return (_FileName, _Text);
		}
	}

}
