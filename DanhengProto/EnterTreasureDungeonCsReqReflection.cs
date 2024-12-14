using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200047A RID: 1146
	public static class EnterTreasureDungeonCsReqReflection
	{
		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06003316 RID: 13078 RVA: 0x0008C83E File Offset: 0x0008AA3E
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterTreasureDungeonCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001455 RID: 5205
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9FbnRlclRyZWFzdXJlRHVuZ2VvbkNzUmVxLnByb3RvGhtUcmVhc3VyZUR1",
			"bmdlb25BdmF0YXIucHJvdG8iXQoZRW50ZXJUcmVhc3VyZUR1bmdlb25Dc1Jl",
			"cRIrCgthdmF0YXJfbGlzdBgLIAMoCzIWLlRyZWFzdXJlRHVuZ2VvbkF2YXRh",
			"chITCgtOQ0ZBSlBBTUJHRBgBIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			TreasureDungeonAvatarReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterTreasureDungeonCsReq), EnterTreasureDungeonCsReq.Parser, new string[]
			{
				"AvatarList",
				"NCFAJPAMBGD"
			}, null, null, null, null)
		}));
	}
}
