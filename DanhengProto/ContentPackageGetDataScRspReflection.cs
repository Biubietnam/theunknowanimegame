using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000328 RID: 808
	public static class ContentPackageGetDataScRspReflection
	{
		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x00066C4E File Offset: 0x00064E4E
		public static FileDescriptor Descriptor
		{
			get
			{
				return ContentPackageGetDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04000ED6 RID: 3798
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBDb250ZW50UGFja2FnZUdldERhdGFTY1JzcC5wcm90bxoYQ29udGVudFBh",
			"Y2thZ2VEYXRhLnByb3RvIlAKGkNvbnRlbnRQYWNrYWdlR2V0RGF0YVNjUnNw",
			"EiEKBGRhdGEYBCABKAsyEy5Db250ZW50UGFja2FnZURhdGESDwoHcmV0Y29k",
			"ZRgLIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			ContentPackageDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ContentPackageGetDataScRsp), ContentPackageGetDataScRsp.Parser, new string[]
			{
				"Data",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
