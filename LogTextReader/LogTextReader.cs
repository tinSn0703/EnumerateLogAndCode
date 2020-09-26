using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EnumerateLogAndCode.LogText
{
	/// <summary>何らかの形式から検査ログを読み取るためのオブジェクト</summary>
	abstract class Reader
	{
		public abstract void Set();

		public abstract (string _LogName, List<LogTextOne> _LogList) Read();
	}

}
