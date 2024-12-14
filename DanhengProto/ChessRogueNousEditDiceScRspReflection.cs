using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000252 RID: 594
	public static class ChessRogueNousEditDiceScRspReflection
	{
		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x0004D2F5 File Offset: 0x0004B4F5
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousEditDiceScRspReflection.descriptor;
			}
		}

		// Token: 0x04000B4C RID: 2892
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFDaGVzc1JvZ3VlTm91c0VkaXREaWNlU2NSc3AucHJvdG8aFENoZXNzUm9n",
			"dWVEaWNlLnByb3RvIlgKG0NoZXNzUm9ndWVOb3VzRWRpdERpY2VTY1JzcBIo",
			"Cg9xdWVyeV9kaWNlX2luZm8YBCABKAsyDy5DaGVzc1JvZ3VlRGljZRIPCgdy",
			"ZXRjb2RlGAsgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChessRogueDiceReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueNousEditDiceScRsp), ChessRogueNousEditDiceScRsp.Parser, new string[]
			{
				"QueryDiceInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
