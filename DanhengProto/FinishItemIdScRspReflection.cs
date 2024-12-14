using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000584 RID: 1412
	public static class FinishItemIdScRspReflection
	{
		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x06003F0A RID: 16138 RVA: 0x000AC1C1 File Offset: 0x000AA3C1
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishItemIdScRspReflection.descriptor;
			}
		}

		// Token: 0x0400191C RID: 6428
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdGaW5pc2hJdGVtSWRTY1JzcC5wcm90byJGChFGaW5pc2hJdGVtSWRTY1Jz" + "cBIPCgdyZXRjb2RlGAUgASgNEg8KB3RleHRfaWQYDiABKA0SDwoHaXRlbV9p" + "ZBgMIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishItemIdScRsp), FinishItemIdScRsp.Parser, new string[]
			{
				"Retcode",
				"TextId",
				"ItemId"
			}, null, null, null, null)
		}));
	}
}
