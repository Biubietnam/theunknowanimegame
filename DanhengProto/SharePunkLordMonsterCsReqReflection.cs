using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001146 RID: 4422
	public static class SharePunkLordMonsterCsReqReflection
	{
		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x0600C545 RID: 50501 RVA: 0x00211575 File Offset: 0x0020F775
		public static FileDescriptor Descriptor
		{
			get
			{
				return SharePunkLordMonsterCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004FA9 RID: 20393
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9TaGFyZVB1bmtMb3JkTW9uc3RlckNzUmVxLnByb3RvGhdQdW5rTG9yZFNo",
			"YXJlVHlwZS5wcm90byJkChlTaGFyZVB1bmtMb3JkTW9uc3RlckNzUmVxEhIK",
			"Cm1vbnN0ZXJfaWQYCiABKA0SCwoDdWlkGAQgASgNEiYKCnNoYXJlX3R5cGUY",
			"DiABKA4yEi5QdW5rTG9yZFNoYXJlVHlwZUIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			PunkLordShareTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SharePunkLordMonsterCsReq), SharePunkLordMonsterCsReq.Parser, new string[]
			{
				"MonsterId",
				"Uid",
				"ShareType"
			}, null, null, null, null)
		}));
	}
}
