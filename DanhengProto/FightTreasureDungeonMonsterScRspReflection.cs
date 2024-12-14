using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200055C RID: 1372
	public static class FightTreasureDungeonMonsterScRspReflection
	{
		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x06003D33 RID: 15667 RVA: 0x000A7A32 File Offset: 0x000A5C32
		public static FileDescriptor Descriptor
		{
			get
			{
				return FightTreasureDungeonMonsterScRspReflection.descriptor;
			}
		}

		// Token: 0x04001883 RID: 6275
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZGaWdodFRyZWFzdXJlRHVuZ2Vvbk1vbnN0ZXJTY1JzcC5wcm90bxoVU2Nl",
			"bmVCYXR0bGVJbmZvLnByb3RvIloKIEZpZ2h0VHJlYXN1cmVEdW5nZW9uTW9u",
			"c3RlclNjUnNwEg8KB3JldGNvZGUYCCABKA0SJQoLYmF0dGxlX2luZm8YDyAB",
			"KAsyEC5TY2VuZUJhdHRsZUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FightTreasureDungeonMonsterScRsp), FightTreasureDungeonMonsterScRsp.Parser, new string[]
			{
				"Retcode",
				"BattleInfo"
			}, null, null, null, null)
		}));
	}
}
