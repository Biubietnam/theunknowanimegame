using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000234 RID: 564
	public static class ChessRogueLayerInitialEventInfoReflection
	{
		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x0004A0FF File Offset: 0x000482FF
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueLayerInitialEventInfoReflection.descriptor;
			}
		}

		// Token: 0x04000AD4 RID: 2772
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiVDaGVzc1JvZ3VlTGF5ZXJJbml0aWFsRXZlbnRJbmZvLnByb3RvGhRDaGVz",
			"c1JvZ3VlQ2VsbC5wcm90byJaCh9DaGVzc1JvZ3VlTGF5ZXJJbml0aWFsRXZl",
			"bnRJbmZvEhMKC0xPT0JGREROT0tLGAggASgNEiIKCWNlbGxfbGlzdBgNIAMo",
			"CzIPLkNoZXNzUm9ndWVDZWxsQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
			"UHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChessRogueCellReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueLayerInitialEventInfo), ChessRogueLayerInitialEventInfo.Parser, new string[]
			{
				"LOOBFDDNOKK",
				"CellList"
			}, null, null, null, null)
		}));
	}
}
