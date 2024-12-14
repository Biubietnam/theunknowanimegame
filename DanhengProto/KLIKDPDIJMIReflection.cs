using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009C0 RID: 2496
	public static class KLIKDPDIJMIReflection
	{
		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x06006F69 RID: 28521 RVA: 0x0012962F File Offset: 0x0012782F
		public static FileDescriptor Descriptor
		{
			get
			{
				return KLIKDPDIJMIReflection.descriptor;
			}
		}

		// Token: 0x04002AD4 RID: 10964
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLTElLRFBESUpNSS5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtLTElL" + "RFBESUpNSRIgCgthdmF0YXJfdHlwZRgDIAEoDjILLkF2YXRhclR5cGUSEQoJ" + "YXZhdGFyX2lkGAsgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(KLIKDPDIJMI), KLIKDPDIJMI.Parser, new string[]
			{
				"AvatarType",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
