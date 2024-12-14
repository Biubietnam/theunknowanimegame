using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D34 RID: 3380
	public static class PVEBattleResultCsReqReflection
	{
		// Token: 0x17002A90 RID: 10896
		// (get) Token: 0x060096E9 RID: 38633 RVA: 0x00191829 File Offset: 0x0018FA29
		public static FileDescriptor Descriptor
		{
			get
			{
				return PVEBattleResultCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003A90 RID: 14992
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpQVkVCYXR0bGVSZXN1bHRDc1JlcS5wcm90bxoOQmF0dGxlT3AucHJvdG8a",
			"FUJhdHRsZUVuZFN0YXR1cy5wcm90bxoWQmF0dGxlU3RhdGlzdGljcy5wcm90",
			"byLpAwoUUFZFQmF0dGxlUmVzdWx0Q3NSZXESOwoLTEFPSUdCSUNCQU8YBCAD",
			"KAsyJi5QVkVCYXR0bGVSZXN1bHRDc1JlcS5MQU9JR0JJQ0JBT0VudHJ5EhEK",
			"CWNvc3RfdGltZRgCIAEoDRIkCgplbmRfc3RhdHVzGAkgASgOMhAuQmF0dGxl",
			"RW5kU3RhdHVzEhMKC0tORkVHR0RHRkdDGA8gASgIEhMKC3Jlc192ZXJzaW9u",
			"GA0gASgNEhAKCHN0YWdlX2lkGAcgASgNEhUKDWlzX2F1dG9fZmlnaHQYCyAB",
			"KAgSEQoJYmF0dGxlX2lkGAEgASgNEh4KA3N0dBgOIAEoCzIRLkJhdHRsZVN0",
			"YXRpc3RpY3MSGAoQZGVidWdfZXh0cmFfaW5mbxgFIAEoCRIWCg5jbGllbnRf",
			"dmVyc2lvbhgKIAEoDRIaCgdvcF9saXN0GAMgAygLMgkuQmF0dGxlT3ASEwoL",
			"RUpFTFBCR05JTkYYBiABKA0SGgoSdHVybl9zbmFwc2hvdF9oYXNoGAwgASgM",
			"EiIKGmlzX2FpX2NvbnNpZGVyX3VsdHJhX3NraWxsGAggASgIGjIKEExBT0lH",
			"QklDQkFPRW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgNOgI4AUIe",
			"qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			BattleOpReflection.Descriptor,
			BattleEndStatusReflection.Descriptor,
			BattleStatisticsReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PVEBattleResultCsReq), PVEBattleResultCsReq.Parser, new string[]
			{
				"LAOIGBICBAO",
				"CostTime",
				"EndStatus",
				"KNFEGGDGFGC",
				"ResVersion",
				"StageId",
				"IsAutoFight",
				"BattleId",
				"Stt",
				"DebugExtraInfo",
				"ClientVersion",
				"OpList",
				"EJELPBGNINF",
				"TurnSnapshotHash",
				"IsAiConsiderUltraSkill"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
