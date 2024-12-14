using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001294 RID: 4756
	public static class SyncRogueMapRoomScNotifyReflection
	{
		// Token: 0x17003BB4 RID: 15284
		// (get) Token: 0x0600D436 RID: 54326 RVA: 0x00236B08 File Offset: 0x00234D08
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncRogueMapRoomScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040054EF RID: 21743
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TeW5jUm9ndWVNYXBSb29tU2NOb3RpZnkucHJvdG8aD1JvZ3VlUm9vbS5w" + "cm90byJIChhTeW5jUm9ndWVNYXBSb29tU2NOb3RpZnkSHAoIY3VyX3Jvb20Y" + "ByABKAsyCi5Sb2d1ZVJvb20SDgoGbWFwX2lkGAIgASgNQh6qAhtFZ2dMaW5r" + "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			RogueRoomReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueMapRoomScNotify), SyncRogueMapRoomScNotify.Parser, new string[]
			{
				"CurRoom",
				"MapId"
			}, null, null, null, null)
		}));
	}
}
