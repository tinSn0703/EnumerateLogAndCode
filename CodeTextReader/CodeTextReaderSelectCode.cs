using System;
using System.Collections.Generic;
using System.Text;

namespace EnumerateLogAndCode
{
	/// <summary>検査コードの内から受信値があるものだけを取り出して返す</summary>
	class CodeTextReaderSelectCode : CodeTextReader
	{
		private CodeText _CodeText;

		public override (string _CodeName, List<CodeTextLine> _Text) Read()
		{
			var _Text = new List<CodeTextLine>();
			
			
			
			throw new NotImplementedException();
		}

		public override void Set() { throw new NotImplementedException(); }
	}
}
