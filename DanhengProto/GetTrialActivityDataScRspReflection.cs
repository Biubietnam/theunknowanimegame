using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000836 RID: 2102
	public static class GetTrialActivityDataScRspReflection
	{
		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x06005D8F RID: 23951 RVA: 0x000F81E6 File Offset: 0x000F63E6
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetTrialActivityDataScRspReflection.descriptor;
			}
		}

		// Token: 0x0400241B RID: 9243
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9HZXRUcmlhbEFjdGl2aXR5RGF0YVNjUnNwLnByb3RvGhdUcmlhbEFjdGl2",
			"aXR5SW5mby5wcm90byJ9ChlHZXRUcmlhbEFjdGl2aXR5RGF0YVNjUnNwEjQK",
			"GHRyaWFsX2FjdGl2aXR5X2luZm9fbGlzdBgMIAMoCzISLlRyaWFsQWN0aXZp",
			"dHlJbmZvEg8KB3JldGNvZGUYBSABKA0SGQoRYWN0aXZpdHlfc3RhZ2VfaWQY",
			"CiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			TrialActivityInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetTrialActivityDataScRsp), GetTrialActivityDataScRsp.Parser, new string[]
			{
				"TrialActivityInfoList",
				"Retcode",
				"ActivityStageId"
			}, null, null, null, null)
		}));
	}
}
