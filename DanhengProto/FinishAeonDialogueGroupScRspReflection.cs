using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000560 RID: 1376
	public static class FinishAeonDialogueGroupScRspReflection
	{
		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06003D5F RID: 15711 RVA: 0x000A8052 File Offset: 0x000A6252
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishAeonDialogueGroupScRspReflection.descriptor;
			}
		}

		// Token: 0x0400188F RID: 6287
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJGaW5pc2hBZW9uRGlhbG9ndWVHcm91cFNjUnNwLnByb3RvGg5JdGVtTGlz",
			"dC5wcm90bxoRQUxGSk1JUERJQk8ucHJvdG8icQocRmluaXNoQWVvbkRpYWxv",
			"Z3VlR3JvdXBTY1JzcBIPCgdyZXRjb2RlGAUgASgNEhkKBnJld2FyZBgMIAEo",
			"CzIJLkl0ZW1MaXN0EiUKD3JvZ3VlX2Flb25faW5mbxgKIAEoCzIMLkFMRkpN",
			"SVBESUJPQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor,
			ALFJMIPDIBOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishAeonDialogueGroupScRsp), FinishAeonDialogueGroupScRsp.Parser, new string[]
			{
				"Retcode",
				"Reward",
				"RogueAeonInfo"
			}, null, null, null, null)
		}));
	}
}
