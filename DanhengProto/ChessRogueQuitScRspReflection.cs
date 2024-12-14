using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000284 RID: 644
	public static class ChessRogueQuitScRspReflection
	{
		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x0005237F File Offset: 0x0005057F
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueQuitScRspReflection.descriptor;
			}
		}

		// Token: 0x04000C02 RID: 3074
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlDaGVzc1JvZ3VlUXVpdFNjUnNwLnByb3RvGhlDaGVzc1JvZ3VlTGV2ZWxJ",
			"bmZvLnByb3RvGhhDaGVzc1JvZ3VlQWVvbkluZm8ucHJvdG8aGkNoZXNzUm9n",
			"dWVGaW5pc2hJbmZvLnByb3RvGhtDaGVzc1JvZ3VlQ3VycmVudEluZm8ucHJv",
			"dG8aGENoZXNzUm9ndWVHYW1lSW5mby5wcm90bxoXQ2hlc3NSb2d1ZUdldElu",
			"Zm8ucHJvdG8aGUNoZXNzUm9ndWVRdWVyeUluZm8ucHJvdG8aFENoZXNzUm9n",
			"dWVJbmZvLnByb3RvIvwCChNDaGVzc1JvZ3VlUXVpdFNjUnNwEiMKCnN0YWdl",
			"X2luZm8YAyABKAsyDy5DaGVzc1JvZ3VlSW5mbxIhCgRpbmZvGA0gASgLMhMu",
			"Q2hlc3NSb2d1ZUdhbWVJbmZvEioKDnJvZ3VlX2dldF9pbmZvGAUgASgLMhIu",
			"Q2hlc3NSb2d1ZUdldEluZm8SKAoKbGV2ZWxfaW5mbxgEIAEoCzIULkNoZXNz",
			"Um9ndWVMZXZlbEluZm8SDwoHcmV0Y29kZRgMIAEoDRIsCg9yb2d1ZV9hZW9u",
			"X2luZm8YBiABKAsyEy5DaGVzc1JvZ3VlQWVvbkluZm8SKgoLZmluaXNoX2lu",
			"Zm8YByABKAsyFS5DaGVzc1JvZ3VlRmluaXNoSW5mbxIoCgpxdWVyeV9pbmZv",
			"GAsgASgLMhQuQ2hlc3NSb2d1ZVF1ZXJ5SW5mbxIyChJyb2d1ZV9jdXJyZW50",
			"X2luZm8YAiABKAsyFi5DaGVzc1JvZ3VlQ3VycmVudEluZm9CHqoCG0VnZ0xp",
			"bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChessRogueLevelInfoReflection.Descriptor,
			ChessRogueAeonInfoReflection.Descriptor,
			ChessRogueFinishInfoReflection.Descriptor,
			ChessRogueCurrentInfoReflection.Descriptor,
			ChessRogueGameInfoReflection.Descriptor,
			ChessRogueGetInfoReflection.Descriptor,
			ChessRogueQueryInfoReflection.Descriptor,
			ChessRogueInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueQuitScRsp), ChessRogueQuitScRsp.Parser, new string[]
			{
				"StageInfo",
				"Info",
				"RogueGetInfo",
				"LevelInfo",
				"Retcode",
				"RogueAeonInfo",
				"FinishInfo",
				"QueryInfo",
				"RogueCurrentInfo"
			}, null, null, null, null)
		}));
	}
}
