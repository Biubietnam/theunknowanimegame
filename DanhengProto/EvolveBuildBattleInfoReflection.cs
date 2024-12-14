using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200049E RID: 1182
	public static class EvolveBuildBattleInfoReflection
	{
		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x060034B3 RID: 13491 RVA: 0x00090A28 File Offset: 0x0008EC28
		public static FileDescriptor Descriptor
		{
			get
			{
				return EvolveBuildBattleInfoReflection.descriptor;
			}
		}

		// Token: 0x040014E9 RID: 5353
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtFdm9sdmVCdWlsZEJhdHRsZUluZm8ucHJvdG8aEUhIUFBOTkdHUElBLnBy",
			"b3RvGhFCQkRGTENKSUVFSi5wcm90bxoRRkVQSUFHR0tOS04ucHJvdG8aEUxD",
			"TEpNSkFGSE9FLnByb3RvGh9Fdm9sdmVCdWlsZEdlYXJEYW1hZ2VJbmZvLnBy",
			"b3RvIvgEChVFdm9sdmVCdWlsZEJhdHRsZUluZm8SEgoKQ3VyTGV2ZWxJZBgB",
			"IAEoDRIRCglDdXJQZXJpb2QYAiABKA0SDwoHQ3VyQ29pbhgDIAEoDRIkCg5X",
			"ZWFwb25TbG90TGlzdBgEIAMoCzIMLkhIUFBOTkdHUElBEicKEUFjY2Vzc29y",
			"eVNsb3RMaXN0GAUgAygLMgwuSEhQUE5OR0dQSUESEwoLQmFuR2Vhckxpc3QY",
			"BiADKA0SIAoKQ29sbGVjdGlvbhgHIAEoCzIMLkZFUElBR0dLTktOEhcKD0Fs",
			"bG93ZWRHZWFyTGlzdBgIIAMoDRIOCgZDdXJFeHAYCSABKA0SEQoJQ3VyUmVy",
			"b2xsGAogASgNEhoKEkN1clRyZWFzdXJlTWlzc0NudBgLIAEoDRIUCgxQZXJp",
			"b2RJZExpc3QYDCADKA0SFgoOQ3VyR2Vhckxvc3RDbnQYDSABKA0SDwoHQ3Vy",
			"V2F2ZRgOIAEoDRIaChJJc1VubG9ja0dlYXJSZXJvbGwYDyABKAgSFwoPSXNV",
			"bmxvY2tHZWFyQmFuGBAgASgIEh4KCENhcmRMaXN0GBEgAygLMgwuTENMSk1K",
			"QUZIT0USMgoOR2VhckRhbWFnZUxpc3QYEiADKAsyGi5Fdm9sdmVCdWlsZEdl",
			"YXJEYW1hZ2VJbmZvEhIKClN0YXRQYXJhbXMYEyADKA0SEAoISXNHaXZldXAY",
			"FCABKAgSGQoRQ3VyVW51c2VkUm91bmRDbnQYFSABKA0SIQoLU3RhdExvZ0lu",
			"Zm8YFiABKAsyDC5CQkRGTENKSUVFShIdChVQZXJpb2RGaXJzdFJhbmRvbVNl",
			"ZWQYFyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			HHPPNNGGPIAReflection.Descriptor,
			BBDFLCJIEEJReflection.Descriptor,
			FEPIAGGKNKNReflection.Descriptor,
			LCLJMJAFHOEReflection.Descriptor,
			EvolveBuildGearDamageInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildBattleInfo), EvolveBuildBattleInfo.Parser, new string[]
			{
				"CurLevelId",
				"CurPeriod",
				"CurCoin",
				"WeaponSlotList",
				"AccessorySlotList",
				"BanGearList",
				"Collection",
				"AllowedGearList",
				"CurExp",
				"CurReroll",
				"CurTreasureMissCnt",
				"PeriodIdList",
				"CurGearLostCnt",
				"CurWave",
				"IsUnlockGearReroll",
				"IsUnlockGearBan",
				"CardList",
				"GearDamageList",
				"StatParams",
				"IsGiveup",
				"CurUnusedRoundCnt",
				"StatLogInfo",
				"PeriodFirstRandomSeed"
			}, null, null, null, null)
		}));
	}
}
