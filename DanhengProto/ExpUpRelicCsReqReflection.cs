using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004EC RID: 1260
	public static class ExpUpRelicCsReqReflection
	{
		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06003863 RID: 14435 RVA: 0x0009A7BB File Offset: 0x000989BB
		public static FileDescriptor Descriptor
		{
			get
			{
				return ExpUpRelicCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400164F RID: 5711
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVFeHBVcFJlbGljQ3NSZXEucHJvdG8aEkl0ZW1Db3N0RGF0YS5wcm90byJM" + "Cg9FeHBVcFJlbGljQ3NSZXESIAoJY29zdF9kYXRhGAsgASgLMg0uSXRlbUNv" + "c3REYXRhEhcKD3JlbGljX3VuaXF1ZV9pZBgKIAEoDUIeqgIbRWdnTGluay5E" + "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ExpUpRelicCsReq), ExpUpRelicCsReq.Parser, new string[]
			{
				"CostData",
				"RelicUniqueId"
			}, null, null, null, null)
		}));
	}
}
