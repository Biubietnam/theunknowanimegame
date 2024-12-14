using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000650 RID: 1616
	public static class GetChatEmojiListScRspReflection
	{
		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06004889 RID: 18569 RVA: 0x000C6562 File Offset: 0x000C4762
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetChatEmojiListScRspReflection.descriptor;
			}
		}

		// Token: 0x04001CFA RID: 7418
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRDaGF0RW1vamlMaXN0U2NSc3AucHJvdG8iQQoVR2V0Q2hhdEVtb2pp" + "TGlzdFNjUnNwEg8KB3JldGNvZGUYCCABKA0SFwoPY2hhdF9lbW9qaV9saXN0" + "GAMgAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetChatEmojiListScRsp), GetChatEmojiListScRsp.Parser, new string[]
			{
				"Retcode",
				"ChatEmojiList"
			}, null, null, null, null)
		}));
	}
}
