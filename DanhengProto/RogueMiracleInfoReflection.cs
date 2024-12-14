using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F3E RID: 3902
	public static class RogueMiracleInfoReflection
	{
		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x0600AE2B RID: 44587 RVA: 0x001D473C File Offset: 0x001D293C
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMiracleInfoReflection.descriptor;
			}
		}

		// Token: 0x040046EA RID: 18154
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZSb2d1ZU1pcmFjbGVJbmZvLnByb3RvGhJSb2d1ZU1pcmFjbGUucHJvdG8i",
			"YQoQUm9ndWVNaXJhY2xlSW5mbxITCgtFS05HQ0hET0tDSxgOIAEoDRIjCgxt",
			"aXJhY2xlX2xpc3QYCiADKAsyDS5Sb2d1ZU1pcmFjbGUSEwoLUE1QSE5MTEhL",
			"SkQYCSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			RogueMiracleReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMiracleInfo), RogueMiracleInfo.Parser, new string[]
			{
				"EKNGCHDOKCK",
				"MiracleList",
				"PMPHNLLHKJD"
			}, null, null, null, null)
		}));
	}
}
