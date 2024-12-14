using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003A8 RID: 936
	public static class DispatchReflection
	{
		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06002995 RID: 10645 RVA: 0x000737ED File Offset: 0x000719ED
		public static FileDescriptor Descriptor
		{
			get
			{
				return DispatchReflection.descriptor;
			}
		}

		// Token: 0x040010C2 RID: 4290
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Cg5EaXNwYXRjaC5wcm90bxoQUmVnaW9uSW5mby5wcm90byJ8CghEaXNwYXRj",
			"aBIPCgdyZXRjb2RlGAEgASgNEgsKA21zZxgCIAEoCRIdChV0b3Bfc2V2ZXJf",
			"cmVnaW9uX25hbWUYAyABKAkSIAoLcmVnaW9uX2xpc3QYBCADKAsyCy5SZWdp",
			"b25JbmZvEhEKCXN0b3BfZGVzYxgFIAEoCUIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RegionInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Dispatch), Dispatch.Parser, new string[]
			{
				"Retcode",
				"Msg",
				"TopSeverRegionName",
				"RegionList",
				"StopDesc"
			}, null, null, null, null)
		}));
	}
}
