using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001A6 RID: 422
	public static class ChallengeGroupReflection
	{
		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x00037183 File Offset: 0x00035383
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeGroupReflection.descriptor;
			}
		}

		// Token: 0x0400080D RID: 2061
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRDaGFsbGVuZ2VHcm91cC5wcm90byJECg5DaGFsbGVuZ2VHcm91cBIQCghn" + "cm91cF9pZBgBIAEoDRIgChh0YWtlbl9zdGFyc19jb3VudF9yZXdhcmQYBSAB" + "KARCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeGroup), ChallengeGroup.Parser, new string[]
			{
				"GroupId",
				"TakenStarsCountReward"
			}, null, null, null, null)
		}));
	}
}
