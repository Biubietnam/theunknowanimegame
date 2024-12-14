using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001358 RID: 4952
	public static class TextJoinSaveCsReqReflection
	{
		// Token: 0x17003E15 RID: 15893
		// (get) Token: 0x0600DD0B RID: 56587 RVA: 0x0024C74B File Offset: 0x0024A94B
		public static FileDescriptor Descriptor
		{
			get
			{
				return TextJoinSaveCsReqReflection.descriptor;
			}
		}

		// Token: 0x040057EA RID: 22506
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdUZXh0Sm9pblNhdmVDc1JlcS5wcm90byJbChFUZXh0Sm9pblNhdmVDc1Jl" + "cRIbChN0ZXh0X2l0ZW1fY29uZmlnX2lkGAIgASgNEhMKC0FJTkFPRU5NT01F" + "GAYgASgJEhQKDHRleHRfaXRlbV9pZBgMIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TextJoinSaveCsReq), TextJoinSaveCsReq.Parser, new string[]
			{
				"TextItemConfigId",
				"AINAOENMOME",
				"TextItemId"
			}, null, null, null, null)
		}));
	}
}
