using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001410 RID: 5136
	public static class VectorReflection
	{
		// Token: 0x17004057 RID: 16471
		// (get) Token: 0x0600E527 RID: 58663 RVA: 0x002615EC File Offset: 0x0025F7EC
		public static FileDescriptor Descriptor
		{
			get
			{
				return VectorReflection.descriptor;
			}
		}

		// Token: 0x04005B06 RID: 23302
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CgxWZWN0b3IucHJvdG8iKQoGVmVjdG9yEgkKAXkYDyABKBESCQoBehgKIAEo" + "ERIJCgF4GAYgASgRQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Vector), Vector.Parser, new string[]
			{
				"Y",
				"Z",
				"X"
			}, null, null, null, null)
		}));
	}
}
