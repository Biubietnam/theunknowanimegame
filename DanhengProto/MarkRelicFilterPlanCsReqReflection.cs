using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A90 RID: 2704
	public static class MarkRelicFilterPlanCsReqReflection
	{
		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x060077EA RID: 30698 RVA: 0x0013DDD1 File Offset: 0x0013BFD1
		public static FileDescriptor Descriptor
		{
			get
			{
				return MarkRelicFilterPlanCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002E03 RID: 11779
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5NYXJrUmVsaWNGaWx0ZXJQbGFuQ3NSZXEucHJvdG8iVAoYTWFya1JlbGlj" + "RmlsdGVyUGxhbkNzUmVxEg4KBklzTWFyaxgOIAEoCBIVCg1TbG90SW5kZXhM" + "aXN0GAkgAygNEhEKCUlzQmF0Y2hPcBgLIAEoCEIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MarkRelicFilterPlanCsReq), MarkRelicFilterPlanCsReq.Parser, new string[]
			{
				"IsMark",
				"SlotIndexList",
				"IsBatchOp"
			}, null, null, null, null)
		}));
	}
}
