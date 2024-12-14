using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000BE RID: 190
	public static class AvatarExpUpCsReqReflection
	{
		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x00019991 File Offset: 0x00017B91
		public static FileDescriptor Descriptor
		{
			get
			{
				return AvatarExpUpCsReqReflection.descriptor;
			}
		}

		// Token: 0x04000384 RID: 900
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZBdmF0YXJFeHBVcENzUmVxLnByb3RvGhJJdGVtQ29zdERhdGEucHJvdG8i" + "TAoQQXZhdGFyRXhwVXBDc1JlcRIWCg5iYXNlX2F2YXRhcl9pZBgMIAEoDRIg" + "CglpdGVtX2Nvc3QYDiABKAsyDS5JdGVtQ29zdERhdGFCHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AvatarExpUpCsReq), AvatarExpUpCsReq.Parser, new string[]
			{
				"BaseAvatarId",
				"ItemCost"
			}, null, null, null, null)
		}));
	}
}
