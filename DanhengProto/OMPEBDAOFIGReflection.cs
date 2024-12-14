using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C64 RID: 3172
	public static class OMPEBDAOFIGReflection
	{
		// Token: 0x17002797 RID: 10135
		// (get) Token: 0x06008CF2 RID: 36082 RVA: 0x001748A8 File Offset: 0x00172AA8
		public static FileDescriptor Descriptor
		{
			get
			{
				return OMPEBDAOFIGReflection.descriptor;
			}
		}

		// Token: 0x04003621 RID: 13857
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTVBFQkRBT0ZJRy5wcm90byItCgtPTVBFQkRBT0ZJRxINCgVsZXZlbBgL" + "IAEoDRIPCgdtYXplX2lkGA4gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(OMPEBDAOFIG), OMPEBDAOFIG.Parser, new string[]
			{
				"Level",
				"MazeId"
			}, null, null, null, null)
		}));
	}
}
