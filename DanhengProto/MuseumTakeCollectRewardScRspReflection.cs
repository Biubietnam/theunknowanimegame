using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BCE RID: 3022
	public static class MuseumTakeCollectRewardScRspReflection
	{
		// Token: 0x1700257F RID: 9599
		// (get) Token: 0x060085BB RID: 34235 RVA: 0x00161009 File Offset: 0x0015F209
		public static FileDescriptor Descriptor
		{
			get
			{
				return MuseumTakeCollectRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x04003339 RID: 13113
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJNdXNldW1UYWtlQ29sbGVjdFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz",
			"dC5wcm90byJbChxNdXNldW1UYWtlQ29sbGVjdFJld2FyZFNjUnNwEg8KB2l0",
			"ZW1faWQYDiABKA0SDwoHcmV0Y29kZRgMIAEoDRIZCgZyZXdhcmQYASABKAsy",
			"CS5JdGVtTGlzdEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MuseumTakeCollectRewardScRsp), MuseumTakeCollectRewardScRsp.Parser, new string[]
			{
				"ItemId",
				"Retcode",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
