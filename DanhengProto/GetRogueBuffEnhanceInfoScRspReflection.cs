using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007AA RID: 1962
	public static class GetRogueBuffEnhanceInfoScRspReflection
	{
		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x0600579F RID: 22431 RVA: 0x000EA8E2 File Offset: 0x000E8AE2
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetRogueBuffEnhanceInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04002236 RID: 8758
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJHZXRSb2d1ZUJ1ZmZFbmhhbmNlSW5mb1NjUnNwLnByb3RvGh5Sb2d1ZUJ1",
			"ZmZFbmhhbmNlSW5mb0xpc3QucHJvdG8iZQocR2V0Um9ndWVCdWZmRW5oYW5j",
			"ZUluZm9TY1JzcBI0ChFidWZmX2VuaGFuY2VfaW5mbxgOIAEoCzIZLlJvZ3Vl",
			"QnVmZkVuaGFuY2VJbmZvTGlzdBIPCgdyZXRjb2RlGAsgASgNQh6qAhtFZ2dM",
			"aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueBuffEnhanceInfoListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueBuffEnhanceInfoScRsp), GetRogueBuffEnhanceInfoScRsp.Parser, new string[]
			{
				"BuffEnhanceInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
