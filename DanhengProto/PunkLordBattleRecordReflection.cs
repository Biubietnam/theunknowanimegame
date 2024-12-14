using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D1C RID: 3356
	public static class PunkLordBattleRecordReflection
	{
		// Token: 0x17002A41 RID: 10817
		// (get) Token: 0x060095E0 RID: 38368 RVA: 0x0018E7D8 File Offset: 0x0018C9D8
		public static FileDescriptor Descriptor
		{
			get
			{
				return PunkLordBattleRecordReflection.descriptor;
			}
		}

		// Token: 0x04003A1A RID: 14874
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpQdW5rTG9yZEJhdHRsZVJlY29yZC5wcm90bxoaUHVua0xvcmRCYXR0bGVB",
			"dmF0YXIucHJvdG8i9QEKFFB1bmtMb3JkQmF0dGxlUmVjb3JkEgsKA3VpZBgB",
			"IAEoDRIRCglkYW1hZ2VfaHAYAiABKA0SFAoMaXNfZmluYWxfaGl0GAMgASgI",
			"EhsKE292ZXJfa2lsbF9kYW1hZ2VfaHAYBCABKA0SGQoRYmF0dGxlX3JlcGxh",
			"eV9rZXkYBSABKAkSKgoLYXZhdGFyX2xpc3QYBiADKAsyFS5QdW5rTG9yZEJh",
			"dHRsZUF2YXRhchIUCgxhc3Npc3Rfc2NvcmUYByABKA0SFAoMZGFtYWdlX3Nj",
			"b3JlGAggASgNEhcKD2ZpbmFsX2hpdF9zY29yZRgJIAEoDUIeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			PunkLordBattleAvatarReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PunkLordBattleRecord), PunkLordBattleRecord.Parser, new string[]
			{
				"Uid",
				"DamageHp",
				"IsFinalHit",
				"OverKillDamageHp",
				"BattleReplayKey",
				"AvatarList",
				"AssistScore",
				"DamageScore",
				"FinalHitScore"
			}, null, null, null, null)
		}));
	}
}
