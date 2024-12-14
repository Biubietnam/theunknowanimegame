using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200032E RID: 814
	public static class ContentPackageSyncDataScNotifyReflection
	{
		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x000673BF File Offset: 0x000655BF
		public static FileDescriptor Descriptor
		{
			get
			{
				return ContentPackageSyncDataScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000EEB RID: 3819
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRDb250ZW50UGFja2FnZVN5bmNEYXRhU2NOb3RpZnkucHJvdG8aGENvbnRl" + "bnRQYWNrYWdlRGF0YS5wcm90byJDCh5Db250ZW50UGFja2FnZVN5bmNEYXRh" + "U2NOb3RpZnkSIQoEZGF0YRgBIAEoCzITLkNvbnRlbnRQYWNrYWdlRGF0YUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ContentPackageDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ContentPackageSyncDataScNotify), ContentPackageSyncDataScNotify.Parser, new string[]
			{
				"Data"
			}, null, null, null, null)
		}));
	}
}
