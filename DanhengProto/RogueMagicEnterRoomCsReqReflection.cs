using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EC8 RID: 3784
	public static class RogueMagicEnterRoomCsReqReflection
	{
		// Token: 0x17002FC3 RID: 12227
		// (get) Token: 0x0600A922 RID: 43298 RVA: 0x001C7778 File Offset: 0x001C5978
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicEnterRoomCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400450E RID: 17678
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Sb2d1ZU1hZ2ljRW50ZXJSb29tQ3NSZXEucHJvdG8iSgoYUm9ndWVNYWdp" + "Y0VudGVyUm9vbUNzUmVxEhYKDmN1cl9yb29tX2luZGV4GAUgASgNEhYKDm5l" + "eHRfcm9vbV90eXBlGAMgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicEnterRoomCsReq), RogueMagicEnterRoomCsReq.Parser, new string[]
			{
				"CurRoomIndex",
				"NextRoomType"
			}, null, null, null, null)
		}));
	}
}
