using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000104 RID: 260
	public static class BattleStatisticsReflection
	{
		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x000223C1 File Offset: 0x000205C1
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleStatisticsReflection.descriptor;
			}
		}

		// Token: 0x040004E5 RID: 1253
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZCYXR0bGVTdGF0aXN0aWNzLnByb3RvGhFNS0dJRUNLR0pFUC5wcm90bxoR",
			"S0ZFQ01LTE9CTUYucHJvdG8aEUdPRkxKS01IUE1QLnByb3RvGhVCYXR0bGVF",
			"bmRSZWFzb24ucHJvdG8aFkJhdHRsZVRhcmdldExpc3QucHJvdG8aEUhKSkRG",
			"Qk9ER0ZELnByb3RvGhtCYXR0bGVFdmVudEJhdHRsZUluZm8ucHJvdG8aFkF2",
			"YXRhckJhdHRsZUluZm8ucHJvdG8aF01vbnN0ZXJCYXR0bGVJbmZvLnByb3Rv",
			"GhFFT0xPRkxHSkNJUC5wcm90bxoRS0RESk5PUEhQSkYucHJvdG8aEURQSFBB",
			"TUtLTUhQLnByb3RvGhtFdm9sdmVCdWlsZEJhdHRsZUluZm8ucHJvdG8aEU5H",
			"SE9MSUtJRVBCLnByb3RvGhFITE9KRkNEUEdCRS5wcm90bxoRRUhPSkxKTUdP",
			"R0wucHJvdG8inQkKEEJhdHRsZVN0YXRpc3RpY3MSGgoSdG90YWxfYmF0dGxl",
			"X3R1cm5zGAEgASgNEhgKEHRvdGFsX2F1dG9fdHVybnMYAiABKA0SFgoOYXZh",
			"dGFyX2lkX2xpc3QYAyADKA0SEQoJdWx0cmFfY250GAQgASgNEhwKFHRvdGFs",
			"X2RlbGF5X2N1bXVsYXRlGAUgASgBEhEKCWNvc3RfdGltZRgGIAEoARItChJi",
			"YXR0bGVfYXZhdGFyX2xpc3QYByADKAsyES5BdmF0YXJCYXR0bGVJbmZvEigK",
			"DG1vbnN0ZXJfbGlzdBgIIAMoCzISLk1vbnN0ZXJCYXR0bGVJbmZvEhEKCXJv",
			"dW5kX2NudBgJIAEoDRIYChBjb2Nvb25fZGVhZF93YXZlGAogASgNEhsKE2F2",
			"YXRhcl9iYXR0bGVfdHVybnMYCyABKA0SHAoUbW9uc3Rlcl9iYXR0bGVfdHVy",
			"bnMYDCABKA0SOgoNY3VzdG9tX3ZhbHVlcxgNIAMoCzIjLkJhdHRsZVN0YXRp",
			"c3RpY3MuQ3VzdG9tVmFsdWVzRW50cnkSFwoPY2hhbGxlbmdlX3Njb3JlGA4g",
			"ASgNEisKC1BEQ0lBTU9MSUdQGBAgAygLMhYuQmF0dGxlRXZlbnRCYXR0bGVJ",
			"bmZvEiQKCmVuZF9yZWFzb24YEyABKA4yEC5CYXR0bGVFbmRSZWFzb24SIQoL",
			"Qk1JSUdCSUZISEwYFSADKAsyDC5HT0ZMSktNSFBNUBITCgtQTUpMQkVDQk9E",
			"RBgWIAMoBRIhCgtCQlBDTklPQklCRxgXIAMoCzIMLkVIT0pMSk1HT0dMEiEK",
			"C0NDTUpLRElOSkREGBogAygLMgwuTkdIT0xJS0lFUEISIQoLREtJQkJQSkZE",
			"T0kYGyADKAsyDC5ITE9KRkNEUEdCRRJDChJiYXR0bGVfdGFyZ2V0X2luZm8Y",
			"HCADKAsyJy5CYXR0bGVTdGF0aXN0aWNzLkJhdHRsZVRhcmdldEluZm9FbnRy",
			"eRIhCgtLSUFISUFIUFBMRRgdIAMoCzIMLkVPTE9GTEdKQ0lQEisKC09BSERP",
			"TEhCUEZLGB4gASgLMhYuRXZvbHZlQnVpbGRCYXR0bGVJbmZvEiEKC0RGTkdI",
			"TkVISUlHGB8gASgLMgwuSEpKREZCT0RHRkQSEwoLUElJTkhDSU1PR0QYICAB",
			"KAgSIQoLTEFPSk9QQkVJQkMYISADKAsyDC5NS0dJRUNLR0pFUBIhCgtMTE9F",
			"QktLTE5PQhgiIAMoCzIMLkRQSFBBTUtLTUhQEhMKC0NMTkFCRkRQSUtKGCMg",
			"ASgNEiEKC05GSktMT0RGSUlMGCQgASgLMgwuS0ZFQ01LTE9CTUYSIQoLR0ND",
			"Sk9CTk5GQ0EYJSABKAsyDC5LRERKTk9QSFBKRhozChFDdXN0b21WYWx1ZXNF",
			"bnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAI6AjgBGkoKFUJhdHRs",
			"ZVRhcmdldEluZm9FbnRyeRILCgNrZXkYASABKA0SIAoFdmFsdWUYAiABKAsy",
			"ES5CYXR0bGVUYXJnZXRMaXN0OgI4AUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			MKGIECKGJEPReflection.Descriptor,
			KFECMKLOBMFReflection.Descriptor,
			GOFLJKMHPMPReflection.Descriptor,
			BattleEndReasonReflection.Descriptor,
			BattleTargetListReflection.Descriptor,
			HJJDFBODGFDReflection.Descriptor,
			BattleEventBattleInfoReflection.Descriptor,
			AvatarBattleInfoReflection.Descriptor,
			MonsterBattleInfoReflection.Descriptor,
			EOLOFLGJCIPReflection.Descriptor,
			KDDJNOPHPJFReflection.Descriptor,
			DPHPAMKKMHPReflection.Descriptor,
			EvolveBuildBattleInfoReflection.Descriptor,
			NGHOLIKIEPBReflection.Descriptor,
			HLOJFCDPGBEReflection.Descriptor,
			EHOJLJMGOGLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleStatistics), BattleStatistics.Parser, new string[]
			{
				"TotalBattleTurns",
				"TotalAutoTurns",
				"AvatarIdList",
				"UltraCnt",
				"TotalDelayCumulate",
				"CostTime",
				"BattleAvatarList",
				"MonsterList",
				"RoundCnt",
				"CocoonDeadWave",
				"AvatarBattleTurns",
				"MonsterBattleTurns",
				"CustomValues",
				"ChallengeScore",
				"PDCIAMOLIGP",
				"EndReason",
				"BMIIGBIFHHL",
				"PMJLBECBODD",
				"BBPCNIOBIBG",
				"CCMJKDINJDD",
				"DKIBBPJFDOI",
				"BattleTargetInfo",
				"KIAHIAHPPLE",
				"OAHDOLHBPFK",
				"DFNGHNEHIIG",
				"PIINHCIMOGD",
				"LAOJOPBEIBC",
				"LLOEBKKLNOB",
				"CLNABFDPIKJ",
				"NFJKLODFIIL",
				"GCCJOBNNFCA"
			}, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
