using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006CA RID: 1738
	public static class GetFriendListInfoScRspReflection
	{
		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x06004DCF RID: 19919 RVA: 0x000D2B56 File Offset: 0x000D0D56
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFriendListInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001EBE RID: 7870
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxHZXRGcmllbmRMaXN0SW5mb1NjUnNwLnByb3RvGhZQbGF5ZXJTaW1wbGVJ",
			"bmZvLnByb3RvGhZGcmllbmRTaW1wbGVJbmZvLnByb3RvIngKFkdldEZyaWVu",
			"ZExpc3RJbmZvU2NSc3ASJQoKYmxhY2tfbGlzdBgLIAMoCzIRLlBsYXllclNp",
			"bXBsZUluZm8SJgoLZnJpZW5kX2xpc3QYAiADKAsyES5GcmllbmRTaW1wbGVJ",
			"bmZvEg8KB3JldGNvZGUYAyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			PlayerSimpleInfoReflection.Descriptor,
			FriendSimpleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendListInfoScRsp), GetFriendListInfoScRsp.Parser, new string[]
			{
				"BlackList",
				"FriendList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
