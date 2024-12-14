using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001E4 RID: 484
	public static class ChessRogueBuffReflection
	{
		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x0003E655 File Offset: 0x0003C855
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueBuffReflection.descriptor;
			}
		}

		// Token: 0x0400092B RID: 2347
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRDaGVzc1JvZ3VlQnVmZi5wcm90bxoVUm9ndWVDb21tb25CdWZmLnByb3Rv" + "IjUKDkNoZXNzUm9ndWVCdWZmEiMKCWJ1ZmZfbGlzdBgKIAMoCzIQLlJvZ3Vl" + "Q29tbW9uQnVmZkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[]
		{
			RogueCommonBuffReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueBuff), ChessRogueBuff.Parser, new string[]
			{
				"BuffList"
			}, null, null, null, null)
		}));
	}
}
