using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200087C RID: 2172
	public static class GroupStateChangeScNotifyReflection
	{
		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x0600609D RID: 24733 RVA: 0x000FF6D5 File Offset: 0x000FD8D5
		public static FileDescriptor Descriptor
		{
			get
			{
				return GroupStateChangeScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04002524 RID: 9508
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Hcm91cFN0YXRlQ2hhbmdlU2NOb3RpZnkucHJvdG8aFEdyb3VwU3RhdGVJ" + "bmZvLnByb3RvIkUKGEdyb3VwU3RhdGVDaGFuZ2VTY05vdGlmeRIpChBncm91" + "cF9zdGF0ZV9pbmZvGAcgASgLMg8uR3JvdXBTdGF0ZUluZm9CHqoCG0VnZ0xp" + "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			GroupStateInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GroupStateChangeScNotify), GroupStateChangeScNotify.Parser, new string[]
			{
				"GroupStateInfo"
			}, null, null, null, null)
		}));
	}
}
