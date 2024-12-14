using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011C2 RID: 4546
	public static class StartRaidScRspReflection
	{
		// Token: 0x1700394C RID: 14668
		// (get) Token: 0x0600CB24 RID: 52004 RVA: 0x002211D9 File Offset: 0x0021F3D9
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartRaidScRspReflection.descriptor;
			}
		}

		// Token: 0x040051EF RID: 20975
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRTdGFydFJhaWRTY1JzcC5wcm90bxoRT0lJT0xDUEJMQ0YucHJvdG8iPgoO" + "U3RhcnRSYWlkU2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIbCgVzY2VuZRgKIAEo" + "CzIMLk9JSU9MQ1BCTENGQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			OIIOLCPBLCFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartRaidScRsp), StartRaidScRsp.Parser, new string[]
			{
				"Retcode",
				"Scene"
			}, null, null, null, null)
		}));
	}
}
