using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DC2 RID: 3522
	public static class ReportPlayerScRspReflection
	{
		// Token: 0x17002C7C RID: 11388
		// (get) Token: 0x06009D86 RID: 40326 RVA: 0x001A3C8C File Offset: 0x001A1E8C
		public static FileDescriptor Descriptor
		{
			get
			{
				return ReportPlayerScRspReflection.descriptor;
			}
		}

		// Token: 0x04003D47 RID: 15687
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdSZXBvcnRQbGF5ZXJTY1JzcC5wcm90byIkChFSZXBvcnRQbGF5ZXJTY1Jz" + "cBIPCgdyZXRjb2RlGA0gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ReportPlayerScRsp), ReportPlayerScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
