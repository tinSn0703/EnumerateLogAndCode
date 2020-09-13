using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EnumerateLogAndCode
{
	/// <summary>何らかの形式から検査コードを読み取る</summary>
	abstract class CodeTextReader
	{
		public abstract void Set();

		public abstract (string _CodeName, List<CodeTextLine> _Text) Read();
	}

}
