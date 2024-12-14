using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200087A RID: 2170
	public static class GroupStateChangeCsReqReflection
	{
		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x06006088 RID: 24712 RVA: 0x000FF410 File Offset: 0x000FD610
		public static FileDescriptor Descriptor
		{
			get
			{
				return GroupStateChangeCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400251F RID: 9503
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHcm91cFN0YXRlQ2hhbmdlQ3NSZXEucHJvdG8aFEdyb3VwU3RhdGVJbmZv" + "LnByb3RvIkIKFUdyb3VwU3RhdGVDaGFuZ2VDc1JlcRIpChBncm91cF9zdGF0" + "ZV9pbmZvGA8gASgLMg8uR3JvdXBTdGF0ZUluZm9CHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			GroupStateInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GroupStateChangeCsReq), GroupStateChangeCsReq.Parser, new string[]
			{
				"GroupStateInfo"
			}, null, null, null, null)
		}));
	}
}
