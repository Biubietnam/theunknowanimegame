using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D62 RID: 3426
	public static class RaidCollectionDataScNotifyReflection
	{
		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x0600991C RID: 39196 RVA: 0x00197926 File Offset: 0x00195B26
		public static FileDescriptor Descriptor
		{
			get
			{
				return RaidCollectionDataScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04003B72 RID: 15218
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSYWlkQ29sbGVjdGlvbkRhdGFTY05vdGlmeS5wcm90bxoRS09HQkRITk1N" + "REYucHJvdG8iQwoaUmFpZENvbGxlY3Rpb25EYXRhU2NOb3RpZnkSJQoPY29s" + "bGVjdGlvbl9pbmZvGAQgASgLMgwuS09HQkRITk1NREZCHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			KOGBDHNMMDFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RaidCollectionDataScNotify), RaidCollectionDataScNotify.Parser, new string[]
			{
				"CollectionInfo"
			}, null, null, null, null)
		}));
	}
}
