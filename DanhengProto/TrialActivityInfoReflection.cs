using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013A2 RID: 5026
	public static class TrialActivityInfoReflection
	{
		// Token: 0x17003F0B RID: 16139
		// (get) Token: 0x0600E060 RID: 57440 RVA: 0x00255995 File Offset: 0x00253B95
		public static FileDescriptor Descriptor
		{
			get
			{
				return TrialActivityInfoReflection.descriptor;
			}
		}

		// Token: 0x0400595D RID: 22877
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdUcmlhbEFjdGl2aXR5SW5mby5wcm90byI7ChFUcmlhbEFjdGl2aXR5SW5m" + "bxIUCgx0YWtlbl9yZXdhcmQYDSABKAgSEAoIc3RhZ2VfaWQYCyABKA1CHqoC" + "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TrialActivityInfo), TrialActivityInfo.Parser, new string[]
			{
				"TakenReward",
				"StageId"
			}, null, null, null, null)
		}));
	}
}
