using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000882 RID: 2178
	public static class GroupStatusReflection
	{
		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x060060E4 RID: 24804 RVA: 0x001001D9 File Offset: 0x000FE3D9
		public static FileDescriptor Descriptor
		{
			get
			{
				return GroupStatusReflection.descriptor;
			}
		}

		// Token: 0x0400253B RID: 9531
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFHcm91cFN0YXR1cy5wcm90bxoYTWVzc2FnZUdyb3VwU3RhdHVzLnByb3Rv",
			"ImAKC0dyb3VwU3RhdHVzEhQKDHJlZnJlc2hfdGltZRgLIAEoAxIQCghncm91",
			"cF9pZBgNIAEoDRIpCgxncm91cF9zdGF0dXMYCSABKA4yEy5NZXNzYWdlR3Jv",
			"dXBTdGF0dXNCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			MessageGroupStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GroupStatus), GroupStatus.Parser, new string[]
			{
				"RefreshTime",
				"GroupId",
				"GroupStatus_"
			}, null, null, null, null)
		}));
	}
}
