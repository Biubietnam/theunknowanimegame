using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001DE RID: 478
	public static class ChessRogueAeonInfoReflection
	{
		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x0003D83B File Offset: 0x0003BA3B
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueAeonInfoReflection.descriptor;
			}
		}

		// Token: 0x04000904 RID: 2308
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhDaGVzc1JvZ3VlQWVvbkluZm8ucHJvdG8aHUNoZXNzUm9ndWVRdWVyeUFl",
			"b25JbmZvLnByb3RvGhFKUEVHT0dORFBKSi5wcm90byKrAQoSQ2hlc3NSb2d1",
			"ZUFlb25JbmZvEhQKDGdhbWVfYWVvbl9pZBgCIAEoDRITCgtMQUFMT0pIQlBM",
			"TxgDIAEoBRIxCg9jaGVzc19hZW9uX2luZm8YCCABKAsyGC5DaGVzc1JvZ3Vl",
			"UXVlcnlBZW9uSW5mbxIhCgtIRUhHTEVLQkdCSxgOIAEoCzIMLkpQRUdPR05E",
			"UEpKEhQKDGFlb25faWRfbGlzdBgPIAMoDUIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ChessRogueQueryAeonInfoReflection.Descriptor,
			JPEGOGNDPJJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueAeonInfo), ChessRogueAeonInfo.Parser, new string[]
			{
				"GameAeonId",
				"LAALOJHBPLO",
				"ChessAeonInfo",
				"HEHGLEKBGBK",
				"AeonIdList"
			}, null, null, null, null)
		}));
	}
}
