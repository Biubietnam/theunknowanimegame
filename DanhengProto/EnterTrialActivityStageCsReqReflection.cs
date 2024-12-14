using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200047E RID: 1150
	public static class EnterTrialActivityStageCsReqReflection
	{
		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06003343 RID: 13123 RVA: 0x0008CF5C File Offset: 0x0008B15C
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterTrialActivityStageCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001464 RID: 5220
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJFbnRlclRyaWFsQWN0aXZpdHlTdGFnZUNzUmVxLnByb3RvIjAKHEVudGVy" + "VHJpYWxBY3Rpdml0eVN0YWdlQ3NSZXESEAoIc3RhZ2VfaWQYByABKA1CHqoC" + "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterTrialActivityStageCsReq), EnterTrialActivityStageCsReq.Parser, new string[]
			{
				"StageId"
			}, null, null, null, null)
		}));
	}
}
