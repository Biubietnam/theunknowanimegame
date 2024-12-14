using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000266 RID: 614
	public static class ChessRoguePickAvatarScRspReflection
	{
		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001B6E RID: 7022 RVA: 0x0004EFB3 File Offset: 0x0004D1B3
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRoguePickAvatarScRspReflection.descriptor;
			}
		}

		// Token: 0x04000B8C RID: 2956
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9DaGVzc1JvZ3VlUGlja0F2YXRhclNjUnNwLnByb3RvGhpDaGVzc1JvZ3Vl",
			"TGluZXVwSW5mby5wcm90byJ7ChlDaGVzc1JvZ3VlUGlja0F2YXRhclNjUnNw",
			"Eg8KB3JldGNvZGUYBCABKA0SMAoRcm9ndWVfbGluZXVwX2luZm8YDSABKAsy",
			"FS5DaGVzc1JvZ3VlTGluZXVwSW5mbxIbChNiYXNlX2F2YXRhcl9pZF9saXN0",
			"GA4gAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			ChessRogueLineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRoguePickAvatarScRsp), ChessRoguePickAvatarScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueLineupInfo",
				"BaseAvatarIdList"
			}, null, null, null, null)
		}));
	}
}
