using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A88 RID: 2696
	public static class MarkItemCsReqReflection
	{
		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x0600778E RID: 30606 RVA: 0x0013D124 File Offset: 0x0013B324
		public static FileDescriptor Descriptor
		{
			get
			{
				return MarkItemCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002DE7 RID: 11751
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNNYXJrSXRlbUNzUmVxLnByb3RvIjUKDU1hcmtJdGVtQ3NSZXESDwoHaXRl" + "bV9pZBgIIAEoDRITCgtGQkVISUNCS0NBTRgJIAEoCEIeqgIbRWdnTGluay5E" + "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MarkItemCsReq), MarkItemCsReq.Parser, new string[]
			{
				"ItemId",
				"FBEHICBKCAM"
			}, null, null, null, null)
		}));
	}
}
