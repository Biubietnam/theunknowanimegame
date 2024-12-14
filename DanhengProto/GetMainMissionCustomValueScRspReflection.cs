using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200070A RID: 1802
	public static class GetMainMissionCustomValueScRspReflection
	{
		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x06005090 RID: 20624 RVA: 0x000D915C File Offset: 0x000D735C
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetMainMissionCustomValueScRspReflection.descriptor;
			}
		}

		// Token: 0x04001FAD RID: 8109
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiRHZXRNYWluTWlzc2lvbkN1c3RvbVZhbHVlU2NSc3AucHJvdG8aEU1haW5N",
			"aXNzaW9uLnByb3RvIloKHkdldE1haW5NaXNzaW9uQ3VzdG9tVmFsdWVTY1Jz",
			"cBIPCgdyZXRjb2RlGAQgASgNEicKEW1haW5fbWlzc2lvbl9saXN0GAIgAygL",
			"MgwuTWFpbk1pc3Npb25CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			MainMissionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetMainMissionCustomValueScRsp), GetMainMissionCustomValueScRsp.Parser, new string[]
			{
				"Retcode",
				"MainMissionList"
			}, null, null, null, null)
		}));
	}
}
