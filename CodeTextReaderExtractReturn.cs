using System;
using System.Collections.Generic;
using System.Text;

namespace EnumerateLogAndCode
{
	class CodeTextReaderExtractReturn : CodeTextReader
	{
		public override (string _CodeName, List<CodeTestLine> _Text) Read()
		{
			throw new NotImplementedException();
		}

		public override void Set() => throw new NotImplementedException();
	}
}
