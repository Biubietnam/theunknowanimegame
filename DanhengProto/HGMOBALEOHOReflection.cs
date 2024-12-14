using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008E6 RID: 2278
	public static class HGMOBALEOHOReflection
	{
		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x060065A3 RID: 26019 RVA: 0x0010FC81 File Offset: 0x0010DE81
		public static FileDescriptor Descriptor
		{
			get
			{
				return HGMOBALEOHOReflection.descriptor;
			}
		}

		// Token: 0x04002719 RID: 10009
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIR01PQkFMRU9ITy5wcm90byIyCgtIR01PQkFMRU9ITxISCgppdGVtX2Nv" + "dW50GA4gASgNEg8KB2l0ZW1faWQYASABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu" + "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HGMOBALEOHO), HGMOBALEOHO.Parser, new string[]
			{
				"ItemCount",
				"ItemId"
			}, null, null, null, null)
		}));
	}
}
