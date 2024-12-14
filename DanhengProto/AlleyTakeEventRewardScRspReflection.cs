using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200009A RID: 154
	public static class AlleyTakeEventRewardScRspReflection
	{
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00012A4E File Offset: 0x00010C4E
		public static FileDescriptor Descriptor
		{
			get
			{
				return AlleyTakeEventRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x0400026F RID: 623
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9BbGxleVRha2VFdmVudFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlzdC5w" + "cm90byJHChlBbGxleVRha2VFdmVudFJld2FyZFNjUnNwEg8KB3JldGNvZGUY" + "DiABKA0SGQoGcmV3YXJkGAggASgLMgkuSXRlbUxpc3RCHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AlleyTakeEventRewardScRsp), AlleyTakeEventRewardScRsp.Parser, new string[]
			{
				"Retcode",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
