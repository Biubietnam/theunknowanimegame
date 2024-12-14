using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012E2 RID: 4834
	public static class TakeMailAttachmentCsReqReflection
	{
		// Token: 0x17003CA5 RID: 15525
		// (get) Token: 0x0600D7BC RID: 55228 RVA: 0x0023F5A4 File Offset: 0x0023D7A4
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeMailAttachmentCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005617 RID: 22039
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1UYWtlTWFpbEF0dGFjaG1lbnRDc1JlcS5wcm90byJQChdUYWtlTWFpbEF0" + "dGFjaG1lbnRDc1JlcRIaChJvcHRpb25hbF9yZXdhcmRfaWQYCiABKA0SGQoR" + "dGFrZV9tYWlsX2lkX2xpc3QYBiADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl" + "cnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeMailAttachmentCsReq), TakeMailAttachmentCsReq.Parser, new string[]
			{
				"OptionalRewardId",
				"TakeMailIdList"
			}, null, null, null, null)
		}));
	}
}
