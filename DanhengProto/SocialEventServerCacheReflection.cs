using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001156 RID: 4438
	public static class SocialEventServerCacheReflection
	{
		// Token: 0x170037D8 RID: 14296
		// (get) Token: 0x0600C602 RID: 50690 RVA: 0x00213793 File Offset: 0x00211993
		public static FileDescriptor Descriptor
		{
			get
			{
				return SocialEventServerCacheReflection.descriptor;
			}
		}

		// Token: 0x04004FFD RID: 20477
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTb2NpYWxFdmVudFNlcnZlckNhY2hlLnByb3RvIlYKFlNvY2lhbEV2ZW50" + "U2VydmVyQ2FjaGUSCgoCaWQYAyABKA0SDwoHQWRkQ29pbhgNIAEoDRIPCgdT" + "dWJDb2luGAsgASgNEg4KBlNyY1VpZBgHIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SocialEventServerCache), SocialEventServerCache.Parser, new string[]
			{
				"Id",
				"AddCoin",
				"SubCoin",
				"SrcUid"
			}, null, null, null, null)
		}));
	}
}
