using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200083E RID: 2110
	public static class GetTutorialScRspReflection
	{
		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x06005DE3 RID: 24035 RVA: 0x000F8CC2 File Offset: 0x000F6EC2
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetTutorialScRspReflection.descriptor;
			}
		}

		// Token: 0x04002433 RID: 9267
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZHZXRUdXRvcmlhbFNjUnNwLnByb3RvGg5UdXRvcmlhbC5wcm90byJEChBH" + "ZXRUdXRvcmlhbFNjUnNwEg8KB3JldGNvZGUYAyABKA0SHwoMVHV0b3JpYWxM" + "aXN0GAkgAygLMgkuVHV0b3JpYWxCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl" + "ci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			TutorialReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetTutorialScRsp), GetTutorialScRsp.Parser, new string[]
			{
				"Retcode",
				"TutorialList"
			}, null, null, null, null)
		}));
	}
}
