using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012D4 RID: 4820
	public static class TakeExpeditionRewardScRspReflection
	{
		// Token: 0x17003C73 RID: 15475
		// (get) Token: 0x0600D70C RID: 55052 RVA: 0x0023D762 File Offset: 0x0023B962
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeExpeditionRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x040055D5 RID: 21973
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9UYWtlRXhwZWRpdGlvblJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlzdC5w",
			"cm90byJ8ChlUYWtlRXhwZWRpdGlvblJld2FyZFNjUnNwEh4KC0tDR09CT0tO",
			"TUZIGAQgASgLMgkuSXRlbUxpc3QSEwoLR0xJRVBGRU5QSEgYASABKA0SDwoH",
			"cmV0Y29kZRgCIAEoDRIZCgZyZXdhcmQYBSABKAsyCS5JdGVtTGlzdEIeqgIb",
			"RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeExpeditionRewardScRsp), TakeExpeditionRewardScRsp.Parser, new string[]
			{
				"KCGOBOKNMFH",
				"GLIEPFENPHH",
				"Retcode",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
