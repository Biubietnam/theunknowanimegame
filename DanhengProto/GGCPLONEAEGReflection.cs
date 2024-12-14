using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000856 RID: 2134
	public static class GGCPLONEAEGReflection
	{
		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x06005EEF RID: 24303 RVA: 0x000FB400 File Offset: 0x000F9600
		public static FileDescriptor Descriptor
		{
			get
			{
				return GGCPLONEAEGReflection.descriptor;
			}
		}

		// Token: 0x0400248B RID: 9355
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHR0NQTE9ORUFFRy5wcm90byI1CgtHR0NQTE9ORUFFRxITCgthdmF0YXJf" + "dHlwZRgFIAEoDRIRCglhdmF0YXJfaWQYDiABKA1CHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GGCPLONEAEG), GGCPLONEAEG.Parser, new string[]
			{
				"AvatarType",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
