using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200004E RID: 78
	public static class AetherAvatarInfoReflection
	{
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00009FFA File Offset: 0x000081FA
		public static FileDescriptor Descriptor
		{
			get
			{
				return AetherAvatarInfoReflection.descriptor;
			}
		}

		// Token: 0x0400012D RID: 301
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZBZXRoZXJBdmF0YXJJbmZvLnByb3RvGiJBZXRoZXJkaXZpZGVTcGlyaXRM",
			"aW5ldXBUeXBlLnByb3RvGg9TcEJhckluZm8ucHJvdG8irgEKEEFldGhlckF2",
			"YXRhckluZm8SCgoCaWQYASABKA0SDQoFaW5kZXgYAiABKA0SEQoJcHJvbW90",
			"aW9uGAMgASgNEhUKDXBhc3NpdmVfc2tpbGwYBCADKA0SOQoSc3Bpcml0X2xp",
			"bmV1cF90eXBlGAUgASgOMh0uQWV0aGVyZGl2aWRlU3Bpcml0TGluZXVwVHlw",
			"ZRIaCgZzcF9iYXIYBiABKAsyCi5TcEJhckluZm9CHqoCG0VnZ0xpbmsuRGFu",
			"aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			AetherdivideSpiritLineupTypeReflection.Descriptor,
			SpBarInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AetherAvatarInfo), AetherAvatarInfo.Parser, new string[]
			{
				"Id",
				"Index",
				"Promotion",
				"PassiveSkill",
				"SpiritLineupType",
				"SpBar"
			}, null, null, null, null)
		}));
	}
}
