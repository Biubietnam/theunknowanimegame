using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001404 RID: 5124
	public static class UpgradeAreaStatCsReqReflection
	{
		// Token: 0x17004027 RID: 16423
		// (get) Token: 0x0600E485 RID: 58501 RVA: 0x0025F8F0 File Offset: 0x0025DAF0
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpgradeAreaStatCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005AC4 RID: 23236
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpVcGdyYWRlQXJlYVN0YXRDc1JlcS5wcm90bxoOU3RhdFR5cGUucHJvdG8i" + "VgoUVXBncmFkZUFyZWFTdGF0Q3NSZXESDwoHYXJlYV9pZBgKIAEoDRINCgVs" + "ZXZlbBgGIAEoDRIeCgtJRkpFQk9JRUdGRxgCIAEoDjIJLlN0YXRUeXBlQh6q" + "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			StatTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpgradeAreaStatCsReq), UpgradeAreaStatCsReq.Parser, new string[]
			{
				"AreaId",
				"Level",
				"IFJEBOIEGFG"
			}, null, null, null, null)
		}));
	}
}
