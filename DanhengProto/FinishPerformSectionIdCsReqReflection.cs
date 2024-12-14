using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000586 RID: 1414
	public static class FinishPerformSectionIdCsReqReflection
	{
		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x06003F23 RID: 16163 RVA: 0x000AC5B0 File Offset: 0x000AA7B0
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishPerformSectionIdCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001925 RID: 6437
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFGaW5pc2hQZXJmb3JtU2VjdGlvbklkQ3NSZXEucHJvdG8aEU1lc3NhZ2VJ" + "dGVtLnByb3RvIlIKG0ZpbmlzaFBlcmZvcm1TZWN0aW9uSWRDc1JlcRISCgpz" + "ZWN0aW9uX2lkGAMgASgNEh8KCWl0ZW1fbGlzdBgHIAMoCzIMLk1lc3NhZ2VJ" + "dGVtQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			MessageItemReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishPerformSectionIdCsReq), FinishPerformSectionIdCsReq.Parser, new string[]
			{
				"SectionId",
				"ItemList"
			}, null, null, null, null)
		}));
	}
}
