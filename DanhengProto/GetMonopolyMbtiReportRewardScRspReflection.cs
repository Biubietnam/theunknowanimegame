using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000736 RID: 1846
	public static class GetMonopolyMbtiReportRewardScRspReflection
	{
		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06005291 RID: 21137 RVA: 0x000DE7C6 File Offset: 0x000DC9C6
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetMonopolyMbtiReportRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x04002078 RID: 8312
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZHZXRNb25vcG9seU1idGlSZXBvcnRSZXdhcmRTY1JzcC5wcm90bxoOSXRl",
			"bUxpc3QucHJvdG8iUwogR2V0TW9ub3BvbHlNYnRpUmVwb3J0UmV3YXJkU2NS",
			"c3ASDwoHcmV0Y29kZRgJIAEoDRIeCgtyZXdhcmRfbGlzdBgIIAEoCzIJLkl0",
			"ZW1MaXN0Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetMonopolyMbtiReportRewardScRsp), GetMonopolyMbtiReportRewardScRsp.Parser, new string[]
			{
				"Retcode",
				"RewardList"
			}, null, null, null, null)
		}));
	}
}
