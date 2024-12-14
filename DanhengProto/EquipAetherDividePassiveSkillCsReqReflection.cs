using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000492 RID: 1170
	public static class EquipAetherDividePassiveSkillCsReqReflection
	{
		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06003413 RID: 13331 RVA: 0x0008EE22 File Offset: 0x0008D022
		public static FileDescriptor Descriptor
		{
			get
			{
				return EquipAetherDividePassiveSkillCsReqReflection.descriptor;
			}
		}

		// Token: 0x040014A9 RID: 5289
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihFcXVpcEFldGhlckRpdmlkZVBhc3NpdmVTa2lsbENzUmVxLnByb3RvIl0K" + "IkVxdWlwQWV0aGVyRGl2aWRlUGFzc2l2ZVNraWxsQ3NSZXESDAoEc2xvdBgG" + "IAEoDRIYChBhZXRoZXJfYXZhdGFyX2lkGA4gASgNEg8KB2l0ZW1faWQYCiAB" + "KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EquipAetherDividePassiveSkillCsReq), EquipAetherDividePassiveSkillCsReq.Parser, new string[]
			{
				"Slot",
				"AetherAvatarId",
				"ItemId"
			}, null, null, null, null)
		}));
	}
}
