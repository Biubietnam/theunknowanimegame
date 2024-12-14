using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012E0 RID: 4832
	public static class TakeLoginActivityRewardScRspReflection
	{
		// Token: 0x17003C9D RID: 15517
		// (get) Token: 0x0600D7A1 RID: 55201 RVA: 0x0023F099 File Offset: 0x0023D299
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeLoginActivityRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x0400560C RID: 22028
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJUYWtlTG9naW5BY3Rpdml0eVJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz",
			"dC5wcm90byJpChxUYWtlTG9naW5BY3Rpdml0eVJld2FyZFNjUnNwEg8KB3Jl",
			"dGNvZGUYDyABKA0SGQoGcmV3YXJkGAQgASgLMgkuSXRlbUxpc3QSCgoCaWQY",
			"CSABKA0SEQoJdGFrZV9kYXlzGAMgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
			"ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeLoginActivityRewardScRsp), TakeLoginActivityRewardScRsp.Parser, new string[]
			{
				"Retcode",
				"Reward",
				"Id",
				"TakeDays"
			}, null, null, null, null)
		}));
	}
}
