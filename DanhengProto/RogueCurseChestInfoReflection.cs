using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E6C RID: 3692
	public static class RogueCurseChestInfoReflection
	{
		// Token: 0x17002E80 RID: 11904
		// (get) Token: 0x0600A4BF RID: 42175 RVA: 0x001BAEE5 File Offset: 0x001B90E5
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCurseChestInfoReflection.descriptor;
			}
		}

		// Token: 0x04004354 RID: 17236
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlSb2d1ZUN1cnNlQ2hlc3RJbmZvLnByb3RvIi0KE1JvZ3VlQ3Vyc2VDaGVz" + "dEluZm8SFgoOY3Vyc2VfY2hlc3RfaWQYASABKA1CHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCurseChestInfo), RogueCurseChestInfo.Parser, new string[]
			{
				"CurseChestId"
			}, null, null, null, null)
		}));
	}
}
