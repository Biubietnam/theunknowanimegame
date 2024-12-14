using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000654 RID: 1620
	public static class GetChatFriendHistoryScRspReflection
	{
		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x060048B2 RID: 18610 RVA: 0x000C6A62 File Offset: 0x000C4C62
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetChatFriendHistoryScRspReflection.descriptor;
			}
		}

		// Token: 0x04001D05 RID: 7429
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9HZXRDaGF0RnJpZW5kSGlzdG9yeVNjUnNwLnByb3RvGhdGcmllbmRIaXN0",
			"b3J5SW5mby5wcm90byJdChlHZXRDaGF0RnJpZW5kSGlzdG9yeVNjUnNwEi8K",
			"E2ZyaWVuZF9oaXN0b3J5X2luZm8YCiADKAsyEi5GcmllbmRIaXN0b3J5SW5m",
			"bxIPCgdyZXRjb2RlGAMgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
			"UHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			FriendHistoryInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetChatFriendHistoryScRsp), GetChatFriendHistoryScRsp.Parser, new string[]
			{
				"FriendHistoryInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
