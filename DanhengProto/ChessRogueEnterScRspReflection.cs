using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000216 RID: 534
	public static class ChessRogueEnterScRspReflection
	{
		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x0004473C File Offset: 0x0004293C
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueEnterScRspReflection.descriptor;
			}
		}

		// Token: 0x04000A16 RID: 2582
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpDaGVzc1JvZ3VlRW50ZXJTY1JzcC5wcm90bxobQ2hlc3NSb2d1ZUN1cnJl",
			"bnRJbmZvLnByb3RvGhRDaGVzc1JvZ3VlSW5mby5wcm90bxoYQ2hlc3NSb2d1",
			"ZUdhbWVJbmZvLnByb3RvIq8BChRDaGVzc1JvZ3VlRW50ZXJTY1JzcBIPCgdy",
			"ZXRjb2RlGAEgASgNEgoKAmlkGAwgASgNEiMKCnN0YWdlX2luZm8YAyABKAsy",
			"Dy5DaGVzc1JvZ3VlSW5mbxIyChJyb2d1ZV9jdXJyZW50X2luZm8YBCABKAsy",
			"Fi5DaGVzc1JvZ3VlQ3VycmVudEluZm8SIQoEaW5mbxgPIAEoCzITLkNoZXNz",
			"Um9ndWVHYW1lSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ChessRogueCurrentInfoReflection.Descriptor,
			ChessRogueInfoReflection.Descriptor,
			ChessRogueGameInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueEnterScRsp), ChessRogueEnterScRsp.Parser, new string[]
			{
				"Retcode",
				"Id",
				"StageInfo",
				"RogueCurrentInfo",
				"Info"
			}, null, null, null, null)
		}));
	}
}
