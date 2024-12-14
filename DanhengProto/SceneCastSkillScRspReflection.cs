using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001058 RID: 4184
	public static class SceneCastSkillScRspReflection
	{
		// Token: 0x1700348A RID: 13450
		// (get) Token: 0x0600BA54 RID: 47700 RVA: 0x001F4CCC File Offset: 0x001F2ECC
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneCastSkillScRspReflection.descriptor;
			}
		}

		// Token: 0x04004B90 RID: 19344
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlTY2VuZUNhc3RTa2lsbFNjUnNwLnByb3RvGhVTY2VuZUJhdHRsZUluZm8u",
			"cHJvdG8aGkhpdE1vbnN0ZXJCYXR0bGVJbmZvLnByb3RvIpkBChNTY2VuZUNh",
			"c3RTa2lsbFNjUnNwEhYKDmNhc3RfZW50aXR5X2lkGAEgASgNEjIKE21vbnN0",
			"ZXJfYmF0dGxlX2luZm8YCSADKAsyFS5IaXRNb25zdGVyQmF0dGxlSW5mbxIP",
			"CgdyZXRjb2RlGA4gASgNEiUKC2JhdHRsZV9pbmZvGAcgASgLMhAuU2NlbmVC",
			"YXR0bGVJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor,
			HitMonsterBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneCastSkillScRsp), SceneCastSkillScRsp.Parser, new string[]
			{
				"CastEntityId",
				"MonsterBattleInfo",
				"Retcode",
				"BattleInfo"
			}, null, null, null, null)
		}));
	}
}
