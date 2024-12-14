using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000296 RID: 662
	public static class ChessRogueSelectCellCsReqReflection
	{
		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x000549AE File Offset: 0x00052BAE
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueSelectCellCsReqReflection.descriptor;
			}
		}

		// Token: 0x04000C51 RID: 3153
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DaGVzc1JvZ3VlU2VsZWN0Q2VsbENzUmVxLnByb3RvIkcKGUNoZXNzUm9n" + "dWVTZWxlY3RDZWxsQ3NSZXESDwoHY2VsbF9pZBgKIAEoDRIZChFzZWxlY3Rf" + "bW9uc3Rlcl9pZBgOIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueSelectCellCsReq), ChessRogueSelectCellCsReq.Parser, new string[]
			{
				"CellId",
				"SelectMonsterId"
			}, null, null, null, null)
		}));
	}
}
