using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F60 RID: 3936
	public static class RogueRecordAvatarReflection
	{
		// Token: 0x1700317D RID: 12669
		// (get) Token: 0x0600AF7A RID: 44922 RVA: 0x001D76DA File Offset: 0x001D58DA
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueRecordAvatarReflection.descriptor;
			}
		}

		// Token: 0x0400475D RID: 18269
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdSb2d1ZVJlY29yZEF2YXRhci5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJe" + "ChFSb2d1ZVJlY29yZEF2YXRhchIMCgRzbG90GAUgASgNEiAKC2F2YXRhcl90" + "eXBlGA4gASgOMgsuQXZhdGFyVHlwZRIKCgJpZBgGIAEoDRINCgVsZXZlbBgL" + "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueRecordAvatar), RogueRecordAvatar.Parser, new string[]
			{
				"Slot",
				"AvatarType",
				"Id",
				"Level"
			}, null, null, null, null)
		}));
	}
}
