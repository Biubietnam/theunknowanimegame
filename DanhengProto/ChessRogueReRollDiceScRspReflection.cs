using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000288 RID: 648
	public static class ChessRogueReRollDiceScRspReflection
	{
		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x000530B6 File Offset: 0x000512B6
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueReRollDiceScRspReflection.descriptor;
			}
		}

		// Token: 0x04000C1C RID: 3100
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9DaGVzc1JvZ3VlUmVSb2xsRGljZVNjUnNwLnByb3RvGhhDaGVzc1JvZ3Vl",
			"RGljZUluZm8ucHJvdG8iWgoZQ2hlc3NSb2d1ZVJlUm9sbERpY2VTY1JzcBIP",
			"CgdyZXRjb2RlGAMgASgNEiwKD3JvZ3VlX2RpY2VfaW5mbxgLIAEoCzITLkNo",
			"ZXNzUm9ndWVEaWNlSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
			"b3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ChessRogueDiceInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueReRollDiceScRsp), ChessRogueReRollDiceScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueDiceInfo"
			}, null, null, null, null)
		}));
	}
}
