using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200068C RID: 1676
	public static class GetEnteredSceneScRspReflection
	{
		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06004B1C RID: 19228 RVA: 0x000CC32E File Offset: 0x000CA52E
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetEnteredSceneScRspReflection.descriptor;
			}
		}

		// Token: 0x04001DC7 RID: 7623
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpHZXRFbnRlcmVkU2NlbmVTY1JzcC5wcm90bxoWRW50ZXJlZFNjZW5lSW5m",
			"by5wcm90byJbChRHZXRFbnRlcmVkU2NlbmVTY1JzcBIPCgdyZXRjb2RlGAQg",
			"ASgNEjIKF2VudGVyZWRfc2NlbmVfaW5mb19saXN0GA4gAygLMhEuRW50ZXJl",
			"ZFNjZW5lSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			EnteredSceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetEnteredSceneScRsp), GetEnteredSceneScRsp.Parser, new string[]
			{
				"Retcode",
				"EnteredSceneInfoList"
			}, null, null, null, null)
		}));
	}
}
