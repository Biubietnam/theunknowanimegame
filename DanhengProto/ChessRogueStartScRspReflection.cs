using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002A0 RID: 672
	public static class ChessRogueStartScRspReflection
	{
		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x00055E4F File Offset: 0x0005404F
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueStartScRspReflection.descriptor;
			}
		}

		// Token: 0x04000C82 RID: 3202
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpDaGVzc1JvZ3VlU3RhcnRTY1JzcC5wcm90bxoQTGluZXVwSW5mby5wcm90",
			"bxolQ2hlc3NSb2d1ZUxheWVySW5pdGlhbEV2ZW50SW5mby5wcm90bxoYQ2hl",
			"c3NSb2d1ZUdhbWVJbmZvLnByb3RvGhtDaGVzc1JvZ3VlQ3VycmVudEluZm8u",
			"cHJvdG8aFENoZXNzUm9ndWVJbmZvLnByb3RvGg9TY2VuZUluZm8ucHJvdG8i",
			"lwIKFENoZXNzUm9ndWVTdGFydFNjUnNwEiMKCnN0YWdlX2luZm8YCSABKAsy",
			"Dy5DaGVzc1JvZ3VlSW5mbxIZCgVzY2VuZRgPIAEoCzIKLlNjZW5lSW5mbxIP",
			"CgdyZXRjb2RlGAggASgNEhsKBmxpbmV1cBgDIAEoCzILLkxpbmV1cEluZm8S",
			"IQoEaW5mbxgOIAEoCzITLkNoZXNzUm9ndWVHYW1lSW5mbxI6ChBib2FyZF9l",
			"dmVudF9pbmZvGAQgASgLMiAuQ2hlc3NSb2d1ZUxheWVySW5pdGlhbEV2ZW50",
			"SW5mbxIyChJyb2d1ZV9jdXJyZW50X2luZm8YAiABKAsyFi5DaGVzc1JvZ3Vl",
			"Q3VycmVudEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			LineupInfoReflection.Descriptor,
			ChessRogueLayerInitialEventInfoReflection.Descriptor,
			ChessRogueGameInfoReflection.Descriptor,
			ChessRogueCurrentInfoReflection.Descriptor,
			ChessRogueInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueStartScRsp), ChessRogueStartScRsp.Parser, new string[]
			{
				"StageInfo",
				"Scene",
				"Retcode",
				"Lineup",
				"Info",
				"BoardEventInfo",
				"RogueCurrentInfo"
			}, null, null, null, null)
		}));
	}
}
