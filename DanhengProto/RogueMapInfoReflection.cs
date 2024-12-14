using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F38 RID: 3896
	public static class RogueMapInfoReflection
	{
		// Token: 0x17003109 RID: 12553
		// (get) Token: 0x0600ADD4 RID: 44500 RVA: 0x001D34A9 File Offset: 0x001D16A9
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMapInfoReflection.descriptor;
			}
		}

		// Token: 0x040046BB RID: 18107
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJSb2d1ZU1hcEluZm8ucHJvdG8aD1JvZ3VlUm9vbS5wcm90byJ4CgxSb2d1",
			"ZU1hcEluZm8SEwoLY3VyX3Jvb21faWQYCSABKA0SEwoLY3VyX3NpdGVfaWQY",
			"ASABKA0SDgoGbWFwX2lkGAogASgNEg8KB2FyZWFfaWQYBCABKA0SHQoJcm9v",
			"bV9saXN0GA4gAygLMgouUm9ndWVSb29tQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
			"ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueRoomReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMapInfo), RogueMapInfo.Parser, new string[]
			{
				"CurRoomId",
				"CurSiteId",
				"MapId",
				"AreaId",
				"RoomList"
			}, null, null, null, null)
		}));
	}
}
