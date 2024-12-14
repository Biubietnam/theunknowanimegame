using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200057C RID: 1404
	public static class FinishFirstTalkByPerformanceNpcScRspReflection
	{
		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x06003EAE RID: 16046 RVA: 0x000AB48A File Offset: 0x000A968A
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishFirstTalkByPerformanceNpcScRspReflection.descriptor;
			}
		}

		// Token: 0x04001900 RID: 6400
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CipGaW5pc2hGaXJzdFRhbGtCeVBlcmZvcm1hbmNlTnBjU2NSc3AucHJvdG8a",
			"Dkl0ZW1MaXN0LnByb3RvImoKJEZpbmlzaEZpcnN0VGFsa0J5UGVyZm9ybWFu",
			"Y2VOcGNTY1JzcBIPCgdyZXRjb2RlGA4gASgNEhYKDnBlcmZvcm1hbmNlX2lk",
			"GAUgASgNEhkKBnJld2FyZBgEIAEoCzIJLkl0ZW1MaXN0Qh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishFirstTalkByPerformanceNpcScRsp), FinishFirstTalkByPerformanceNpcScRsp.Parser, new string[]
			{
				"Retcode",
				"PerformanceId",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
