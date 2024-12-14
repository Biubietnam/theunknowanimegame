using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001176 RID: 4470
	public static class SpAddSourceReflection
	{
		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x0600C77A RID: 51066 RVA: 0x00217493 File Offset: 0x00215693
		public static FileDescriptor Descriptor
		{
			get
			{
				return SpAddSourceReflection.descriptor;
			}
		}

		// Token: 0x04005091 RID: 20625
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFTcEFkZFNvdXJjZS5wcm90byItCgtTcEFkZFNvdXJjZRIOCgZzb3VyY2UY" + "ASABKAkSDgoGc3BfYWRkGAIgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SpAddSource), SpAddSource.Parser, new string[]
			{
				"Source",
				"SpAdd"
			}, null, null, null, null)
		}));
	}
}
