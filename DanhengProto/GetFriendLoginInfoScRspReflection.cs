using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006CE RID: 1742
	public static class GetFriendLoginInfoScRspReflection
	{
		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06004DF9 RID: 19961 RVA: 0x000D313A File Offset: 0x000D133A
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFriendLoginInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001ECC RID: 7884
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1HZXRGcmllbmRMb2dpbkluZm9TY1JzcC5wcm90byKCAQoXR2V0RnJpZW5k",
			"TG9naW5JbmZvU2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIXCg9mcmllbmRfdWlk",
			"X2xpc3QYCyADKA0SEwoLQUlIUE1KTENCQ0gYDCABKAgSEwoLRUFQRFBPQUNQ",
			"TU8YCSABKAgSEwoLSk5PSEZLTEtOSE8YCCADKA1CHqoCG0VnZ0xpbmsuRGFu",
			"aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendLoginInfoScRsp), GetFriendLoginInfoScRsp.Parser, new string[]
			{
				"Retcode",
				"FriendUidList",
				"AIHPMJLCBCH",
				"EAPDPOACPMO",
				"JNOHFKLKNHO"
			}, null, null, null, null)
		}));
	}
}
