using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006BE RID: 1726
	public static class GetFriendChallengeDetailScRspReflection
	{
		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x06004D48 RID: 19784 RVA: 0x000D17B0 File Offset: 0x000CF9B0
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFriendChallengeDetailScRspReflection.descriptor;
			}
		}

		// Token: 0x04001E91 RID: 7825
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNHZXRGcmllbmRDaGFsbGVuZ2VEZXRhaWxTY1JzcC5wcm90bxodRGlzcGxh",
			"eUF2YXRhckRldGFpbEluZm8ucHJvdG8iggEKHUdldEZyaWVuZENoYWxsZW5n",
			"ZURldGFpbFNjUnNwEgsKA3VpZBgHIAEoDRIPCgdyZXRjb2RlGA8gASgNEi0K",
			"C0RNREFGSUJGSkhQGAUgAygLMhguRGlzcGxheUF2YXRhckRldGFpbEluZm8S",
			"FAoMY2hhbGxlbmdlX2lkGAQgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
			"ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			DisplayAvatarDetailInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendChallengeDetailScRsp), GetFriendChallengeDetailScRsp.Parser, new string[]
			{
				"Uid",
				"Retcode",
				"DMDAFIBFJHP",
				"ChallengeId"
			}, null, null, null, null)
		}));
	}
}
