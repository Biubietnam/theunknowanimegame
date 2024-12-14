using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000574 RID: 1396
	public static class FinishedRaidInfoReflection
	{
		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06003E4D RID: 15949 RVA: 0x000AA4F9 File Offset: 0x000A86F9
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishedRaidInfoReflection.descriptor;
			}
		}

		// Token: 0x040018DD RID: 6365
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZGaW5pc2hlZFJhaWRJbmZvLnByb3RvIk0KEEZpbmlzaGVkUmFpZEluZm8S" + "EwoLd29ybGRfbGV2ZWwYAyABKA0SDwoHcmFpZF9pZBgJIAEoDRITCgtBSExQ" + "SFBFRk5JShgPIAMoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishedRaidInfo), FinishedRaidInfo.Parser, new string[]
			{
				"WorldLevel",
				"RaidId",
				"AHLPHPEFNIJ"
			}, null, null, null, null)
		}));
	}
}
