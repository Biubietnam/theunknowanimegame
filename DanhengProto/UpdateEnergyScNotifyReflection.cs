using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013D4 RID: 5076
	public static class UpdateEnergyScNotifyReflection
	{
		// Token: 0x17003F8C RID: 16268
		// (get) Token: 0x0600E24D RID: 57933 RVA: 0x00259E1F File Offset: 0x0025801F
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpdateEnergyScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005A00 RID: 23040
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpVcGRhdGVFbmVyZ3lTY05vdGlmeS5wcm90bxoXUm90YXRlckVuZXJneUlu" + "Zm8ucHJvdG8iPwoUVXBkYXRlRW5lcmd5U2NOb3RpZnkSJwoLZW5lcmd5X2lu" + "Zm8YCiABKAsyEi5Sb3RhdGVyRW5lcmd5SW5mb0IeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpdateEnergyScNotify), UpdateEnergyScNotify.Parser, new string[]
			{
				"EnergyInfo"
			}, null, null, null, null)
		}));
	}
}
