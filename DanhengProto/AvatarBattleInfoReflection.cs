using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000BC RID: 188
	public static class AvatarBattleInfoReflection
	{
		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x000173A9 File Offset: 0x000155A9
		public static FileDescriptor Descriptor
		{
			get
			{
				return AvatarBattleInfoReflection.descriptor;
			}
		}

		// Token: 0x0400031F RID: 799
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZBdmF0YXJCYXR0bGVJbmZvLnByb3RvGhRBdmF0YXJQcm9wZXJ0eS5wcm90",
			"bxoVQXZhdGFyU2tpbGxUcmVlLnByb3RvGhBBdmF0YXJUeXBlLnByb3RvGhZT",
			"a2lsbFVzZVByb3BlcnR5LnByb3RvGhNBYmlsaXR5VXNlU3R0LnByb3RvGhFT",
			"cEFkZFNvdXJjZS5wcm90bxoaQXR0YWNrRGFtYWdlUHJvcGVydHkucHJvdG8a",
			"F0VxdWlwbWVudFByb3BlcnR5LnByb3RvGhFCYXR0bGVSZWxpYy5wcm90byLn",
			"CQoQQXZhdGFyQmF0dGxlSW5mbxIgCgthdmF0YXJfdHlwZRgBIAEoDjILLkF2",
			"YXRhclR5cGUSCgoCaWQYAiABKA0SFAoMYXZhdGFyX2xldmVsGAMgASgNEhMK",
			"C2F2YXRhcl9yYW5rGAQgASgNEhgKEGF2YXRhcl9wcm9tb3Rpb24YBSABKA0S",
			"JgoNYXZhdGFyX3N0YXR1cxgGIAEoCzIPLkF2YXRhclByb3BlcnR5EiYKDGF2",
			"YXRhcl9za2lsbBgHIAMoCzIQLkF2YXRhclNraWxsVHJlZRIsChBhdmF0YXJf",
			"ZXF1aXBtZW50GAggAygLMhIuRXF1aXBtZW50UHJvcGVydHkSEwoLdG90YWxf",
			"dHVybnMYCSABKA0SFAoMdG90YWxfZGFtYWdlGAogASgBEhIKCnRvdGFsX2hl",
			"YWwYCyABKAESGgoSdG90YWxfZGFtYWdlX3Rha2VuGAwgASgBEhgKEHRvdGFs",
			"X2hwX3JlY292ZXIYDSABKAESFQoNdG90YWxfc3BfY29zdBgOIAEoARIQCghz",
			"dGFnZV9pZBgPIAEoDRISCgpzdGFnZV90eXBlGBAgASgNEhoKEnRvdGFsX2Jy",
			"ZWFrX2RhbWFnZRgRIAEoARIxChJhdHRhY2tfdHlwZV9kYW1hZ2UYEiADKAsy",
			"FS5BdHRhY2tEYW1hZ2VQcm9wZXJ0eRI3ChhhdHRhY2tfdHlwZV9icmVha19k",
			"YW1hZ2UYEyADKAsyFS5BdHRhY2tEYW1hZ2VQcm9wZXJ0eRI1ChZhdHRhY2tf",
			"dHlwZV9tYXhfZGFtYWdlGBQgAygLMhUuQXR0YWNrRGFtYWdlUHJvcGVydHkS",
			"JgoLc2tpbGxfdGltZXMYFSADKAsyES5Ta2lsbFVzZVByb3BlcnR5EhYKDmRl",
			"bGF5X2N1bXVsYXRlGBYgASgBEhQKDHRvdGFsX3NwX2FkZBgXIAEoDRIjCg1z",
			"cF9hZGRfc291cmNlGBggAygLMgwuU3BBZGRTb3VyY2USFQoNdG90YWxfYnBf",
			"Y29zdBgZIAEoDRIRCglkaWVfdGltZXMYGiABKA0SFAoMcmV2aXZlX3RpbWVz",
			"GBsgASgNEhMKC2JyZWFrX3RpbWVzGBwgASgNEhMKC2V4dHJhX3R1cm5zGB0g",
			"ASgNEhQKDHRvdGFsX3NoaWVsZBgeIAEoARIaChJ0b3RhbF9zaGllbGRfdGFr",
			"ZW4YHyABKAESGwoTdG90YWxfc2hpZWxkX2RhbWFnZRggIAEoARInCg5pbml0",
			"aWFsX3N0YXR1cxghIAEoCzIPLkF2YXRhclByb3BlcnR5EhwKBnJlbGljcxgi",
			"IAMoCzIMLkJhdHRsZVJlbGljEhIKCmFzc2lzdF91aWQYIyABKA0SKgoLRUxK",
			"R0tLQU5MREkYJCADKAsyFS5BdHRhY2tEYW1hZ2VQcm9wZXJ0eRITCgtDQUxO",
			"UE1BREpCRxglIAEoARITCgtOQk5KTUxMR0ZJTBgmIAEoARITCgtPTEFESUpF",
			"REJQShgnIAEoARITCgtISEpGREdESExPUBgoIAEoARIjCgtQUEFQT0xQUEtC",
			"SBgpIAMoCzIOLkFiaWxpdHlVc2VTdHQSEwoLUEFEQk5NTEFHTU0YKiABKA0S",
			"EwoLS0RGTENKTEFMRUgYKyABKA0SEwoLTklIRkJHR0lLSU0YLCABKAFCHqoC",
			"G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			AvatarPropertyReflection.Descriptor,
			AvatarSkillTreeReflection.Descriptor,
			AvatarTypeReflection.Descriptor,
			SkillUsePropertyReflection.Descriptor,
			AbilityUseSttReflection.Descriptor,
			SpAddSourceReflection.Descriptor,
			AttackDamagePropertyReflection.Descriptor,
			EquipmentPropertyReflection.Descriptor,
			BattleRelicReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AvatarBattleInfo), AvatarBattleInfo.Parser, new string[]
			{
				"AvatarType",
				"Id",
				"AvatarLevel",
				"AvatarRank",
				"AvatarPromotion",
				"AvatarStatus",
				"AvatarSkill",
				"AvatarEquipment",
				"TotalTurns",
				"TotalDamage",
				"TotalHeal",
				"TotalDamageTaken",
				"TotalHpRecover",
				"TotalSpCost",
				"StageId",
				"StageType",
				"TotalBreakDamage",
				"AttackTypeDamage",
				"AttackTypeBreakDamage",
				"AttackTypeMaxDamage",
				"SkillTimes",
				"DelayCumulate",
				"TotalSpAdd",
				"SpAddSource",
				"TotalBpCost",
				"DieTimes",
				"ReviveTimes",
				"BreakTimes",
				"ExtraTurns",
				"TotalShield",
				"TotalShieldTaken",
				"TotalShieldDamage",
				"InitialStatus",
				"Relics",
				"AssistUid",
				"ELJGKKANLDI",
				"CALNPMADJBG",
				"NBNJMLLGFIL",
				"OLADIJEDBPJ",
				"HHJFDGDHLOP",
				"PPAPOLPPKBH",
				"PADBNMLAGMM",
				"KDFLCJLALEH",
				"NIHFBGGIKIM"
			}, null, null, null, null)
		}));
	}
}
