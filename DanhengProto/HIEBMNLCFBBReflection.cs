using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008EC RID: 2284
	public static class HIEBMNLCFBBReflection
	{
		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x060065E7 RID: 26087 RVA: 0x0011065A File Offset: 0x0010E85A
		public static FileDescriptor Descriptor
		{
			get
			{
				return HIEBMNLCFBBReflection.descriptor;
			}
		}

		// Token: 0x0400272F RID: 10031
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISUVCTU5MQ0ZCQi5wcm90bxoWR2FtZVJvZ3VlTWlyYWNsZS5wcm90byI2" + "CgtISUVCTU5MQ0ZCQhInCgxtaXJhY2xlX2luZm8YByABKAsyES5HYW1lUm9n" + "dWVNaXJhY2xlQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[]
		{
			GameRogueMiracleReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HIEBMNLCFBB), HIEBMNLCFBB.Parser, new string[]
			{
				"MiracleInfo"
			}, null, null, null, null)
		}));
	}
}
