using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000466 RID: 1126
	public static class EnterSectionCsReqReflection
	{
		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x0600322D RID: 12845 RVA: 0x0008A2C3 File Offset: 0x000884C3
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterSectionCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001402 RID: 5122
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdFbnRlclNlY3Rpb25Dc1JlcS5wcm90byInChFFbnRlclNlY3Rpb25Dc1Jl" + "cRISCgpzZWN0aW9uX2lkGAkgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterSectionCsReq), EnterSectionCsReq.Parser, new string[]
			{
				"SectionId"
			}, null, null, null, null)
		}));
	}
}
