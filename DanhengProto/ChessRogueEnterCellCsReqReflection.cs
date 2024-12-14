using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200020C RID: 524
	public static class ChessRogueEnterCellCsReqReflection
	{
		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x00043219 File Offset: 0x00041419
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueEnterCellCsReqReflection.descriptor;
			}
		}

		// Token: 0x040009EB RID: 2539
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5DaGVzc1JvZ3VlRW50ZXJDZWxsQ3NSZXEucHJvdG8iRgoYQ2hlc3NSb2d1" + "ZUVudGVyQ2VsbENzUmVxEhkKEXNlbGVjdF9tb25zdGVyX2lkGAEgASgNEg8K" + "B2NlbGxfaWQYDCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueEnterCellCsReq), ChessRogueEnterCellCsReq.Parser, new string[]
			{
				"SelectMonsterId",
				"CellId"
			}, null, null, null, null)
		}));
	}
}
