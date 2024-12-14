using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200017A RID: 378
	public static class CellInfoReflection
	{
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x00030CC3 File Offset: 0x0002EEC3
		public static FileDescriptor Descriptor
		{
			get
			{
				return CellInfoReflection.descriptor;
			}
		}

		// Token: 0x04000710 RID: 1808
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Cg5DZWxsSW5mby5wcm90bxoUQ2hlc3NSb2d1ZUNlbGwucHJvdG8iggEKCENl",
			"bGxJbmZvEiIKCWNlbGxfbGlzdBgJIAMoCzIPLkNoZXNzUm9ndWVDZWxsEhMK",
			"C0ROT05FT0FNT0dDGAogASgNEhMKC09FR0pITUxNRkROGAUgASgNEhMKC0JB",
			"R0FQR0ZLRUhDGAIgASgNEhMKC0hJRkpHTUNBTE9PGAMgASgNQh6qAhtFZ2dM",
			"aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChessRogueCellReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CellInfo), CellInfo.Parser, new string[]
			{
				"CellList",
				"DNONEOAMOGC",
				"OEGJHMLMFDN",
				"BAGAPGFKEHC",
				"HIFJGMCALOO"
			}, null, null, null, null)
		}));
	}
}
