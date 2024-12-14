using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B8A RID: 2954
	public static class MonsterBattleInfoReflection
	{
		// Token: 0x1700249B RID: 9371
		// (get) Token: 0x060082C5 RID: 33477 RVA: 0x00158481 File Offset: 0x00156681
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonsterBattleInfoReflection.descriptor;
			}
		}

		// Token: 0x040031D7 RID: 12759
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdNb25zdGVyQmF0dGxlSW5mby5wcm90bxoVTW9uc3RlclBoYXNlU3R0LnBy",
			"b3RvGg9CYXR0bGVUYWcucHJvdG8aFU1vbnN0ZXJQcm9wZXJ0eS5wcm90bxoR",
			"TEJOT0dISU1ETUcucHJvdG8aFlNraWxsVXNlUHJvcGVydHkucHJvdG8aEURl",
			"YXRoU291cmNlLnByb3RvGhpBdHRhY2tEYW1hZ2VQcm9wZXJ0eS5wcm90bxoR",
			"UEhLTUxPTUNOTU4ucHJvdG8ioQYKEU1vbnN0ZXJCYXR0bGVJbmZvEhEKCWVu",
			"dGl0eV9pZBgBIAEoDRISCgptb25zdGVyX2lkGAIgASgNEhMKC0xHSU9LSlBK",
			"T0ZOGAMgASgNEhMKC09EQk5CS0NERFBDGAQgASgNEiUKC0VNUERHR0FBTERD",
			"GAUgASgLMhAuTW9uc3RlclByb3BlcnR5EhMKC3RvdGFsX3R1cm5zGAYgASgN",
			"EhQKDHRvdGFsX2RhbWFnZRgHIAEoARISCgp0b3RhbF9oZWFsGAggASgBEhoK",
			"EnRvdGFsX2RhbWFnZV90YWtlbhgJIAEoARITCgtBQ05BQUdQT0lNRRgKIAEo",
			"ARIYChB0b3RhbF9ocF9yZWNvdmVyGAsgASgBEhAKCHN0YWdlX2lkGAwgASgN",
			"EhEKCWJhdHRsZV9pZBgNIAEoDRITCgtHRUhJQ05CRE5GUBgOIAEoDRIxChJh",
			"dHRhY2tfdHlwZV9kYW1hZ2UYDyADKAsyFS5BdHRhY2tEYW1hZ2VQcm9wZXJ0",
			"eRImCgtza2lsbF90aW1lcxgQIAMoCzIRLlNraWxsVXNlUHJvcGVydHkSEgoK",
			"c3RhZ2VfdHlwZRgRIAEoDRITCgtKR0FCR0tMUFBCQRgSIAEoARIWCg5kZWxh",
			"eV9jdW11bGF0ZRgTIAEoARIhCgtHQ0JNTU1ETERLThgUIAEoDjIMLkRlYXRo",
			"U291cmNlEgwKBHdhdmUYFSABKA0SEwoLQklETUlMRkRLSUsYFiABKAUSDQoF",
			"cGhhc2UYFyABKA0SEwoLREZKSERLS01QTU0YGCABKA0SHwoLTUxDRE1CRUNE",
			"Sk0YGSABKA4yCi5CYXR0bGVUYWcSIAoKc2tpbGxfaW5mbxgaIAMoCzIMLlBI",
			"S01MT01DTk1OEhMKC09LR0tNTEdHTURPGBsgASgNEiUKC0tFUERDRUlMTEpG",
			"GBwgAygLMhAuTW9uc3RlclBoYXNlU3R0EhMKC0pHSE5QRUJIQkRLGB0gASgN",
			"EhMKC0xBTk9JUEpIS0FDGB4gASgNEiEKC0FNTEFBT0xES0NMGB8gASgOMgwu",
			"TEJOT0dISU1ETUdCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			MonsterPhaseSttReflection.Descriptor,
			BattleTagReflection.Descriptor,
			MonsterPropertyReflection.Descriptor,
			LBNOGHIMDMGReflection.Descriptor,
			SkillUsePropertyReflection.Descriptor,
			DeathSourceReflection.Descriptor,
			AttackDamagePropertyReflection.Descriptor,
			PHKMLOMCNMNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonsterBattleInfo), MonsterBattleInfo.Parser, new string[]
			{
				"EntityId",
				"MonsterId",
				"LGIOKJPJOFN",
				"ODBNBKCDDPC",
				"EMPDGGAALDC",
				"TotalTurns",
				"TotalDamage",
				"TotalHeal",
				"TotalDamageTaken",
				"ACNAAGPOIME",
				"TotalHpRecover",
				"StageId",
				"BattleId",
				"GEHICNBDNFP",
				"AttackTypeDamage",
				"SkillTimes",
				"StageType",
				"JGABGKLPPBA",
				"DelayCumulate",
				"GCBMMMDLDKN",
				"Wave",
				"BIDMILFDKIK",
				"Phase",
				"DFJHDKKMPMM",
				"MLCDMBECDJM",
				"SkillInfo",
				"OKGKMLGGMDO",
				"KEPDCEILLJF",
				"JGHNPEBHBDK",
				"LANOIPJHKAC",
				"AMLAAOLDKCL"
			}, null, null, null, null)
		}));
	}
}
