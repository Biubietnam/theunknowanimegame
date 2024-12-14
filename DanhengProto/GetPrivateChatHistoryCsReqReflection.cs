using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000774 RID: 1908
	public static class GetPrivateChatHistoryCsReqReflection
	{
		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06005543 RID: 21827 RVA: 0x000E5025 File Offset: 0x000E3225
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetPrivateChatHistoryCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400216C RID: 8556
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHZXRQcml2YXRlQ2hhdEhpc3RvcnlDc1JlcS5wcm90byJEChpHZXRQcml2" + "YXRlQ2hhdEhpc3RvcnlDc1JlcRISCgpjb250YWN0X2lkGAsgASgNEhIKCnRh" + "cmdldF91aWQYAyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetPrivateChatHistoryCsReq), GetPrivateChatHistoryCsReq.Parser, new string[]
			{
				"ContactId",
				"TargetUid"
			}, null, null, null, null)
		}));
	}
}
