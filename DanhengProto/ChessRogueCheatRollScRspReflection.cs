using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001F8 RID: 504
	public static class ChessRogueCheatRollScRspReflection
	{
		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x000408C5 File Offset: 0x0003EAC5
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueCheatRollScRspReflection.descriptor;
			}
		}

		// Token: 0x04000983 RID: 2435
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5DaGVzc1JvZ3VlQ2hlYXRSb2xsU2NSc3AucHJvdG8aGENoZXNzUm9ndWVE",
			"aWNlSW5mby5wcm90byKHAQoYQ2hlc3NSb2d1ZUNoZWF0Um9sbFNjUnNwEiwK",
			"D3JvZ3VlX2RpY2VfaW5mbxgOIAEoCzITLkNoZXNzUm9ndWVEaWNlSW5mbxIT",
			"CgtMR0VNT0VHTUdQUBgNIAEoDRIXCg9kaWNlX3N1cmZhY2VfaWQYBiABKA0S",
			"DwoHcmV0Y29kZRgFIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
			"b3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ChessRogueDiceInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueCheatRollScRsp), ChessRogueCheatRollScRsp.Parser, new string[]
			{
				"RogueDiceInfo",
				"LGEMOEGMGPP",
				"DiceSurfaceId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
