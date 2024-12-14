using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E5A RID: 3674
	public static class RogueCommonMoneyReflection
	{
		// Token: 0x17002E46 RID: 11846
		// (get) Token: 0x0600A3E9 RID: 41961 RVA: 0x001B8BAD File Offset: 0x001B6DAD
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonMoneyReflection.descriptor;
			}
		}

		// Token: 0x0400430C RID: 17164
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZSb2d1ZUNvbW1vbk1vbmV5LnByb3RvIjUKEFJvZ3VlQ29tbW9uTW9uZXkS" + "FAoMZGlzcGxheV90eXBlGAQgASgNEgsKA251bRgJIAEoDUIeqgIbRWdnTGlu" + "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonMoney), RogueCommonMoney.Parser, new string[]
			{
				"DisplayType",
				"Num"
			}, null, null, null, null)
		}));
	}
}
