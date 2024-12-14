using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005F2 RID: 1522
	public static class GenderReflection
	{
		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x06004463 RID: 17507 RVA: 0x000BBB8E File Offset: 0x000B9D8E
		public static FileDescriptor Descriptor
		{
			get
			{
				return GenderReflection.descriptor;
			}
		}

		// Token: 0x04001B60 RID: 7008
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CgxHZW5kZXIucHJvdG8qOAoGR2VuZGVyEg4KCkdlbmRlck5vbmUQABINCglH" + "ZW5kZXJNYW4QARIPCgtHZW5kZXJXb21hbhACQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[]
		{
			typeof(Gender)
		}, null, null));
	}
}
