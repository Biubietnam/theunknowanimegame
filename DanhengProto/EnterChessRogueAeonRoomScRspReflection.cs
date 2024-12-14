using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200043C RID: 1084
	public static class EnterChessRogueAeonRoomScRspReflection
	{
		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x0008451E File Offset: 0x0008271E
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterChessRogueAeonRoomScRspReflection.descriptor;
			}
		}

		// Token: 0x0400132B RID: 4907
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJFbnRlckNoZXNzUm9ndWVBZW9uUm9vbVNjUnNwLnByb3RvGhRDaGVzc1Jv",
			"Z3VlSW5mby5wcm90byJUChxFbnRlckNoZXNzUm9ndWVBZW9uUm9vbVNjUnNw",
			"EiMKCnN0YWdlX2luZm8YDyABKAsyDy5DaGVzc1JvZ3VlSW5mbxIPCgdyZXRj",
			"b2RlGAYgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			ChessRogueInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterChessRogueAeonRoomScRsp), EnterChessRogueAeonRoomScRsp.Parser, new string[]
			{
				"StageInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
