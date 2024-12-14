using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000242 RID: 578
	public static class ChessRogueMiracleReflection
	{
		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x0004BCEA File Offset: 0x00049EEA
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueMiracleReflection.descriptor;
			}
		}

		// Token: 0x04000B1A RID: 2842
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdDaGVzc1JvZ3VlTWlyYWNsZS5wcm90bxoWR2FtZVJvZ3VlTWlyYWNsZS5w" + "cm90byI8ChFDaGVzc1JvZ3VlTWlyYWNsZRInCgxtaXJhY2xlX2xpc3QYCSAD" + "KAsyES5HYW1lUm9ndWVNaXJhY2xlQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			GameRogueMiracleReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueMiracle), ChessRogueMiracle.Parser, new string[]
			{
				"MiracleList"
			}, null, null, null, null)
		}));
	}
}
