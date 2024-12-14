using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001394 RID: 5012
	public static class TreasureDungeonAvatarReflection
	{
		// Token: 0x17003ED0 RID: 16080
		// (get) Token: 0x0600DFB1 RID: 57265 RVA: 0x0025333C File Offset: 0x0025153C
		public static FileDescriptor Descriptor
		{
			get
			{
				return TreasureDungeonAvatarReflection.descriptor;
			}
		}

		// Token: 0x040058E0 RID: 22752
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtUcmVhc3VyZUR1bmdlb25BdmF0YXIucHJvdG8aEEF2YXRhclR5cGUucHJv" + "dG8iTAoVVHJlYXN1cmVEdW5nZW9uQXZhdGFyEhEKCWF2YXRhcl9pZBgIIAEo" + "DRIgCgthdmF0YXJfdHlwZRgBIAEoDjILLkF2YXRhclR5cGVCHqoCG0VnZ0xp" + "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TreasureDungeonAvatar), TreasureDungeonAvatar.Parser, new string[]
			{
				"AvatarId",
				"AvatarType"
			}, null, null, null, null)
		}));
	}
}
