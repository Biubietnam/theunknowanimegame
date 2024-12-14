using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000324 RID: 804
	public static class ContentPackageDataReflection
	{
		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x0006672F File Offset: 0x0006492F
		public static FileDescriptor Descriptor
		{
			get
			{
				return ContentPackageDataReflection.descriptor;
			}
		}

		// Token: 0x04000ECB RID: 3787
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhDb250ZW50UGFja2FnZURhdGEucHJvdG8aGENvbnRlbnRQYWNrYWdlSW5m",
			"by5wcm90byJfChJDb250ZW50UGFja2FnZURhdGESFgoOY3VyX2NvbnRlbnRf",
			"aWQYDyABKA0SMQoUY29udGVudF9wYWNrYWdlX2xpc3QYDCADKAsyEy5Db250",
			"ZW50UGFja2FnZUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ContentPackageInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ContentPackageData), ContentPackageData.Parser, new string[]
			{
				"CurContentId",
				"ContentPackageList"
			}, null, null, null, null)
		}));
	}
}
