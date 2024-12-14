using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011F0 RID: 4592
	public static class StrongChallengeAvatarReflection
	{
		// Token: 0x170039EA RID: 14826
		// (get) Token: 0x0600CD48 RID: 52552 RVA: 0x00227072 File Offset: 0x00225272
		public static FileDescriptor Descriptor
		{
			get
			{
				return StrongChallengeAvatarReflection.descriptor;
			}
		}

		// Token: 0x040052CB RID: 21195
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTdHJvbmdDaGFsbGVuZ2VBdmF0YXIucHJvdG8aEEF2YXRhclR5cGUucHJv" + "dG8iSwoVU3Ryb25nQ2hhbGxlbmdlQXZhdGFyEhEKCWF2YXRhcl9pZBgLIAEo" + "DRIfCgpBdmF0YXJUeXBlGAwgASgOMgsuQXZhdGFyVHlwZUIeqgIbRWdnTGlu" + "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StrongChallengeAvatar), StrongChallengeAvatar.Parser, new string[]
			{
				"AvatarId",
				"AvatarType"
			}, null, null, null, null)
		}));
	}
}
