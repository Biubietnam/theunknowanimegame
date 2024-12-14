using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000048 RID: 72
	public static class AddRelicFilterPlanScRspReflection
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002DF RID: 735 RVA: 0x000090B9 File Offset: 0x000072B9
		public static FileDescriptor Descriptor
		{
			get
			{
				return AddRelicFilterPlanScRspReflection.descriptor;
			}
		}

		// Token: 0x04000108 RID: 264
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1BZGRSZWxpY0ZpbHRlclBsYW5TY1JzcC5wcm90bxoVUmVsaWNGaWx0ZXJQ" + "bGFuLnByb3RvIkoKF0FkZFJlbGljRmlsdGVyUGxhblNjUnNwEh4KBFBsYW4Y" + "CyABKAsyEC5SZWxpY0ZpbHRlclBsYW4SDwoHcmV0Y29kZRgGIAEoDUIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			RelicFilterPlanReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AddRelicFilterPlanScRsp), AddRelicFilterPlanScRsp.Parser, new string[]
			{
				"Plan",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
