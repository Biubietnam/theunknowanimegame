using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000192 RID: 402
	public static class ChallengeBossBuffInfoReflection
	{
		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00033CAE File Offset: 0x00031EAE
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeBossBuffInfoReflection.descriptor;
			}
		}

		// Token: 0x0400078D RID: 1933
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDaGFsbGVuZ2VCb3NzQnVmZkluZm8ucHJvdG8iOwoVQ2hhbGxlbmdlQm9z" + "c0J1ZmZJbmZvEhAKCGJ1ZmZfdHdvGAcgASgNEhAKCGJ1ZmZfb25lGAEgASgN" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossBuffInfo), ChallengeBossBuffInfo.Parser, new string[]
			{
				"BuffTwo",
				"BuffOne"
			}, null, null, null, null)
		}));
	}
}
