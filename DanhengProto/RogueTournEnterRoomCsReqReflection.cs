using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FAA RID: 4010
	public static class RogueTournEnterRoomCsReqReflection
	{
		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x0600B2B7 RID: 45751 RVA: 0x001E02AC File Offset: 0x001DE4AC
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournEnterRoomCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400489D RID: 18589
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Sb2d1ZVRvdXJuRW50ZXJSb29tQ3NSZXEucHJvdG8iSgoYUm9ndWVUb3Vy" + "bkVudGVyUm9vbUNzUmVxEhYKDmN1cl9yb29tX2luZGV4GAYgASgNEhYKDm5l" + "eHRfcm9vbV90eXBlGAkgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnterRoomCsReq), RogueTournEnterRoomCsReq.Parser, new string[]
			{
				"CurRoomIndex",
				"NextRoomType"
			}, null, null, null, null)
		}));
	}
}
