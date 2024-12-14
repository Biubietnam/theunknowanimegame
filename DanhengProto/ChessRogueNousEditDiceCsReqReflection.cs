using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000250 RID: 592
	public static class ChessRogueNousEditDiceCsReqReflection
	{
		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x0004D031 File Offset: 0x0004B231
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousEditDiceCsReqReflection.descriptor;
			}
		}

		// Token: 0x04000B47 RID: 2887
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDaGVzc1JvZ3VlTm91c0VkaXREaWNlQ3NSZXEucHJvdG8aFENoZXNzUm9n" + "dWVEaWNlLnByb3RvIkcKG0NoZXNzUm9ndWVOb3VzRWRpdERpY2VDc1JlcRIo" + "Cg9xdWVyeV9kaWNlX2luZm8YDiABKAsyDy5DaGVzc1JvZ3VlRGljZUIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ChessRogueDiceReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueNousEditDiceCsReq), ChessRogueNousEditDiceCsReq.Parser, new string[]
			{
				"QueryDiceInfo"
			}, null, null, null, null)
		}));
	}
}
