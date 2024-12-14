using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000796 RID: 1942
	public static class GetRelicFilterPlanScRspReflection
	{
		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x060056BC RID: 22204 RVA: 0x000E8752 File Offset: 0x000E6952
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetRelicFilterPlanScRspReflection.descriptor;
			}
		}

		// Token: 0x040021ED RID: 8685
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1HZXRSZWxpY0ZpbHRlclBsYW5TY1JzcC5wcm90bxoVUmVsaWNGaWx0ZXJQ",
			"bGFuLnByb3RvIlkKF0dldFJlbGljRmlsdGVyUGxhblNjUnNwEi0KE1JlbGlj",
			"RmlsdGVyUGxhbkxpc3QYDiADKAsyEC5SZWxpY0ZpbHRlclBsYW4SDwoHcmV0",
			"Y29kZRgJIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			RelicFilterPlanReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetRelicFilterPlanScRsp), GetRelicFilterPlanScRsp.Parser, new string[]
			{
				"RelicFilterPlanList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
