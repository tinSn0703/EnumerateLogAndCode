using System;
using System.Collections.Generic;

namespace EnumerateLogAndCode
{
	/// <summary>ファイルから読み取った形式のテキストから検査コードを読み取る</summary>
	class CodeTextReaderFileText : CodeTextReader
	{
		private const string _LineSplitPattern = @"[\r\n]??(.*?)[\r\n]";
		private const string _CodeSplitPattern = @"^(\d{2})(.*?)(@??.*?){3}$";

		private string _FileName;
		private string _FileText;

		public CodeTextReaderFileText(in string _FileName, in string _FileText)
		{
			Set(_FileName, _FileText);
		}

		public override void Set() { throw new NotImplementedException(); }

		public void Set(in string _FileName, in string _FileText)
		{
			if (string.IsNullOrEmpty(_FileName))
				throw new ArgumentException(
					$"'{nameof(CodeTextReaderFileText)}'\n'{nameof(_FileName)}' は null / 空 にはできません", 
					nameof(_FileName));

			if (string.IsNullOrEmpty(_FileText))
				throw new ArgumentException(
					$"'{nameof(CodeTextReaderFileText)}'\n'{nameof(_FileText)}' は null / 空 にはできません", 
					nameof(_FileText));

			this._FileName = _FileName;
			this._FileText = _FileText;
		}

		public override (string _CodeName, List<CodeTestLine> _Text) Read()
		{
			var _Text = new List<CodeTestLine>();

			throw new NotImplementedException();

			//return (_FileName, _Text);
		}
	}

}
