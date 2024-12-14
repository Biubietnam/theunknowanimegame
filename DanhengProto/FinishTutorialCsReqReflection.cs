using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200059E RID: 1438
	public static class FinishTutorialCsReqReflection
	{
		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06004039 RID: 16441 RVA: 0x000AEFD7 File Offset: 0x000AD1D7
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishTutorialCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001983 RID: 6531
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlGaW5pc2hUdXRvcmlhbENzUmVxLnByb3RvIioKE0ZpbmlzaFR1dG9yaWFs" + "Q3NSZXESEwoLdHV0b3JpYWxfaWQYBSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu" + "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishTutorialCsReq), FinishTutorialCsReq.Parser, new string[]
			{
				"TutorialId"
			}, null, null, null, null)
		}));
	}
}
