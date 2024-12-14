using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200032A RID: 810
	public static class ContentPackageInfoReflection
	{
		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x00067000 File Offset: 0x00065200
		public static FileDescriptor Descriptor
		{
			get
			{
				return ContentPackageInfoReflection.descriptor;
			}
		}

		// Token: 0x04000EDD RID: 3805
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDb250ZW50UGFja2FnZUluZm8ucHJvdG8aGkNvbnRlbnRQYWNrYWdlU3Rh" + "dHVzLnByb3RvIk8KEkNvbnRlbnRQYWNrYWdlSW5mbxISCgpjb250ZW50X2lk" + "GAEgASgNEiUKBnN0YXR1cxgJIAEoDjIVLkNvbnRlbnRQYWNrYWdlU3RhdHVz" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			ContentPackageStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ContentPackageInfo), ContentPackageInfo.Parser, new string[]
			{
				"ContentId",
				"Status"
			}, null, null, null, null)
		}));
	}
}
