using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000332 RID: 818
	public static class ContentPackageUnlockCsReqReflection
	{
		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x0600249A RID: 9370 RVA: 0x00067836 File Offset: 0x00065A36
		public static FileDescriptor Descriptor
		{
			get
			{
				return ContentPackageUnlockCsReqReflection.descriptor;
			}
		}

		// Token: 0x04000EF3 RID: 3827
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db250ZW50UGFja2FnZVVubG9ja0NzUmVxLnByb3RvIi8KGUNvbnRlbnRQ" + "YWNrYWdlVW5sb2NrQ3NSZXESEgoKY29udGVudF9pZBgPIAEoDUIeqgIbRWdn" + "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ContentPackageUnlockCsReq), ContentPackageUnlockCsReq.Parser, new string[]
			{
				"ContentId"
			}, null, null, null, null)
		}));
	}
}
