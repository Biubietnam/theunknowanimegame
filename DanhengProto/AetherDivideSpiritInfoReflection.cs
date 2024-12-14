using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000064 RID: 100
	public static class AetherDivideSpiritInfoReflection
	{
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0000C8F7 File Offset: 0x0000AAF7
		public static FileDescriptor Descriptor
		{
			get
			{
				return AetherDivideSpiritInfoReflection.descriptor;
			}
		}

		// Token: 0x0400018B RID: 395
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxBZXRoZXJEaXZpZGVTcGlyaXRJbmZvLnByb3RvGhZQYXNzaXZlU2tpbGxJ",
			"dGVtLnByb3RvGg9TcEJhckluZm8ucHJvdG8irQEKFkFldGhlckRpdmlkZVNw",
			"aXJpdEluZm8SKAoNcGFzc2l2ZV9za2lsbBgBIAMoCzIRLlBhc3NpdmVTa2ls",
			"bEl0ZW0SCwoDZXhwGAsgASgNEhgKEGFldGhlcl9hdmF0YXJfaWQYAiABKA0S",
			"EQoJcHJvbW90aW9uGAYgASgNEhMKC0JCRUpCT0pGTExQGAQgASgNEhoKBnNw",
			"X2JhchgNIAEoCzIKLlNwQmFySW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			PassiveSkillItemReflection.Descriptor,
			SpBarInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AetherDivideSpiritInfo), AetherDivideSpiritInfo.Parser, new string[]
			{
				"PassiveSkill",
				"Exp",
				"AetherAvatarId",
				"Promotion",
				"BBEJBOJFLLP",
				"SpBar"
			}, null, null, null, null)
		}));
	}
}
