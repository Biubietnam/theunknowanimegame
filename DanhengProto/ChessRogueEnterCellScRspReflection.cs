using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200020E RID: 526
	public static class ChessRogueEnterCellScRspReflection
	{
		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x0004354C File Offset: 0x0004174C
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueEnterCellScRspReflection.descriptor;
			}
		}

		// Token: 0x040009F2 RID: 2546
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5DaGVzc1JvZ3VlRW50ZXJDZWxsU2NSc3AucHJvdG8aG0NoZXNzUm9ndWVD",
			"dXJyZW50SW5mby5wcm90bxoUQ2hlc3NSb2d1ZUluZm8ucHJvdG8aGENoZXNz",
			"Um9ndWVHYW1lSW5mby5wcm90byK4AQoYQ2hlc3NSb2d1ZUVudGVyQ2VsbFNj",
			"UnNwEiEKBGluZm8YDyABKAsyEy5DaGVzc1JvZ3VlR2FtZUluZm8SDwoHY2Vs",
			"bF9pZBgGIAEoDRIjCgpzdGFnZV9pbmZvGAIgASgLMg8uQ2hlc3NSb2d1ZUlu",
			"Zm8SDwoHcmV0Y29kZRgEIAEoDRIyChJyb2d1ZV9jdXJyZW50X2luZm8YCiAB",
			"KAsyFi5DaGVzc1JvZ3VlQ3VycmVudEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVu",
			"Z1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChessRogueCurrentInfoReflection.Descriptor,
			ChessRogueInfoReflection.Descriptor,
			ChessRogueGameInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueEnterCellScRsp), ChessRogueEnterCellScRsp.Parser, new string[]
			{
				"Info",
				"CellId",
				"StageInfo",
				"Retcode",
				"RogueCurrentInfo"
			}, null, null, null, null)
		}));
	}
}
