using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000D4 RID: 212
	public static class BatchMarkChatEmojiCsReqReflection
	{
		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x0001BDF7 File Offset: 0x00019FF7
		public static FileDescriptor Descriptor
		{
			get
			{
				return BatchMarkChatEmojiCsReqReflection.descriptor;
			}
		}

		// Token: 0x040003DD RID: 989
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1CYXRjaE1hcmtDaGF0RW1vamlDc1JlcS5wcm90byI3ChdCYXRjaE1hcmtD" + "aGF0RW1vamlDc1JlcRIcChRtYXJrZWRfZW1vamlfaWRfbGlzdBgBIAMoDUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BatchMarkChatEmojiCsReq), BatchMarkChatEmojiCsReq.Parser, new string[]
			{
				"MarkedEmojiIdList"
			}, null, null, null, null)
		}));
	}
}
