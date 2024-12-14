using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001054 RID: 4180
	public static class SceneCastSkillCsReqReflection
	{
		// Token: 0x17003475 RID: 13429
		// (get) Token: 0x0600BA19 RID: 47641 RVA: 0x001F3EC1 File Offset: 0x001F20C1
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneCastSkillCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004B6B RID: 19307
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlTY2VuZUNhc3RTa2lsbENzUmVxLnByb3RvGhNTa2lsbEV4dHJhVGFnLnBy",
			"b3RvGhBNb3Rpb25JbmZvLnByb3RvGh1Bc3Npc3RNb25zdGVyRW50aXR5SW5m",
			"by5wcm90bxoRQUxERFBIRkNNR0cucHJvdG8ijAMKE1NjZW5lQ2FzdFNraWxs",
			"Q3NSZXESPAoaYXNzaXN0X21vbnN0ZXJfZW50aXR5X2luZm8YCCADKAsyGC5B",
			"c3Npc3RNb25zdGVyRW50aXR5SW5mbxIlCh1hc3Npc3RfbW9uc3Rlcl9lbnRp",
			"dHlfaWRfbGlzdBgMIAMoDRIdChVhdHRhY2tlZF9ieV9lbnRpdHlfaWQYBCAB",
			"KA0SJAoOZHluYW1pY192YWx1ZXMYCSADKAsyDC5BTEREUEhGQ01HRxIYChBt",
			"YXplX2FiaWxpdHlfc3RyGA8gASgJEhYKDmNhc3RfZW50aXR5X2lkGA0gASgN",
			"EiEKGWhpdF90YXJnZXRfZW50aXR5X2lkX2xpc3QYDiADKA0SEwoLc2tpbGxf",
			"aW5kZXgYAyABKA0SIgoNdGFyZ2V0X21vdGlvbhgKIAEoCzILLk1vdGlvbklu",
			"Zm8SEwoLR09KSEhCTE1BRUIYCyABKA0SKAoQc2tpbGxfZXh0cmFfdGFncxgH",
			"IAMoDjIOLlNraWxsRXh0cmFUYWdCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			SkillExtraTagReflection.Descriptor,
			MotionInfoReflection.Descriptor,
			AssistMonsterEntityInfoReflection.Descriptor,
			ALDDPHFCMGGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneCastSkillCsReq), SceneCastSkillCsReq.Parser, new string[]
			{
				"AssistMonsterEntityInfo",
				"AssistMonsterEntityIdList",
				"AttackedByEntityId",
				"DynamicValues",
				"MazeAbilityStr",
				"CastEntityId",
				"HitTargetEntityIdList",
				"SkillIndex",
				"TargetMotion",
				"GOJHHBLMAEB",
				"SkillExtraTags"
			}, null, null, null, null)
		}));
	}
}
