using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200009C RID: 156
	public static class ALLFKPIPPDHReflection
	{
		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00012DE8 File Offset: 0x00010FE8
		public static FileDescriptor Descriptor
		{
			get
			{
				return ALLFKPIPPDHReflection.descriptor;
			}
		}

		// Token: 0x04000276 RID: 630
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTExGS1BJUFBESC5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtBTExG" + "S1BJUFBESBIgCgthdmF0YXJfdHlwZRgMIAEoDjILLkF2YXRhclR5cGUSEQoJ" + "YXZhdGFyX2lkGAUgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ALLFKPIPPDH), ALLFKPIPPDH.Parser, new string[]
			{
				"AvatarType",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
