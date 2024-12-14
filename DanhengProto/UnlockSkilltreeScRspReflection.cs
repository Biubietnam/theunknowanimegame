using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013C8 RID: 5064
	public static class UnlockSkilltreeScRspReflection
	{
		// Token: 0x17003F69 RID: 16233
		// (get) Token: 0x0600E1C5 RID: 57797 RVA: 0x00258AEE File Offset: 0x00256CEE
		public static FileDescriptor Descriptor
		{
			get
			{
				return UnlockSkilltreeScRspReflection.descriptor;
			}
		}

		// Token: 0x040059D8 RID: 23000
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpVbmxvY2tTa2lsbHRyZWVTY1JzcC5wcm90byJIChRVbmxvY2tTa2lsbHRy" + "ZWVTY1JzcBIPCgdyZXRjb2RlGAcgASgNEhAKCHBvaW50X2lkGAwgASgNEg0K" + "BWxldmVsGAYgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UnlockSkilltreeScRsp), UnlockSkilltreeScRsp.Parser, new string[]
			{
				"Retcode",
				"PointId",
				"Level"
			}, null, null, null, null)
		}));
	}
}
