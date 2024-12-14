using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DA0 RID: 3488
	public static class RelicAvatarRecommendScRspReflection
	{
		// Token: 0x17002BFA RID: 11258
		// (get) Token: 0x06009BE2 RID: 39906 RVA: 0x0019EE06 File Offset: 0x0019D006
		public static FileDescriptor Descriptor
		{
			get
			{
				return RelicAvatarRecommendScRspReflection.descriptor;
			}
		}

		// Token: 0x04003C81 RID: 15489
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9SZWxpY0F2YXRhclJlY29tbWVuZFNjUnNwLnByb3RvIn0KGVJlbGljQXZh",
			"dGFyUmVjb21tZW5kU2NSc3ASEwoLRU9MR1BKSUdPRE4YDyABKA0SFgoOYXZh",
			"dGFyX2lkX2xpc3QYDSADKA0SDwoHcmV0Y29kZRgMIAEoDRIiChpST0dVRV9U",
			"QUxFTlRfU1RBVFVTX0VOQUJMRRgGIAEoCEIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RelicAvatarRecommendScRsp), RelicAvatarRecommendScRsp.Parser, new string[]
			{
				"EOLGPJIGODN",
				"AvatarIdList",
				"Retcode",
				"ROGUETALENTSTATUSENABLE"
			}, null, null, null, null)
		}));
	}
}
