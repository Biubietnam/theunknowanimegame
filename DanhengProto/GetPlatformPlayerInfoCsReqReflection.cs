using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000760 RID: 1888
	public static class GetPlatformPlayerInfoCsReqReflection
	{
		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x06005467 RID: 21607 RVA: 0x000E2FB1 File Offset: 0x000E11B1
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetPlatformPlayerInfoCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002124 RID: 8484
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHZXRQbGF0Zm9ybVBsYXllckluZm9Dc1JlcS5wcm90bxoSUGxhdGZvcm1U" + "eXBlLnByb3RvIlIKGkdldFBsYXRmb3JtUGxheWVySW5mb0NzUmVxEh8KCHBs" + "YXRmb3JtGAQgASgOMg0uUGxhdGZvcm1UeXBlEhMKC0VFT0ZGRERNR0lCGAEg" + "AygJQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			PlatformTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetPlatformPlayerInfoCsReq), GetPlatformPlayerInfoCsReq.Parser, new string[]
			{
				"Platform",
				"EEOFFDDMGIB"
			}, null, null, null, null)
		}));
	}
}
