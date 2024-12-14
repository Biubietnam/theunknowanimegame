using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E36 RID: 3638
	public static class RogueCommonBuffReflection
	{
		// Token: 0x17002DD3 RID: 11731
		// (get) Token: 0x0600A24E RID: 41550 RVA: 0x001B4581 File Offset: 0x001B2781
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonBuffReflection.descriptor;
			}
		}

		// Token: 0x04004270 RID: 17008
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVSb2d1ZUNvbW1vbkJ1ZmYucHJvdG8iNgoPUm9ndWVDb21tb25CdWZmEhIK" + "CmJ1ZmZfbGV2ZWwYBSABKA0SDwoHYnVmZl9pZBgGIAEoDUIeqgIbRWdnTGlu" + "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonBuff), RogueCommonBuff.Parser, new string[]
			{
				"BuffLevel",
				"BuffId"
			}, null, null, null, null)
		}));
	}
}
