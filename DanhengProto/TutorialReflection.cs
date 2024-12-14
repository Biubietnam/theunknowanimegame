using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013B0 RID: 5040
	public static class TutorialReflection
	{
		// Token: 0x17003F28 RID: 16168
		// (get) Token: 0x0600E0D0 RID: 57552 RVA: 0x00256809 File Offset: 0x00254A09
		public static FileDescriptor Descriptor
		{
			get
			{
				return TutorialReflection.descriptor;
			}
		}

		// Token: 0x04005984 RID: 22916
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5UdXRvcmlhbC5wcm90bxoUVHV0b3JpYWxTdGF0dXMucHJvdG8iNwoIVHV0" + "b3JpYWwSHwoGU3RhdHVzGAcgASgOMg8uVHV0b3JpYWxTdGF0dXMSCgoCaWQY" + "CyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			TutorialStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Tutorial), Tutorial.Parser, new string[]
			{
				"Status",
				"Id"
			}, null, null, null, null)
		}));
	}
}
