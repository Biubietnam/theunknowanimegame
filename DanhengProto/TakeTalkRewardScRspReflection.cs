using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200133A RID: 4922
	public static class TakeTalkRewardScRspReflection
	{
		// Token: 0x17003DB7 RID: 15799
		// (get) Token: 0x0600DBB0 RID: 56240 RVA: 0x002491F0 File Offset: 0x002473F0
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeTalkRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x04005773 RID: 22387
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlUYWtlVGFsa1Jld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byJW" + "ChNUYWtlVGFsa1Jld2FyZFNjUnNwEhMKC01NS0lBTkxIUExKGAggASgNEhkK" + "BnJld2FyZBgOIAEoCzIJLkl0ZW1MaXN0Eg8KB3JldGNvZGUYDyABKA1CHqoC" + "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeTalkRewardScRsp), TakeTalkRewardScRsp.Parser, new string[]
			{
				"MMKIANLHPLJ",
				"Reward",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
