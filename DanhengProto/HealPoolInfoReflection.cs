using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000898 RID: 2200
	public static class HealPoolInfoReflection
	{
		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x0600623B RID: 25147 RVA: 0x00106F62 File Offset: 0x00105162
		public static FileDescriptor Descriptor
		{
			get
			{
				return HealPoolInfoReflection.descriptor;
			}
		}

		// Token: 0x040025C4 RID: 9668
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJIZWFsUG9vbEluZm8ucHJvdG8iNwoMSGVhbFBvb2xJbmZvEhQKDHJlZnJl" + "c2hfdGltZRgCIAEoAxIRCgloZWFsX3Bvb2wYCiABKA1CHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HealPoolInfo), HealPoolInfo.Parser, new string[]
			{
				"RefreshTime",
				"HealPool"
			}, null, null, null, null)
		}));
	}
}
