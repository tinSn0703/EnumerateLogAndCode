using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EnumerateLogAndCode
{
	/// <summary>何らかの形式から検査ログを読み取る</summary>
	abstract class LogTextReader
	{
		public abstract void Set();

		public abstract (string _LogName, List<LogTextOne> _Text) Read();
	}

}
