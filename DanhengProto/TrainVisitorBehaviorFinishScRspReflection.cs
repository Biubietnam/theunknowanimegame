using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001362 RID: 4962
	public static class TrainVisitorBehaviorFinishScRspReflection
	{
		// Token: 0x17003E2F RID: 15919
		// (get) Token: 0x0600DD6B RID: 56683 RVA: 0x0024D592 File Offset: 0x0024B792
		public static FileDescriptor Descriptor
		{
			get
			{
				return TrainVisitorBehaviorFinishScRspReflection.descriptor;
			}
		}

		// Token: 0x0400580E RID: 22542
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiVUcmFpblZpc2l0b3JCZWhhdmlvckZpbmlzaFNjUnNwLnByb3RvGg5JdGVt",
			"TGlzdC5wcm90byJiCh9UcmFpblZpc2l0b3JCZWhhdmlvckZpbmlzaFNjUnNw",
			"Eg8KB3JldGNvZGUYCyABKA0SEwoLREpMS0NIS01OTUkYBSABKA0SGQoGcmV3",
			"YXJkGAkgASgLMgkuSXRlbUxpc3RCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TrainVisitorBehaviorFinishScRsp), TrainVisitorBehaviorFinishScRsp.Parser, new string[]
			{
				"Retcode",
				"DJLKCHKMNMI",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
