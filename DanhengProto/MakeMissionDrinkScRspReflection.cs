using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A7C RID: 2684
	public static class MakeMissionDrinkScRspReflection
	{
		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x060076FE RID: 30462 RVA: 0x0013BBA7 File Offset: 0x00139DA7
		public static FileDescriptor Descriptor
		{
			get
			{
				return MakeMissionDrinkScRspReflection.descriptor;
			}
		}

		// Token: 0x04002DB7 RID: 11703
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtNYWtlTWlzc2lvbkRyaW5rU2NSc3AucHJvdG8aEUxHTklPQURKTk9KLnBy",
			"b3RvImsKFU1ha2VNaXNzaW9uRHJpbmtTY1JzcBIOCgZJc1N1Y2MYDiABKAgS",
			"DgoGSXNTYXZlGAIgASgIEiEKC0N1c3RvbURyaW5rGAogASgLMgwuTEdOSU9B",
			"REpOT0oSDwoHcmV0Y29kZRgPIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			LGNIOADJNOJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MakeMissionDrinkScRsp), MakeMissionDrinkScRsp.Parser, new string[]
			{
				"IsSucc",
				"IsSave",
				"CustomDrink",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
