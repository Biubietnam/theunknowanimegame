using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200012C RID: 300
	public static class BlackInfoReflection
	{
		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00028981 File Offset: 0x00026B81
		public static FileDescriptor Descriptor
		{
			get
			{
				return BlackInfoReflection.descriptor;
			}
		}

		// Token: 0x040005DF RID: 1503
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9CbGFja0luZm8ucHJvdG8iWAoJQmxhY2tJbmZvEhIKCmJlZ2luX3RpbWUY" + "ASABKAMSEAoIZW5kX3RpbWUYAiABKAMSEwoLbGltaXRfbGV2ZWwYAyABKA0S" + "EAoIYmFuX3R5cGUYBCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BlackInfo), BlackInfo.Parser, new string[]
			{
				"BeginTime",
				"EndTime",
				"LimitLevel",
				"BanType"
			}, null, null, null, null)
		}));
	}
}
