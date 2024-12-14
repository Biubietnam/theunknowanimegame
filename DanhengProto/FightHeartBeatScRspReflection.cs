using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000538 RID: 1336
	public static class FightHeartBeatScRspReflection
	{
		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06003BA9 RID: 15273 RVA: 0x000A3E1E File Offset: 0x000A201E
		public static FileDescriptor Descriptor
		{
			get
			{
				return FightHeartBeatScRspReflection.descriptor;
			}
		}

		// Token: 0x040017FE RID: 6142
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlGaWdodEhlYXJ0QmVhdFNjUnNwLnByb3RvIlYKE0ZpZ2h0SGVhcnRCZWF0" + "U2NSc3ASFgoOY2xpZW50X3RpbWVfbXMYAyABKAQSDwoHcmV0Y29kZRgOIAEo" + "DRIWCg5zZXJ2ZXJfdGltZV9tcxgCIAEoBEIeqgIbRWdnTGluay5EYW5oZW5n" + "U2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FightHeartBeatScRsp), FightHeartBeatScRsp.Parser, new string[]
			{
				"ClientTimeMs",
				"Retcode",
				"ServerTimeMs"
			}, null, null, null, null)
		}));
	}
}
