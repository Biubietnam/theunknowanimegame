using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003D0 RID: 976
	public static class DressAvatarCsReqReflection
	{
		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06002B7D RID: 11133 RVA: 0x00079225 File Offset: 0x00077425
		public static FileDescriptor Descriptor
		{
			get
			{
				return DressAvatarCsReqReflection.descriptor;
			}
		}

		// Token: 0x040011A4 RID: 4516
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZEcmVzc0F2YXRhckNzUmVxLnByb3RvIkIKEERyZXNzQXZhdGFyQ3NSZXES" + "GwoTZXF1aXBtZW50X3VuaXF1ZV9pZBgOIAEoDRIRCglhdmF0YXJfaWQYDCAB" + "KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DressAvatarCsReq), DressAvatarCsReq.Parser, new string[]
			{
				"EquipmentUniqueId",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
