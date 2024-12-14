using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C78 RID: 3192
	public static class OptionalRewardReflection
	{
		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x06008DE6 RID: 36326 RVA: 0x00176F8D File Offset: 0x0017518D
		public static FileDescriptor Descriptor
		{
			get
			{
				return OptionalRewardReflection.descriptor;
			}
		}

		// Token: 0x04003679 RID: 13945
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRPcHRpb25hbFJld2FyZC5wcm90byI7Cg5PcHRpb25hbFJld2FyZBIaChJv" + "cHRpb25hbF9yZXdhcmRfaWQYCCABKA0SDQoFbGV2ZWwYCSABKA1CHqoCG0Vn" + "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(OptionalReward), OptionalReward.Parser, new string[]
			{
				"OptionalRewardId",
				"Level"
			}, null, null, null, null)
		}));
	}
}
