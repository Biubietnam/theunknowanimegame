using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200097C RID: 2428
	public static class JoinLineupCsReqReflection
	{
		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x06006C9B RID: 27803 RVA: 0x00121FDD File Offset: 0x001201DD
		public static FileDescriptor Descriptor
		{
			get
			{
				return JoinLineupCsReqReflection.descriptor;
			}
		}

		// Token: 0x040029A0 RID: 10656
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVKb2luTGluZXVwQ3NSZXEucHJvdG8aFUV4dHJhTGluZXVwVHlwZS5wcm90",
			"bxoQQXZhdGFyVHlwZS5wcm90byK7AQoPSm9pbkxpbmV1cENzUmVxEisKEWV4",
			"dHJhX2xpbmV1cF90eXBlGA8gASgOMhAuRXh0cmFMaW5ldXBUeXBlEhIKCmlz",
			"X3ZpcnR1YWwYDSABKAgSFgoOYmFzZV9hdmF0YXJfaWQYDCABKA0SDQoFaW5k",
			"ZXgYByABKA0SIAoLYXZhdGFyX3R5cGUYCCABKA4yCy5BdmF0YXJUeXBlEgwK",
			"BHNsb3QYBCABKA0SEAoIcGxhbmVfaWQYBSABKA1CHqoCG0VnZ0xpbmsuRGFu",
			"aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ExtraLineupTypeReflection.Descriptor,
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(JoinLineupCsReq), JoinLineupCsReq.Parser, new string[]
			{
				"ExtraLineupType",
				"IsVirtual",
				"BaseAvatarId",
				"Index",
				"AvatarType",
				"Slot",
				"PlaneId"
			}, null, null, null, null)
		}));
	}
}
