using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000056 RID: 86
	public static class AetherDivideLineupScNotifyReflection
	{
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000393 RID: 915 RVA: 0x0000B34F File Offset: 0x0000954F
		public static FileDescriptor Descriptor
		{
			get
			{
				return AetherDivideLineupScNotifyReflection.descriptor;
			}
		}

		// Token: 0x0400015E RID: 350
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBBZXRoZXJEaXZpZGVMaW5ldXBTY05vdGlmeS5wcm90bxocQWV0aGVyRGl2" + "aWRlTGluZXVwSW5mby5wcm90byJFChpBZXRoZXJEaXZpZGVMaW5ldXBTY05v" + "dGlmeRInCgZsaW5ldXAYDiABKAsyFy5BZXRoZXJEaXZpZGVMaW5ldXBJbmZv" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			AetherDivideLineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AetherDivideLineupScNotify), AetherDivideLineupScNotify.Parser, new string[]
			{
				"Lineup"
			}, null, null, null, null)
		}));
	}
}
