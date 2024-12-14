using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200058E RID: 1422
	public static class FinishQuestCsReqReflection
	{
		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x06003F7F RID: 16255 RVA: 0x000AD3CD File Offset: 0x000AB5CD
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishQuestCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001945 RID: 6469
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZGaW5pc2hRdWVzdENzUmVxLnByb3RvIkcKEEZpbmlzaFF1ZXN0Q3NSZXES" + "EAoIZ3JvdXBfaWQYAyABKA0SDwoHcHJvcF9pZBgNIAEoDRIQCghxdWVzdF9p" + "ZBgJIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishQuestCsReq), FinishQuestCsReq.Parser, new string[]
			{
				"GroupId",
				"PropId",
				"QuestId"
			}, null, null, null, null)
		}));
	}
}
