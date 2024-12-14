using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001A2 RID: 418
	public static class ChallengeBossStatisticsReflection
	{
		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x000369D8 File Offset: 0x00034BD8
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeBossStatisticsReflection.descriptor;
			}
		}

		// Token: 0x040007FF RID: 2047
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1DaGFsbGVuZ2VCb3NzU3RhdGlzdGljcy5wcm90bxohQ2hhbGxlbmdlQm9z",
			"c1N0YWdlVGVydGluZ2dpLnByb3RvImMKF0NoYWxsZW5nZUJvc3NTdGF0aXN0",
			"aWNzEjUKD3N0YWdlX3RlcnRpbmdnaRgHIAEoCzIcLkNoYWxsZW5nZUJvc3NT",
			"dGFnZVRlcnRpbmdnaRIRCglyZWNvcmRfaWQYAiABKA1CHqoCG0VnZ0xpbmsu",
			"RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChallengeBossStageTertinggiReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossStatistics), ChallengeBossStatistics.Parser, new string[]
			{
				"StageTertinggi",
				"RecordId"
			}, null, null, null, null)
		}));
	}
}
