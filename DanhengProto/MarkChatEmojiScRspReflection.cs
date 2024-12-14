using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A86 RID: 2694
	public static class MarkChatEmojiScRspReflection
	{
		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x06007775 RID: 30581 RVA: 0x0013CD41 File Offset: 0x0013AF41
		public static FileDescriptor Descriptor
		{
			get
			{
				return MarkChatEmojiScRspReflection.descriptor;
			}
		}

		// Token: 0x04002DDE RID: 11742
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhNYXJrQ2hhdEVtb2ppU2NSc3AucHJvdG8iTQoSTWFya0NoYXRFbW9qaVNj" + "UnNwEhAKCGV4dHJhX2lkGAYgASgNEg8KB3JldGNvZGUYCiABKA0SFAoMaXNf" + "cmVtb3ZlX2lkGA8gASgIQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MarkChatEmojiScRsp), MarkChatEmojiScRsp.Parser, new string[]
			{
				"ExtraId",
				"Retcode",
				"IsRemoveId"
			}, null, null, null, null)
		}));
	}
}
