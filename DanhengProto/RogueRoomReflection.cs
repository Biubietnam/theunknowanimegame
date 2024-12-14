using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F6C RID: 3948
	public static class RogueRoomReflection
	{
		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x0600B002 RID: 45058 RVA: 0x001D8BF5 File Offset: 0x001D6DF5
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueRoomReflection.descriptor;
			}
		}

		// Token: 0x0400478D RID: 18317
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Cg9Sb2d1ZVJvb20ucHJvdG8aFVJvZ3VlUm9vbVN0YXR1cy5wcm90byKPAQoJ",
			"Um9ndWVSb29tEhMKC0VIREZKR09EQkJEGA4gASgNEiUKC0ZISEhBREtISEVG",
			"GA8gASgOMhAuUm9ndWVSb29tU3RhdHVzEiQKCmN1cl9zdGF0dXMYDCABKA4y",
			"EC5Sb2d1ZVJvb21TdGF0dXMSDwoHc2l0ZV9pZBgIIAEoDRIPCgdyb29tX2lk",
			"GAMgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			RogueRoomStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueRoom), RogueRoom.Parser, new string[]
			{
				"EHDFJGODBBD",
				"FHHHADKHHEF",
				"CurStatus",
				"SiteId",
				"RoomId"
			}, null, null, null, null)
		}));
	}
}
