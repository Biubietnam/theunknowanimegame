using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AAC RID: 2732
	public static class Material0Reflection
	{
		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x06007922 RID: 31010 RVA: 0x0014102C File Offset: 0x0013F22C
		public static FileDescriptor Descriptor
		{
			get
			{
				return Material0Reflection.descriptor;
			}
		}

		// Token: 0x04002E7E RID: 11902
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9NYXRlcmlhbDAucHJvdG8iOgoJTWF0ZXJpYWwwEhMKC2V4cGlyZV90aW1l" + "GAYgASgEEgsKA251bRgDIAEoDRILCgN0aWQYCiABKA1CHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Material0), Material0.Parser, new string[]
			{
				"ExpireTime",
				"Num",
				"Tid"
			}, null, null, null, null)
		}));
	}
}
