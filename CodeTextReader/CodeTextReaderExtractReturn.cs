using System;
using System.Collections.Generic;
using System.Text;

namespace EnumerateLogAndCode
{
	/// <summary>検査コードの内から必要な部分だけを取り出して返す</summary>
	class CodeTextReaderExtractReturn : CodeTextReader
	{
		public override (string _CodeName, List<CodeTextLine> _Text) Read()
		{
			throw new NotImplementedException();
		}

		public override void Set() => throw new NotImplementedException();
	}
}
