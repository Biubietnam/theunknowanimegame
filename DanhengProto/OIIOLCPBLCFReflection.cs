using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C52 RID: 3154
	public static class OIIOLCPBLCFReflection
	{
		// Token: 0x17002753 RID: 10067
		// (get) Token: 0x06008C0B RID: 35851 RVA: 0x001720EA File Offset: 0x001702EA
		public static FileDescriptor Descriptor
		{
			get
			{
				return OIIOLCPBLCFReflection.descriptor;
			}
		}

		// Token: 0x040035C2 RID: 13762
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFPSUlPTENQQkxDRi5wcm90bxoPU2NlbmVJbmZvLnByb3RvGhBMaW5ldXBJ",
			"bmZvLnByb3RvInEKC09JSU9MQ1BCTENGEg8KB3JhaWRfaWQYDCABKA0SEwoL",
			"d29ybGRfbGV2ZWwYCCABKA0SGwoGbGluZXVwGAsgASgLMgsuTGluZXVwSW5m",
			"bxIfCgtQSkhNR0dHS0NNSxgCIAEoCzIKLlNjZW5lSW5mb0IeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			SceneInfoReflection.Descriptor,
			LineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(OIIOLCPBLCF), OIIOLCPBLCF.Parser, new string[]
			{
				"RaidId",
				"WorldLevel",
				"Lineup",
				"PJHMGGGKCMK"
			}, null, null, null, null)
		}));
	}
}
