using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009B0 RID: 2480
	public static class KilledPunkLordMonsterInfoReflection
	{
		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x06006ED6 RID: 28374 RVA: 0x00127FF5 File Offset: 0x001261F5
		public static FileDescriptor Descriptor
		{
			get
			{
				return KilledPunkLordMonsterInfoReflection.descriptor;
			}
		}

		// Token: 0x04002A92 RID: 10898
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9LaWxsZWRQdW5rTG9yZE1vbnN0ZXJJbmZvLnByb3RvIpYBChlLaWxsZWRQ",
			"dW5rTG9yZE1vbnN0ZXJJbmZvEhMKC09FRkZMQkZIQ0NBGA0gASgNEhEKCWNv",
			"bmZpZ19pZBgEIAEoDRISCgptb25zdGVyX2lkGA8gASgNEhMKC2NyZWF0ZV90",
			"aW1lGAkgASgDEhMKC3dvcmxkX2xldmVsGAYgASgNEhMKC01NQkFPQ0dGQkxJ",
			"GAUgASgIQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(KilledPunkLordMonsterInfo), KilledPunkLordMonsterInfo.Parser, new string[]
			{
				"OEFFLBFHCCA",
				"ConfigId",
				"MonsterId",
				"CreateTime",
				"WorldLevel",
				"MMBAOCGFBLI"
			}, null, null, null, null)
		}));
	}
}
