using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012C8 RID: 4808
	public static class TakeChallengeRewardScRspReflection
	{
		// Token: 0x17003C4C RID: 15436
		// (get) Token: 0x0600D67D RID: 54909 RVA: 0x0023C166 File Offset: 0x0023A366
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeChallengeRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x040055A4 RID: 21924
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5UYWtlQ2hhbGxlbmdlUmV3YXJkU2NSc3AucHJvdG8aHlRha2VuQ2hhbGxl",
			"bmdlUmV3YXJkSW5mby5wcm90byJzChhUYWtlQ2hhbGxlbmdlUmV3YXJkU2NS",
			"c3ASDwoHcmV0Y29kZRgEIAEoDRIQCghncm91cF9pZBgOIAEoDRI0ChF0YWtl",
			"bl9yZXdhcmRfbGlzdBgNIAMoCzIZLlRha2VuQ2hhbGxlbmdlUmV3YXJkSW5m",
			"b0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			TakenChallengeRewardInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeChallengeRewardScRsp), TakeChallengeRewardScRsp.Parser, new string[]
			{
				"Retcode",
				"GroupId",
				"TakenRewardList"
			}, null, null, null, null)
		}));
	}
}
