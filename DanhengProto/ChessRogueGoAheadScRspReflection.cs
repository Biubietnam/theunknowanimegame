using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200022C RID: 556
	public static class ChessRogueGoAheadScRspReflection
	{
		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x0004909E File Offset: 0x0004729E
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueGoAheadScRspReflection.descriptor;
			}
		}

		// Token: 0x04000AB1 RID: 2737
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDaGVzc1JvZ3VlR29BaGVhZFNjUnNwLnByb3RvIjoKFkNoZXNzUm9ndWVH" + "b0FoZWFkU2NSc3ASDwoHY2VsbF9pZBgJIAEoDRIPCgdyZXRjb2RlGAogASgN" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueGoAheadScRsp), ChessRogueGoAheadScRsp.Parser, new string[]
			{
				"CellId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
