using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E7A RID: 3706
	public static class RogueEndlessAvatarReflection
	{
		// Token: 0x17002EAB RID: 11947
		// (get) Token: 0x0600A561 RID: 42337 RVA: 0x001BC7DA File Offset: 0x001BA9DA
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueEndlessAvatarReflection.descriptor;
			}
		}

		// Token: 0x04004388 RID: 17288
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhSb2d1ZUVuZGxlc3NBdmF0YXIucHJvdG8aEEF2YXRhclR5cGUucHJvdG8i" + "SQoSUm9ndWVFbmRsZXNzQXZhdGFyEiAKC2F2YXRhcl90eXBlGAwgASgOMgsu" + "QXZhdGFyVHlwZRIRCglhdmF0YXJfaWQYASABKA1CHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueEndlessAvatar), RogueEndlessAvatar.Parser, new string[]
			{
				"AvatarType",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
