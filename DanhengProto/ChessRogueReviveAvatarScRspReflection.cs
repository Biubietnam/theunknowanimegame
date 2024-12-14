using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200028C RID: 652
	public static class ChessRogueReviveAvatarScRspReflection
	{
		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x000537B3 File Offset: 0x000519B3
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueReviveAvatarScRspReflection.descriptor;
			}
		}

		// Token: 0x04000C2B RID: 3115
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFDaGVzc1JvZ3VlUmV2aXZlQXZhdGFyU2NSc3AucHJvdG8aG1JvZ3VlQXZh",
			"dGFyUmV2aXZlQ29zdC5wcm90byJ4ChtDaGVzc1JvZ3VlUmV2aXZlQXZhdGFy",
			"U2NSc3ASGwoTYmFzZV9hdmF0YXJfaWRfbGlzdBgDIAMoDRIrCgtyZXZpdmVf",
			"aW5mbxgJIAEoCzIWLlJvZ3VlQXZhdGFyUmV2aXZlQ29zdBIPCgdyZXRjb2Rl",
			"GAsgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			RogueAvatarReviveCostReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueReviveAvatarScRsp), ChessRogueReviveAvatarScRsp.Parser, new string[]
			{
				"BaseAvatarIdList",
				"ReviveInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
