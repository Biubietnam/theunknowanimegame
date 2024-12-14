using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B80 RID: 2944
	public static class MonopolyTakePhaseRewardScRspReflection
	{
		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x0600824F RID: 33359 RVA: 0x00157230 File Offset: 0x00155430
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonopolyTakePhaseRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x040031AF RID: 12719
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJNb25vcG9seVRha2VQaGFzZVJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz",
			"dC5wcm90byJkChxNb25vcG9seVRha2VQaGFzZVJld2FyZFNjUnNwEh4KC3Jl",
			"d2FyZF9saXN0GAUgASgLMgkuSXRlbUxpc3QSEwoLSEFIUERDQ0hNSEIYAiAD",
			"KA0SDwoHcmV0Y29kZRgPIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyTakePhaseRewardScRsp), MonopolyTakePhaseRewardScRsp.Parser, new string[]
			{
				"RewardList",
				"HAHPDCCHMHB",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
