using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012D8 RID: 4824
	public static class TakeFightActivityRewardScRspReflection
	{
		// Token: 0x17003C81 RID: 15489
		// (get) Token: 0x0600D73E RID: 55102 RVA: 0x0023DFE5 File Offset: 0x0023C1E5
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeFightActivityRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x040055E7 RID: 21991
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJUYWtlRmlnaHRBY3Rpdml0eVJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz",
			"dC5wcm90byJxChxUYWtlRmlnaHRBY3Rpdml0eVJld2FyZFNjUnNwEhkKBnJl",
			"d2FyZBgEIAEoCzIJLkl0ZW1MaXN0EhMKC0FIRk5HUExEQUlJGAggASgNEhAK",
			"CGdyb3VwX2lkGA0gASgNEg8KB3JldGNvZGUYCyABKA1CHqoCG0VnZ0xpbmsu",
			"RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeFightActivityRewardScRsp), TakeFightActivityRewardScRsp.Parser, new string[]
			{
				"Reward",
				"AHFNGPLDAII",
				"GroupId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
