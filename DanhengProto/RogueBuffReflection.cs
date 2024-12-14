using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E16 RID: 3606
	public static class RogueBuffReflection
	{
		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x0600A116 RID: 41238 RVA: 0x001AFF29 File Offset: 0x001AE129
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueBuffReflection.descriptor;
			}
		}

		// Token: 0x040041F5 RID: 16885
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9Sb2d1ZUJ1ZmYucHJvdG8iKwoJUm9ndWVCdWZmEg8KB2J1ZmZfaWQYDyAB" + "KA0SDQoFbGV2ZWwYCSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueBuff), RogueBuff.Parser, new string[]
			{
				"BuffId",
				"Level"
			}, null, null, null, null)
		}));
	}
}
