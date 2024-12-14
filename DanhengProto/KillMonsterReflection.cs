using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009B2 RID: 2482
	public static class KillMonsterReflection
	{
		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x06006EF5 RID: 28405 RVA: 0x0012860E File Offset: 0x0012680E
		public static FileDescriptor Descriptor
		{
			get
			{
				return KillMonsterReflection.descriptor;
			}
		}

		// Token: 0x04002AA1 RID: 10913
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLaWxsTW9uc3Rlci5wcm90byIzCgtLaWxsTW9uc3RlchISCgptb25zdGVy" + "X2lkGAggASgNEhAKCGtpbGxfbnVtGA0gASgNQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(KillMonster), KillMonster.Parser, new string[]
			{
				"MonsterId",
				"KillNum"
			}, null, null, null, null)
		}));
	}
}
