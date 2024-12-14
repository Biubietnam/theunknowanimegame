using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000638 RID: 1592
	public static class GetBoxingClubInfoScRspReflection
	{
		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x0600477D RID: 18301 RVA: 0x000C3D2E File Offset: 0x000C1F2E
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetBoxingClubInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001CA1 RID: 7329
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXRCb3hpbmdDbHViSW5mb1NjUnNwLnByb3RvGhFMSkxMSElKS0tPSC5w" + "cm90byJPChZHZXRCb3hpbmdDbHViSW5mb1NjUnNwEiQKDmNoYWxsZW5nZV9s" + "aXN0GA4gAygLMgwuTEpMTEhJSktLT0gSDwoHcmV0Y29kZRgJIAEoDUIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			LJLLHIJKKOHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetBoxingClubInfoScRsp), GetBoxingClubInfoScRsp.Parser, new string[]
			{
				"ChallengeList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
