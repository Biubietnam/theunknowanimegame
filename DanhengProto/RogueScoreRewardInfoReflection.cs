using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F70 RID: 3952
	public static class RogueScoreRewardInfoReflection
	{
		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x0600B021 RID: 45089 RVA: 0x001D91FF File Offset: 0x001D73FF
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueScoreRewardInfoReflection.descriptor;
			}
		}

		// Token: 0x040047A1 RID: 18337
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZVNjb3JlUmV3YXJkSW5mby5wcm90byLPAQoUUm9ndWVTY29yZVJl",
			"d2FyZEluZm8SFQoNZXhwbG9yZV9zY29yZRgHIAEoDRIfChdoYXNfdGFrZW5f",
			"aW5pdGlhbF9zY29yZRgFIAEoCBIZChFyZXdhcmRfYmVnaW5fdGltZRgMIAEo",
			"AxIWCg5wb29sX3JlZnJlc2hlZBgNIAEoCBIPCgdwb29sX2lkGAQgASgNEiIK",
			"GnRha2VuX25vcm1hbF9mcmVlX3Jvd19saXN0GAEgAygNEhcKD3Jld2FyZF9l",
			"bmRfdGltZRgOIAEoA0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueScoreRewardInfo), RogueScoreRewardInfo.Parser, new string[]
			{
				"ExploreScore",
				"HasTakenInitialScore",
				"RewardBeginTime",
				"PoolRefreshed",
				"PoolId",
				"TakenNormalFreeRowList",
				"RewardEndTime"
			}, null, null, null, null)
		}));
	}
}
