using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000D6 RID: 214
	public static class BatchMarkChatEmojiScRspReflection
	{
		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0001C067 File Offset: 0x0001A267
		public static FileDescriptor Descriptor
		{
			get
			{
				return BatchMarkChatEmojiScRspReflection.descriptor;
			}
		}

		// Token: 0x040003E3 RID: 995
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1CYXRjaE1hcmtDaGF0RW1vamlTY1JzcC5wcm90byJIChdCYXRjaE1hcmtD" + "aGF0RW1vamlTY1JzcBIPCgdyZXRjb2RlGAEgASgNEhwKFG1hcmtlZF9lbW9q" + "aV9pZF9saXN0GAogAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BatchMarkChatEmojiScRsp), BatchMarkChatEmojiScRsp.Parser, new string[]
			{
				"Retcode",
				"MarkedEmojiIdList"
			}, null, null, null, null)
		}));
	}
}
