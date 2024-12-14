using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FA2 RID: 4002
	public static class RogueTournEnterLayerCsReqReflection
	{
		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x0600B256 RID: 45654 RVA: 0x001DF28E File Offset: 0x001DD48E
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournEnterLayerCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400487A RID: 18554
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Sb2d1ZVRvdXJuRW50ZXJMYXllckNzUmVxLnByb3RvIkwKGVJvZ3VlVG91" + "cm5FbnRlckxheWVyQ3NSZXESFwoPY3VyX2xldmVsX2luZGV4GA0gASgNEhYK" + "Dm5leHRfcm9vbV90eXBlGAwgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnterLayerCsReq), RogueTournEnterLayerCsReq.Parser, new string[]
			{
				"CurLevelIndex",
				"NextRoomType"
			}, null, null, null, null)
		}));
	}
}
