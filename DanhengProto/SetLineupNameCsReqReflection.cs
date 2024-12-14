using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001110 RID: 4368
	public static class SetLineupNameCsReqReflection
	{
		// Token: 0x170036EF RID: 14063
		// (get) Token: 0x0600C2CB RID: 49867 RVA: 0x0020B085 File Offset: 0x00209285
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetLineupNameCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004EC1 RID: 20161
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTZXRMaW5ldXBOYW1lQ3NSZXEucHJvdG8iMQoSU2V0TGluZXVwTmFtZUNz" + "UmVxEgwKBG5hbWUYAiABKAkSDQoFaW5kZXgYCSABKA1CHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetLineupNameCsReq), SetLineupNameCsReq.Parser, new string[]
			{
				"Name",
				"Index"
			}, null, null, null, null)
		}));
	}
}
