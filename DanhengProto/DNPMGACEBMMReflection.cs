using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003BE RID: 958
	public static class DNPMGACEBMMReflection
	{
		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06002A8D RID: 10893 RVA: 0x00076615 File Offset: 0x00074815
		public static FileDescriptor Descriptor
		{
			get
			{
				return DNPMGACEBMMReflection.descriptor;
			}
		}

		// Token: 0x0400113A RID: 4410
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFETlBNR0FDRUJNTS5wcm90bxoRUm9ndWVTdGF0dXMucHJvdG8aFENoZXNz",
			"Um9ndWVCdWZmLnByb3RvGhdDaGVzc1JvZ3VlTWlyYWNsZS5wcm90byKbAgoL",
			"RE5QTUdBQ0VCTU0SLgoVY2hlc3Nfcm9ndWVfYnVmZl9pbmZvGAUgASgLMg8u",
			"Q2hlc3NSb2d1ZUJ1ZmYSEwoLRUlGSE9DTkFMQkEYCiABKA0SEwoLQkdKS09M",
			"TkNPUE4YAyABKA0SGwoTYmFzZV9hdmF0YXJfaWRfbGlzdBgEIAMoDRIcCgZz",
			"dGF0dXMYByABKA4yDC5Sb2d1ZVN0YXR1cxIOCgZtYXBfaWQYASABKA0SHAoU",
			"dHJpYWxfYXZhdGFyX2lkX2xpc3QYCSADKA0SNAoYY2hlc3Nfcm9ndWVfbWly",
			"YWNsZV9pbmZvGA0gASgLMhIuQ2hlc3NSb2d1ZU1pcmFjbGUSEwoLQ0dIS01K",
			"R0tLSUoYDCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueStatusReflection.Descriptor,
			ChessRogueBuffReflection.Descriptor,
			ChessRogueMiracleReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DNPMGACEBMM), DNPMGACEBMM.Parser, new string[]
			{
				"ChessRogueBuffInfo",
				"EIFHOCNALBA",
				"BGJKOLNCOPN",
				"BaseAvatarIdList",
				"Status",
				"MapId",
				"TrialAvatarIdList",
				"ChessRogueMiracleInfo",
				"CGHKMJGKKIJ"
			}, null, null, null, null)
		}));
	}
}
