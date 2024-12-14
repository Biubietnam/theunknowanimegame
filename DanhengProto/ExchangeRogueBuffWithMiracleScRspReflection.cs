using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004DC RID: 1244
	public static class ExchangeRogueBuffWithMiracleScRspReflection
	{
		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x060037AB RID: 14251 RVA: 0x00098A90 File Offset: 0x00096C90
		public static FileDescriptor Descriptor
		{
			get
			{
				return ExchangeRogueBuffWithMiracleScRspReflection.descriptor;
			}
		}

		// Token: 0x0400160B RID: 5643
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CidFeGNoYW5nZVJvZ3VlQnVmZldpdGhNaXJhY2xlU2NSc3AucHJvdG8aFVJv",
			"Z3VlQ29tbW9uQnVmZi5wcm90byJUCiFFeGNoYW5nZVJvZ3VlQnVmZldpdGhN",
			"aXJhY2xlU2NSc3ASHgoEYnVmZhgOIAEoCzIQLlJvZ3VlQ29tbW9uQnVmZhIP",
			"CgdyZXRjb2RlGAcgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueCommonBuffReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ExchangeRogueBuffWithMiracleScRsp), ExchangeRogueBuffWithMiracleScRsp.Parser, new string[]
			{
				"Buff",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
