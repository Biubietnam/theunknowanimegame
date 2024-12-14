using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007FE RID: 2046
	public static class GetSocialEventServerCacheScRspReflection
	{
		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x06005B4C RID: 23372 RVA: 0x000F31FA File Offset: 0x000F13FA
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetSocialEventServerCacheScRspReflection.descriptor;
			}
		}

		// Token: 0x04002361 RID: 9057
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiRHZXRTb2NpYWxFdmVudFNlcnZlckNhY2hlU2NSc3AucHJvdG8aHFNvY2lh",
			"bEV2ZW50U2VydmVyQ2FjaGUucHJvdG8iXwoeR2V0U29jaWFsRXZlbnRTZXJ2",
			"ZXJDYWNoZVNjUnNwEiwKC1BQRkxERU9LSUZJGA0gAygLMhcuU29jaWFsRXZl",
			"bnRTZXJ2ZXJDYWNoZRIPCgdyZXRjb2RlGAUgASgNQh6qAhtFZ2dMaW5rLkRh",
			"bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			SocialEventServerCacheReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetSocialEventServerCacheScRsp), GetSocialEventServerCacheScRsp.Parser, new string[]
			{
				"PPFLDEOKIFI",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
