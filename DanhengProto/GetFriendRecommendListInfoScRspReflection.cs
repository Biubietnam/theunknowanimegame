using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006D2 RID: 1746
	public static class GetFriendRecommendListInfoScRspReflection
	{
		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06004E29 RID: 20009 RVA: 0x000D3906 File Offset: 0x000D1B06
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFriendRecommendListInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001EE0 RID: 7904
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiVHZXRGcmllbmRSZWNvbW1lbmRMaXN0SW5mb1NjUnNwLnByb3RvGhlGcmll",
			"bmRSZWNvbW1lbmRJbmZvLnByb3RvImIKH0dldEZyaWVuZFJlY29tbWVuZExp",
			"c3RJbmZvU2NSc3ASDwoHcmV0Y29kZRgKIAEoDRIuChBwbGF5ZXJfaW5mb19s",
			"aXN0GA8gAygLMhQuRnJpZW5kUmVjb21tZW5kSW5mb0IeqgIbRWdnTGluay5E",
			"YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			FriendRecommendInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendRecommendListInfoScRsp), GetFriendRecommendListInfoScRsp.Parser, new string[]
			{
				"Retcode",
				"PlayerInfoList"
			}, null, null, null, null)
		}));
	}
}
