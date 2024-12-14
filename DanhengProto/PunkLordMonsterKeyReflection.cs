using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D2C RID: 3372
	public static class PunkLordMonsterKeyReflection
	{
		// Token: 0x17002A7F RID: 10879
		// (get) Token: 0x060096A6 RID: 38566 RVA: 0x00190EDB File Offset: 0x0018F0DB
		public static FileDescriptor Descriptor
		{
			get
			{
				return PunkLordMonsterKeyReflection.descriptor;
			}
		}

		// Token: 0x04003A7A RID: 14970
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhQdW5rTG9yZE1vbnN0ZXJLZXkucHJvdG8iNQoSUHVua0xvcmRNb25zdGVy" + "S2V5EgsKA3VpZBgBIAEoDRISCgptb25zdGVyX2lkGAIgASgNQh6qAhtFZ2dM" + "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PunkLordMonsterKey), PunkLordMonsterKey.Parser, new string[]
			{
				"Uid",
				"MonsterId"
			}, null, null, null, null)
		}));
	}
}
