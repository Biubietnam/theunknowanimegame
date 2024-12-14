using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001EA RID: 490
	public static class ChessRogueBuffInfoReflection
	{
		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x0003EF00 File Offset: 0x0003D100
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueBuffInfoReflection.descriptor;
			}
		}

		// Token: 0x0400093E RID: 2366
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDaGVzc1JvZ3VlQnVmZkluZm8ucHJvdG8aFENoZXNzUm9ndWVCdWZmLnBy" + "b3RvIkQKEkNoZXNzUm9ndWVCdWZmSW5mbxIuChVjaGVzc19yb2d1ZV9idWZm" + "X2luZm8YBSABKAsyDy5DaGVzc1JvZ3VlQnVmZkIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ChessRogueBuffReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueBuffInfo), ChessRogueBuffInfo.Parser, new string[]
			{
				"ChessRogueBuffInfo_"
			}, null, null, null, null)
		}));
	}
}
