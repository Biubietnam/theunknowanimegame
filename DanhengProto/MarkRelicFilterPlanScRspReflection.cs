using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A92 RID: 2706
	public static class MarkRelicFilterPlanScRspReflection
	{
		// Token: 0x170021B1 RID: 8625
		// (get) Token: 0x06007802 RID: 30722 RVA: 0x0013E1BD File Offset: 0x0013C3BD
		public static FileDescriptor Descriptor
		{
			get
			{
				return MarkRelicFilterPlanScRspReflection.descriptor;
			}
		}

		// Token: 0x04002E0D RID: 11789
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5NYXJrUmVsaWNGaWx0ZXJQbGFuU2NSc3AucHJvdG8iZQoYTWFya1JlbGlj" + "RmlsdGVyUGxhblNjUnNwEg8KB3JldGNvZGUYASABKA0SFQoNU2xvdEluZGV4" + "TGlzdBgDIAMoDRIOCgZJc01hcmsYCCABKAgSEQoJSXNCYXRjaE9wGAkgASgI" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MarkRelicFilterPlanScRsp), MarkRelicFilterPlanScRsp.Parser, new string[]
			{
				"Retcode",
				"SlotIndexList",
				"IsMark",
				"IsBatchOp"
			}, null, null, null, null)
		}));
	}
}
