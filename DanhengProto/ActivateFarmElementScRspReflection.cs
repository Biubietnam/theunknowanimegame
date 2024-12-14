using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000032 RID: 50
	public static class ActivateFarmElementScRspReflection
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000659D File Offset: 0x0000479D
		public static FileDescriptor Descriptor
		{
			get
			{
				return ActivateFarmElementScRspReflection.descriptor;
			}
		}

		// Token: 0x040000A4 RID: 164
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5BY3RpdmF0ZUZhcm1FbGVtZW50U2NSc3AucHJvdG8iUwoYQWN0aXZhdGVG" + "YXJtRWxlbWVudFNjUnNwEg8KB3JldGNvZGUYDyABKA0SEQoJZW50aXR5X2lk" + "GA4gASgNEhMKC3dvcmxkX2xldmVsGAogASgNQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ActivateFarmElementScRsp), ActivateFarmElementScRsp.Parser, new string[]
			{
				"Retcode",
				"EntityId",
				"WorldLevel"
			}, null, null, null, null)
		}));
	}
}
