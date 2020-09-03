using System;
using System.Collections.Generic;
using System.Text;

namespace EnumerateLogAndCode
{
	/// <summary>
	/// ApplicationへのSettingからの各種命令を担当する。
	/// </summary>
	class ApplicationOrder
	{
		public ApplicationReaderOrder GetReaderOrder()
		{
			return new ApplicationReaderOrder();
		}

		public ApplicationPerfomerOrder GetPerformerOrder()
		{
			return new ApplicationPerfomerOrder();
		}

		public ApplicationWriterOrder GetWriterOrder()
		{
			return new ApplicationWriterOrder();
		}
	}
}
