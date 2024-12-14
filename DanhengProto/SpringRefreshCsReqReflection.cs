using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001184 RID: 4484
	public static class SpringRefreshCsReqReflection
	{
		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x0600C82A RID: 51242 RVA: 0x002191C5 File Offset: 0x002173C5
		public static FileDescriptor Descriptor
		{
			get
			{
				return SpringRefreshCsReqReflection.descriptor;
			}
		}

		// Token: 0x040050D3 RID: 20691
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTcHJpbmdSZWZyZXNoQ3NSZXEucHJvdG8iUAoSU3ByaW5nUmVmcmVzaENz" + "UmVxEhAKCGZsb29yX2lkGA0gASgNEhYKDnByb3BfZW50aXR5X2lkGAUgASgN" + "EhAKCHBsYW5lX2lkGAogASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SpringRefreshCsReq), SpringRefreshCsReq.Parser, new string[]
			{
				"FloorId",
				"PropEntityId",
				"PlaneId"
			}, null, null, null, null)
		}));
	}
}
