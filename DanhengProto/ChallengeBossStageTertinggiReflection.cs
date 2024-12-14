using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001A0 RID: 416
	public static class ChallengeBossStageTertinggiReflection
	{
		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x000363A6 File Offset: 0x000345A6
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeBossStageTertinggiReflection.descriptor;
			}
		}

		// Token: 0x040007EF RID: 2031
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFDaGFsbGVuZ2VCb3NzU3RhZ2VUZXJ0aW5nZ2kucHJvdG8aGUNoYWxsZW5n",
			"ZUxpbmV1cExpc3QucHJvdG8iogEKG0NoYWxsZW5nZUJvc3NTdGFnZVRlcnRp",
			"bmdnaRIQCghidWZmX3R3bxgDIAEoDRIQCghzY29yZV9pZBgMIAEoDRIpCgts",
			"aW5ldXBfbGlzdBgEIAMoCzIULkNoYWxsZW5nZUxpbmV1cExpc3QSEAoIYnVm",
			"Zl9vbmUYCyABKA0SDQoFbGV2ZWwYCiABKA0SEwoLUFBNS0RNSU5CTkgYDyAB",
			"KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChallengeLineupListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossStageTertinggi), ChallengeBossStageTertinggi.Parser, new string[]
			{
				"BuffTwo",
				"ScoreId",
				"LineupList",
				"BuffOne",
				"Level",
				"PPMKDMINBNH"
			}, null, null, null, null)
		}));
	}
}
