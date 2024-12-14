using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006B2 RID: 1714
	public static class GetFriendApplyListInfoScRspReflection
	{
		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x06004CB8 RID: 19640 RVA: 0x000CFF12 File Offset: 0x000CE112
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFriendApplyListInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001E55 RID: 7765
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFHZXRGcmllbmRBcHBseUxpc3RJbmZvU2NSc3AucHJvdG8aFUZyaWVuZEFw",
			"cGx5SW5mby5wcm90byJ1ChtHZXRGcmllbmRBcHBseUxpc3RJbmZvU2NSc3AS",
			"LAoScmVjZWl2ZV9hcHBseV9saXN0GA4gAygLMhAuRnJpZW5kQXBwbHlJbmZv",
			"EhcKD3NlbmRfYXBwbHlfbGlzdBgCIAMoDRIPCgdyZXRjb2RlGAwgASgNQh6q",
			"AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			FriendApplyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendApplyListInfoScRsp), GetFriendApplyListInfoScRsp.Parser, new string[]
			{
				"ReceiveApplyList",
				"SendApplyList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
