using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200078E RID: 1934
	public static class GetRaidInfoScRspReflection
	{
		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x06005667 RID: 22119 RVA: 0x000E7AE2 File Offset: 0x000E5CE2
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetRaidInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x040021CE RID: 8654
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZHZXRSYWlkSW5mb1NjUnNwLnByb3RvGhZGaW5pc2hlZFJhaWRJbmZvLnBy",
			"b3RvGhNDaGFsbGVuZ2VSYWlkLnByb3RvIqMBChBHZXRSYWlkSW5mb1NjUnNw",
			"EikKEUNoYWxsZW5nZVJhaWRMaXN0GA4gAygLMg4uQ2hhbGxlbmdlUmFpZBIv",
			"ChRGaW5pc2hlZFJhaWRJbmZvTGlzdBgNIAMoCzIRLkZpbmlzaGVkUmFpZElu",
			"Zm8SDwoHcmV0Y29kZRgKIAEoDRIiChpDaGFsbGVuZ2VUYWtlblJld2FyZElk",
			"TGlzdBgCIAMoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			FinishedRaidInfoReflection.Descriptor,
			ChallengeRaidReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetRaidInfoScRsp), GetRaidInfoScRsp.Parser, new string[]
			{
				"ChallengeRaidList",
				"FinishedRaidInfoList",
				"Retcode",
				"ChallengeTakenRewardIdList"
			}, null, null, null, null)
		}));
	}
}
