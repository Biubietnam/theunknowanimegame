using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200019E RID: 414
	public static class ChallengeBossSingleNodeInfoReflection
	{
		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00035F0E File Offset: 0x0003410E
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeBossSingleNodeInfoReflection.descriptor;
			}
		}

		// Token: 0x040007E4 RID: 2020
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDaGFsbGVuZ2VCb3NzU2luZ2xlTm9kZUluZm8ucHJvdG8iZgobQ2hhbGxl" + "bmdlQm9zc1NpbmdsZU5vZGVJbmZvEhMKC0hHSURKSEZOQ01BGAUgASgIEg4K" + "BmlzX3dpbhgEIAEoCBIRCgltYXhfc2NvcmUYDCABKA0SDwoHYnVmZl9pZBgJ" + "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossSingleNodeInfo), ChallengeBossSingleNodeInfo.Parser, new string[]
			{
				"HGIDJHFNCMA",
				"IsWin",
				"MaxScore",
				"BuffId"
			}, null, null, null, null)
		}));
	}
}
