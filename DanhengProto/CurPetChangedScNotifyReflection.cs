using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200033E RID: 830
	public static class CurPetChangedScNotifyReflection
	{
		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x00068F8C File Offset: 0x0006718C
		public static FileDescriptor Descriptor
		{
			get
			{
				return CurPetChangedScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000F27 RID: 3879
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDdXJQZXRDaGFuZ2VkU2NOb3RpZnkucHJvdG8iKwoVQ3VyUGV0Q2hhbmdl" + "ZFNjTm90aWZ5EhIKCmN1cl9wZXRfaWQYCSABKA1CHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CurPetChangedScNotify), CurPetChangedScNotify.Parser, new string[]
			{
				"CurPetId"
			}, null, null, null, null)
		}));
	}
}
