using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000518 RID: 1304
	public static class FeverTimeActivityDataReflection
	{
		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06003A66 RID: 14950 RVA: 0x000A09F5 File Offset: 0x0009EBF5
		public static FileDescriptor Descriptor
		{
			get
			{
				return FeverTimeActivityDataReflection.descriptor;
			}
		}

		// Token: 0x04001777 RID: 6007
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtGZXZlclRpbWVBY3Rpdml0eURhdGEucHJvdG8aGUZldmVyVGltZUJhdHRs",
			"ZVJhbmsucHJvdG8ibAoVRmV2ZXJUaW1lQWN0aXZpdHlEYXRhEhMKC0dISUtH",
			"R0pNSUtGGAkgASgNEhMKC0VQSlBNQk1PS0FKGAYgASgNEikKC0hMSkVMQ05M",
			"SktJGA4gASgOMhQuRmV2ZXJUaW1lQmF0dGxlUmFua0IeqgIbRWdnTGluay5E",
			"YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			FeverTimeBattleRankReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FeverTimeActivityData), FeverTimeActivityData.Parser, new string[]
			{
				"GHIKGGJMIKF",
				"EPJPMBMOKAJ",
				"HLJELCNLJKI"
			}, null, null, null, null)
		}));
	}
}
