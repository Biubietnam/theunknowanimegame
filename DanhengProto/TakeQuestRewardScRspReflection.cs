using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200131A RID: 4890
	public static class TakeQuestRewardScRspReflection
	{
		// Token: 0x17003D4D RID: 15693
		// (get) Token: 0x0600DA34 RID: 55860 RVA: 0x00245384 File Offset: 0x00243584
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeQuestRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x040056E7 RID: 22247
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpUYWtlUXVlc3RSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8i" + "WwoUVGFrZVF1ZXN0UmV3YXJkU2NSc3ASFwoPU3VjY1F1ZXN0SWRMaXN0GAkg" + "AygNEhkKBnJld2FyZBgLIAEoCzIJLkl0ZW1MaXN0Eg8KB3JldGNvZGUYDSAB" + "KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeQuestRewardScRsp), TakeQuestRewardScRsp.Parser, new string[]
			{
				"SuccQuestIdList",
				"Reward",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
