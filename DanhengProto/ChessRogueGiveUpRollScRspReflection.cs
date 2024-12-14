using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000226 RID: 550
	public static class ChessRogueGiveUpRollScRspReflection
	{
		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x000481CE File Offset: 0x000463CE
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueGiveUpRollScRspReflection.descriptor;
			}
		}

		// Token: 0x04000A94 RID: 2708
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9DaGVzc1JvZ3VlR2l2ZVVwUm9sbFNjUnNwLnByb3RvGhhDaGVzc1JvZ3Vl",
			"RGljZUluZm8ucHJvdG8aDkl0ZW1MaXN0LnByb3RvInoKGUNoZXNzUm9ndWVH",
			"aXZlVXBSb2xsU2NSc3ASHgoLQUFQSkxCR05GTEcYCyABKAsyCS5JdGVtTGlz",
			"dBIsCg9yb2d1ZV9kaWNlX2luZm8YAiABKAsyEy5DaGVzc1JvZ3VlRGljZUlu",
			"Zm8SDwoHcmV0Y29kZRgKIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ChessRogueDiceInfoReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueGiveUpRollScRsp), ChessRogueGiveUpRollScRsp.Parser, new string[]
			{
				"AAPJLBGNFLG",
				"RogueDiceInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
