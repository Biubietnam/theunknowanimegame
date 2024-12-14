using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001E8 RID: 488
	public static class ChessRogueBuffEnhanceListReflection
	{
		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x0003EC68 File Offset: 0x0003CE68
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueBuffEnhanceListReflection.descriptor;
			}
		}

		// Token: 0x04000938 RID: 2360
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9DaGVzc1JvZ3VlQnVmZkVuaGFuY2VMaXN0LnByb3RvGh9DaGVzc1JvZ3Vl",
			"QnVmZkVuaGFuY2VJbmZvLnByb3RvIlIKGUNoZXNzUm9ndWVCdWZmRW5oYW5j",
			"ZUxpc3QSNQoRZW5oYW5jZV9pbmZvX2xpc3QYCiADKAsyGi5DaGVzc1JvZ3Vl",
			"QnVmZkVuaGFuY2VJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChessRogueBuffEnhanceInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueBuffEnhanceList), ChessRogueBuffEnhanceList.Parser, new string[]
			{
				"EnhanceInfoList"
			}, null, null, null, null)
		}));
	}
}
