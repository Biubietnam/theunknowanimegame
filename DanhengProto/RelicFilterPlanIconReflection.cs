using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DA6 RID: 3494
	public static class RelicFilterPlanIconReflection
	{
		// Token: 0x17002C12 RID: 11282
		// (get) Token: 0x06009C32 RID: 39986 RVA: 0x0019FCC6 File Offset: 0x0019DEC6
		public static FileDescriptor Descriptor
		{
			get
			{
				return RelicFilterPlanIconReflection.descriptor;
			}
		}

		// Token: 0x04003CA3 RID: 15523
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlSZWxpY0ZpbHRlclBsYW5JY29uLnByb3RvIjsKE1JlbGljRmlsdGVyUGxh" + "bkljb24SFAoMSXNBdmF0YXJJY29uGAsgASgIEg4KBkljb25JZBgEIAEoDUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RelicFilterPlanIcon), RelicFilterPlanIcon.Parser, new string[]
			{
				"IsAvatarIcon",
				"IconId"
			}, null, null, null, null)
		}));
	}
}
