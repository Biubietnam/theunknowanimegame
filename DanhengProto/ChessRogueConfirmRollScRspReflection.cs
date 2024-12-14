using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001FC RID: 508
	public static class ChessRogueConfirmRollScRspReflection
	{
		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x00041046 File Offset: 0x0003F246
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueConfirmRollScRspReflection.descriptor;
			}
		}

		// Token: 0x04000993 RID: 2451
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBDaGVzc1JvZ3VlQ29uZmlybVJvbGxTY1JzcC5wcm90bxoYQ2hlc3NSb2d1",
			"ZURpY2VJbmZvLnByb3RvIlsKGkNoZXNzUm9ndWVDb25maXJtUm9sbFNjUnNw",
			"EiwKD3JvZ3VlX2RpY2VfaW5mbxgFIAEoCzITLkNoZXNzUm9ndWVEaWNlSW5m",
			"bxIPCgdyZXRjb2RlGAogASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
			"UHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChessRogueDiceInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueConfirmRollScRsp), ChessRogueConfirmRollScRsp.Parser, new string[]
			{
				"RogueDiceInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
