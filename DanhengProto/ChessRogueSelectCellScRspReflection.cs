using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000298 RID: 664
	public static class ChessRogueSelectCellScRspReflection
	{
		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x00054CE9 File Offset: 0x00052EE9
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueSelectCellScRspReflection.descriptor;
			}
		}

		// Token: 0x04000C58 RID: 3160
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9DaGVzc1JvZ3VlU2VsZWN0Q2VsbFNjUnNwLnByb3RvGhFQRE1IQUNOQU5Q",
			"Ri5wcm90byJ7ChlDaGVzc1JvZ3VlU2VsZWN0Q2VsbFNjUnNwEiEKC0tHSkpH",
			"QkdGSkFNGAcgASgLMgwuUERNSEFDTkFOUEYSGQoRc2VsZWN0X21vbnN0ZXJf",
			"aWQYDiABKA0SDwoHY2VsbF9pZBgNIAEoDRIPCgdyZXRjb2RlGAEgASgNQh6q",
			"AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			PDMHACNANPFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueSelectCellScRsp), ChessRogueSelectCellScRsp.Parser, new string[]
			{
				"KGJJGBGFJAM",
				"SelectMonsterId",
				"CellId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
