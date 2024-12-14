using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200064A RID: 1610
	public static class GetChapterCsReqReflection
	{
		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x0600484B RID: 18507 RVA: 0x000C5DF6 File Offset: 0x000C3FF6
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetChapterCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001CEA RID: 7402
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVHZXRDaGFwdGVyQ3NSZXEucHJvdG8iEQoPR2V0Q2hhcHRlckNzUmVxQh6q" + "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetChapterCsReq), GetChapterCsReq.Parser, null, null, null, null, null)
		}));
	}
}
