using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000110 RID: 272
	public static class BCECCMOADLEReflection
	{
		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x00024FFD File Offset: 0x000231FD
		public static FileDescriptor Descriptor
		{
			get
			{
				return BCECCMOADLEReflection.descriptor;
			}
		}

		// Token: 0x0400055C RID: 1372
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFCQ0VDQ01PQURMRS5wcm90bxoSUGxhdGZvcm1UeXBlLnByb3RvIqwBCgtC",
			"Q0VDQ01PQURMRRILCgN1aWQYASABKA0SDQoFbGV2ZWwYAiABKA0SEAoIbmlj",
			"a25hbWUYAyABKAkSEwoLTE1ORE9HQUZPR0MYBCABKA0SHwoIcGxhdGZvcm0Y",
			"BSABKA4yDS5QbGF0Zm9ybVR5cGUSEwoLRkxGS0NJSENFTkYYBiABKAkSEwoL",
			"S0RDTE9DQVBCR0UYByABKAkSDwoHdmVyc2lvbhgIIAEoBEIeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			PlatformTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BCECCMOADLE), BCECCMOADLE.Parser, new string[]
			{
				"Uid",
				"Level",
				"Nickname",
				"LMNDOGAFOGC",
				"Platform",
				"FLFKCIHCENF",
				"KDCLOCAPBGE",
				"Version"
			}, null, null, null, null)
		}));
	}
}
