using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001144 RID: 4420
	public static class ShareDataReflection
	{
		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x0600C52E RID: 50478 RVA: 0x0021123E File Offset: 0x0020F43E
		public static FileDescriptor Descriptor
		{
			get
			{
				return ShareDataReflection.descriptor;
			}
		}

		// Token: 0x04004FA2 RID: 20386
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9TaGFyZURhdGEucHJvdG8iNQoJU2hhcmVEYXRhEhMKC1BCREtPS0VMR0hM" + "GAYgASgNEhMKC0tKTUZNR1BBQ0xMGAQgASgNQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ShareData), ShareData.Parser, new string[]
			{
				"PBDKOKELGHL",
				"KJMFMGPACLL"
			}, null, null, null, null)
		}));
	}
}
