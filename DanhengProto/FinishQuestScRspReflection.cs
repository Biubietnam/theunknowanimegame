using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000590 RID: 1424
	public static class FinishQuestScRspReflection
	{
		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x06003F98 RID: 16280 RVA: 0x000AD7BC File Offset: 0x000AB9BC
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishQuestScRspReflection.descriptor;
			}
		}

		// Token: 0x0400194E RID: 6478
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZGaW5pc2hRdWVzdFNjUnNwLnByb3RvIiMKEEZpbmlzaFF1ZXN0U2NSc3AS" + "DwoHcmV0Y29kZRgEIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishQuestScRsp), FinishQuestScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
