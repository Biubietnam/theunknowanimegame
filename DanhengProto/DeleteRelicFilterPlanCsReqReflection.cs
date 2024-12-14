using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000374 RID: 884
	public static class DeleteRelicFilterPlanCsReqReflection
	{
		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x0006DED8 File Offset: 0x0006C0D8
		public static FileDescriptor Descriptor
		{
			get
			{
				return DeleteRelicFilterPlanCsReqReflection.descriptor;
			}
		}

		// Token: 0x04000FE0 RID: 4064
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBEZWxldGVSZWxpY0ZpbHRlclBsYW5Dc1JlcS5wcm90byJGChpEZWxldGVS" + "ZWxpY0ZpbHRlclBsYW5Dc1JlcRIRCglJc0JhdGNoT3AYCiABKAgSFQoNU2xv" + "dEluZGV4TGlzdBgBIAMoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DeleteRelicFilterPlanCsReq), DeleteRelicFilterPlanCsReq.Parser, new string[]
			{
				"IsBatchOp",
				"SlotIndexList"
			}, null, null, null, null)
		}));
	}
}
