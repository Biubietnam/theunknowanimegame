using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000244 RID: 580
	public static class ChessRogueMiracleInfoReflection
	{
		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x0004BF68 File Offset: 0x0004A168
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueMiracleInfoReflection.descriptor;
			}
		}

		// Token: 0x04000B20 RID: 2848
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDaGVzc1JvZ3VlTWlyYWNsZUluZm8ucHJvdG8aF0NoZXNzUm9ndWVNaXJh" + "Y2xlLnByb3RvIk0KFUNoZXNzUm9ndWVNaXJhY2xlSW5mbxI0ChhjaGVzc19y" + "b2d1ZV9taXJhY2xlX2luZm8YDCABKAsyEi5DaGVzc1JvZ3VlTWlyYWNsZUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ChessRogueMiracleReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueMiracleInfo), ChessRogueMiracleInfo.Parser, new string[]
			{
				"ChessRogueMiracleInfo_"
			}, null, null, null, null)
		}));
	}
}
