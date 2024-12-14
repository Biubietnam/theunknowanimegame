using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200022E RID: 558
	public static class ChessRogueHistoryCellInfoReflection
	{
		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x000493D5 File Offset: 0x000475D5
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueHistoryCellInfoReflection.descriptor;
			}
		}

		// Token: 0x04000AB8 RID: 2744
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DaGVzc1JvZ3VlSGlzdG9yeUNlbGxJbmZvLnByb3RvIj0KGUNoZXNzUm9n" + "dWVIaXN0b3J5Q2VsbEluZm8SDwoHY2VsbF9pZBgEIAEoDRIPCgdyb29tX2lk" + "GAcgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueHistoryCellInfo), ChessRogueHistoryCellInfo.Parser, new string[]
			{
				"CellId",
				"RoomId"
			}, null, null, null, null)
		}));
	}
}
