using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200026C RID: 620
	public static class ChessRogueQueryAeonDimensionsScRspReflection
	{
		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x0004F906 File Offset: 0x0004DB06
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryAeonDimensionsScRspReflection.descriptor;
			}
		}

		// Token: 0x04000BA0 RID: 2976
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CihDaGVzc1JvZ3VlUXVlcnlBZW9uRGltZW5zaW9uc1NjUnNwLnByb3RvGh1D",
			"aGVzc1JvZ3VlUXVlcnlBZW9uSW5mby5wcm90byJdCiJDaGVzc1JvZ3VlUXVl",
			"cnlBZW9uRGltZW5zaW9uc1NjUnNwEg8KB3JldGNvZGUYDyABKA0SJgoEaW5m",
			"bxgBIAEoCzIYLkNoZXNzUm9ndWVRdWVyeUFlb25JbmZvQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChessRogueQueryAeonInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueQueryAeonDimensionsScRsp), ChessRogueQueryAeonDimensionsScRsp.Parser, new string[]
			{
				"Retcode",
				"Info"
			}, null, null, null, null)
		}));
	}
}
