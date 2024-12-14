using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200130E RID: 4878
	public static class TakePromotionRewardScRspReflection
	{
		// Token: 0x17003D27 RID: 15655
		// (get) Token: 0x0600D9A7 RID: 55719 RVA: 0x00243DC1 File Offset: 0x00241FC1
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakePromotionRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x040056B8 RID: 22200
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5UYWtlUHJvbW90aW9uUmV3YXJkU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnBy" + "b3RvIksKGFRha2VQcm9tb3Rpb25SZXdhcmRTY1JzcBIeCgtyZXdhcmRfbGlz" + "dBgBIAEoCzIJLkl0ZW1MaXN0Eg8KB3JldGNvZGUYDCABKA1CHqoCG0VnZ0xp" + "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakePromotionRewardScRsp), TakePromotionRewardScRsp.Parser, new string[]
			{
				"RewardList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
