using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000468 RID: 1128
	public static class EnterSectionScRspReflection
	{
		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06003242 RID: 12866 RVA: 0x0008A532 File Offset: 0x00088732
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterSectionScRspReflection.descriptor;
			}
		}

		// Token: 0x04001407 RID: 5127
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdFbnRlclNlY3Rpb25TY1JzcC5wcm90byIkChFFbnRlclNlY3Rpb25TY1Jz" + "cBIPCgdyZXRjb2RlGAEgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterSectionScRsp), EnterSectionScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
