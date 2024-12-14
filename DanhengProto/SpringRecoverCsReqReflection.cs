using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200117C RID: 4476
	public static class SpringRecoverCsReqReflection
	{
		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x0600C7C0 RID: 51136 RVA: 0x00217F42 File Offset: 0x00216142
		public static FileDescriptor Descriptor
		{
			get
			{
				return SpringRecoverCsReqReflection.descriptor;
			}
		}

		// Token: 0x040050A9 RID: 20649
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTcHJpbmdSZWNvdmVyQ3NSZXEucHJvdG8iUAoSU3ByaW5nUmVjb3ZlckNz" + "UmVxEhAKCGZsb29yX2lkGAIgASgNEhYKDnByb3BfZW50aXR5X2lkGAogASgN" + "EhAKCHBsYW5lX2lkGAggASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SpringRecoverCsReq), SpringRecoverCsReq.Parser, new string[]
			{
				"FloorId",
				"PropEntityId",
				"PlaneId"
			}, null, null, null, null)
		}));
	}
}
