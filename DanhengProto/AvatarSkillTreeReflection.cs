using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000C8 RID: 200
	public static class AvatarSkillTreeReflection
	{
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x0001AED8 File Offset: 0x000190D8
		public static FileDescriptor Descriptor
		{
			get
			{
				return AvatarSkillTreeReflection.descriptor;
			}
		}

		// Token: 0x040003B2 RID: 946
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVBdmF0YXJTa2lsbFRyZWUucHJvdG8iMgoPQXZhdGFyU2tpbGxUcmVlEhAK" + "CHBvaW50X2lkGAEgASgNEg0KBWxldmVsGAIgASgNQh6qAhtFZ2dMaW5rLkRh" + "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AvatarSkillTree), AvatarSkillTree.Parser, new string[]
			{
				"PointId",
				"Level"
			}, null, null, null, null)
		}));
	}
}
