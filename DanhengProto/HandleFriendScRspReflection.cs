using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200088A RID: 2186
	public static class HandleFriendScRspReflection
	{
		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x06006141 RID: 24897 RVA: 0x00100F8D File Offset: 0x000FF18D
		public static FileDescriptor Descriptor
		{
			get
			{
				return HandleFriendScRspReflection.descriptor;
			}
		}

		// Token: 0x0400255A RID: 9562
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdIYW5kbGVGcmllbmRTY1JzcC5wcm90bxoWRnJpZW5kU2ltcGxlSW5mby5w",
			"cm90byJsChFIYW5kbGVGcmllbmRTY1JzcBIPCgdyZXRjb2RlGAEgASgNEiYK",
			"C2ZyaWVuZF9pbmZvGA4gASgLMhEuRnJpZW5kU2ltcGxlSW5mbxILCgN1aWQY",
			"AyABKA0SEQoJaXNfYWNjZXB0GAUgASgIQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
			"ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			FriendSimpleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HandleFriendScRsp), HandleFriendScRsp.Parser, new string[]
			{
				"Retcode",
				"FriendInfo",
				"Uid",
				"IsAccept"
			}, null, null, null, null)
		}));
	}
}
