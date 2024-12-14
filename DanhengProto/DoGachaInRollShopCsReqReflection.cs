using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003C2 RID: 962
	public static class DoGachaInRollShopCsReqReflection
	{
		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x000773C5 File Offset: 0x000755C5
		public static FileDescriptor Descriptor
		{
			get
			{
				return DoGachaInRollShopCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400115C RID: 4444
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxEb0dhY2hhSW5Sb2xsU2hvcENzUmVxLnByb3RvIlkKFkRvR2FjaGFJblJv" + "bGxTaG9wQ3NSZXESEwoLZ2FjaGFfY291bnQYCiABKA0SFAoMcm9sbF9zaG9w" + "X2lkGAsgASgNEhQKDGdhY2hhX3JhbmRvbRgCIAEoDUIeqgIbRWdnTGluay5E" + "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DoGachaInRollShopCsReq), DoGachaInRollShopCsReq.Parser, new string[]
			{
				"GachaCount",
				"RollShopId",
				"GachaRandom"
			}, null, null, null, null)
		}));
	}
}
