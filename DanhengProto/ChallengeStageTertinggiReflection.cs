using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001B6 RID: 438
	public static class ChallengeStageTertinggiReflection
	{
		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x0003902D File Offset: 0x0003722D
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeStageTertinggiReflection.descriptor;
			}
		}

		// Token: 0x04000851 RID: 2129
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1DaGFsbGVuZ2VTdGFnZVRlcnRpbmdnaS5wcm90bxoZQ2hhbGxlbmdlTGlu",
			"ZXVwTGlzdC5wcm90byJ9ChdDaGFsbGVuZ2VTdGFnZVRlcnRpbmdnaRITCgtQ",
			"UE1LRE1JTkJOSBgOIAEoDRIpCgtsaW5ldXBfbGlzdBgLIAMoCzIULkNoYWxs",
			"ZW5nZUxpbmV1cExpc3QSDQoFbGV2ZWwYByABKA0SEwoLcm91bmRfY291bnQY",
			"DCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChallengeLineupListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeStageTertinggi), ChallengeStageTertinggi.Parser, new string[]
			{
				"PPMKDMINBNH",
				"LineupList",
				"Level",
				"RoundCount"
			}, null, null, null, null)
		}));
	}
}
