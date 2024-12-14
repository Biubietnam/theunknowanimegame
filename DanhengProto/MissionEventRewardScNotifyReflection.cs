using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ADE RID: 2782
	public static class MissionEventRewardScNotifyReflection
	{
		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x06007B44 RID: 31556 RVA: 0x0014634C File Offset: 0x0014454C
		public static FileDescriptor Descriptor
		{
			get
			{
				return MissionEventRewardScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04002F46 RID: 12102
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBNaXNzaW9uRXZlbnRSZXdhcmRTY05vdGlmeS5wcm90bxoOSXRlbUxpc3Qu" + "cHJvdG8iUQoaTWlzc2lvbkV2ZW50UmV3YXJkU2NOb3RpZnkSGQoGcmV3YXJk" + "GA8gASgLMgkuSXRlbUxpc3QSGAoQbWlzc2lvbl9ldmVudF9pZBgOIAEoDUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MissionEventRewardScNotify), MissionEventRewardScNotify.Parser, new string[]
			{
				"Reward",
				"MissionEventId"
			}, null, null, null, null)
		}));
	}
}
