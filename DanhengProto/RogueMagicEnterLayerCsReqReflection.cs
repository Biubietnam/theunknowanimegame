using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EC4 RID: 3780
	public static class RogueMagicEnterLayerCsReqReflection
	{
		// Token: 0x17002FB7 RID: 12215
		// (get) Token: 0x0600A8F4 RID: 43252 RVA: 0x001C7092 File Offset: 0x001C5292
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicEnterLayerCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004500 RID: 17664
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Sb2d1ZU1hZ2ljRW50ZXJMYXllckNzUmVxLnByb3RvIkwKGVJvZ3VlTWFn" + "aWNFbnRlckxheWVyQ3NSZXESFgoObmV4dF9yb29tX3R5cGUYASABKA0SFwoP" + "Y3VyX2xldmVsX2luZGV4GAsgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicEnterLayerCsReq), RogueMagicEnterLayerCsReq.Parser, new string[]
			{
				"NextRoomType",
				"CurLevelIndex"
			}, null, null, null, null)
		}));
	}
}
