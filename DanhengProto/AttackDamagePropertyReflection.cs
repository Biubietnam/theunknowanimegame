using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000B8 RID: 184
	public static class AttackDamagePropertyReflection
	{
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x0001657E File Offset: 0x0001477E
		public static FileDescriptor Descriptor
		{
			get
			{
				return AttackDamagePropertyReflection.descriptor;
			}
		}

		// Token: 0x040002FA RID: 762
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpBdHRhY2tEYW1hZ2VQcm9wZXJ0eS5wcm90byI7ChRBdHRhY2tEYW1hZ2VQ" + "cm9wZXJ0eRITCgthdHRhY2tfdHlwZRgBIAEoCRIOCgZkYW1hZ2UYAiABKAFC" + "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AttackDamageProperty), AttackDamageProperty.Parser, new string[]
			{
				"AttackType",
				"Damage"
			}, null, null, null, null)
		}));
	}
}
