using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D10 RID: 3344
	public static class PropAeonInfoReflection
	{
		// Token: 0x17002A19 RID: 10777
		// (get) Token: 0x06009559 RID: 38233 RVA: 0x0018CE4E File Offset: 0x0018B04E
		public static FileDescriptor Descriptor
		{
			get
			{
				return PropAeonInfoReflection.descriptor;
			}
		}

		// Token: 0x040039DF RID: 14815
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJQcm9wQWVvbkluZm8ucHJvdG8iRwoMUHJvcEFlb25JbmZvEhcKD0RpYWxv" + "Z3VlR3JvdXBJZBgLIAEoDRIOCgZBZW9uSWQYDCABKA0SDgoGQWRkRXhwGAMg" + "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PropAeonInfo), PropAeonInfo.Parser, new string[]
			{
				"DialogueGroupId",
				"AeonId",
				"AddExp"
			}, null, null, null, null)
		}));
	}
}
