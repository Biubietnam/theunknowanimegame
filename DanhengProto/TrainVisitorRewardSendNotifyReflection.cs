using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001366 RID: 4966
	public static class TrainVisitorRewardSendNotifyReflection
	{
		// Token: 0x17003E3F RID: 15935
		// (get) Token: 0x0600DDA0 RID: 56736 RVA: 0x0024DF70 File Offset: 0x0024C170
		public static FileDescriptor Descriptor
		{
			get
			{
				return TrainVisitorRewardSendNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005825 RID: 22565
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJUcmFpblZpc2l0b3JSZXdhcmRTZW5kTm90aWZ5LnByb3RvGhFLRkhJQU1B",
			"REhLRi5wcm90bxoOSXRlbUxpc3QucHJvdG8iagocVHJhaW5WaXNpdG9yUmV3",
			"YXJkU2VuZE5vdGlmeRIaCgR0eXBlGAIgASgOMgwuS0ZISUFNQURIS0YSEwoL",
			"REpMS0NIS01OTUkYCyABKA0SGQoGcmV3YXJkGA0gASgLMgkuSXRlbUxpc3RC",
			"HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			KFHIAMADHKFReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TrainVisitorRewardSendNotify), TrainVisitorRewardSendNotify.Parser, new string[]
			{
				"Type",
				"DJLKCHKMNMI",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
