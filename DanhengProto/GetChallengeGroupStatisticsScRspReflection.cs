using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200063E RID: 1598
	public static class GetChallengeGroupStatisticsScRspReflection
	{
		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x060047BB RID: 18363 RVA: 0x000C44A2 File Offset: 0x000C26A2
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetChallengeGroupStatisticsScRspReflection.descriptor;
			}
		}

		// Token: 0x04001CB1 RID: 7345
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZHZXRDaGFsbGVuZ2VHcm91cFN0YXRpc3RpY3NTY1JzcC5wcm90bxoZQ2hh",
			"bGxlbmdlU3RhdGlzdGljcy5wcm90bxoeQ2hhbGxlbmdlU3RvcnlTdGF0aXN0",
			"aWNzLnByb3RvGh1DaGFsbGVuZ2VCb3NzU3RhdGlzdGljcy5wcm90byLvAQog",
			"R2V0Q2hhbGxlbmdlR3JvdXBTdGF0aXN0aWNzU2NSc3ASDwoHcmV0Y29kZRgI",
			"IAEoDRIQCghncm91cF9pZBgOIAEoDRIxChFjaGFsbGVuZ2VfZGVmYXVsdBgM",
			"IAEoCzIULkNoYWxsZW5nZVN0YXRpc3RpY3NIABI0Cg9jaGFsbGVuZ2Vfc3Rv",
			"cnkYBCABKAsyGS5DaGFsbGVuZ2VTdG9yeVN0YXRpc3RpY3NIABIyCg5jaGFs",
			"bGVuZ2VfYm9zcxgPIAEoCzIYLkNoYWxsZW5nZUJvc3NTdGF0aXN0aWNzSABC",
			"CwoJY2hhbGxlbmdlQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChallengeStatisticsReflection.Descriptor,
			ChallengeStoryStatisticsReflection.Descriptor,
			ChallengeBossStatisticsReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetChallengeGroupStatisticsScRsp), GetChallengeGroupStatisticsScRsp.Parser, new string[]
			{
				"Retcode",
				"GroupId",
				"ChallengeDefault",
				"ChallengeStory",
				"ChallengeBoss"
			}, new string[]
			{
				"Challenge"
			}, null, null, null)
		}));
	}
}
