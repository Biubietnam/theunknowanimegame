using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D96 RID: 3478
	public static class RegionInfoReflection
	{
		// Token: 0x17002BD1 RID: 11217
		// (get) Token: 0x06009B5A RID: 39770 RVA: 0x0019D536 File Offset: 0x0019B736
		public static FileDescriptor Descriptor
		{
			get
			{
				return RegionInfoReflection.descriptor;
			}
		}

		// Token: 0x04003C47 RID: 15431
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChBSZWdpb25JbmZvLnByb3RvInQKClJlZ2lvbkluZm8SDAoEbmFtZRgBIAEo" + "CRINCgV0aXRsZRgCIAEoCRIUCgxkaXNwYXRjaF91cmwYAyABKAkSEAoIZW52" + "X3R5cGUYBCABKAkSFAoMZGlzcGxheV9uYW1lGAUgASgJEgsKA21zZxgGIAEo" + "CUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RegionInfo), RegionInfo.Parser, new string[]
			{
				"Name",
				"Title",
				"DispatchUrl",
				"EnvType",
				"DisplayName",
				"Msg"
			}, null, null, null, null)
		}));
	}
}
