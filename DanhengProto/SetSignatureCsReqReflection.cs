using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200112E RID: 4398
	public static class SetSignatureCsReqReflection
	{
		// Token: 0x17003753 RID: 14163
		// (get) Token: 0x0600C42B RID: 50219 RVA: 0x0020EA34 File Offset: 0x0020CC34
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetSignatureCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004F4B RID: 20299
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdTZXRTaWduYXR1cmVDc1JlcS5wcm90byImChFTZXRTaWduYXR1cmVDc1Jl" + "cRIRCglzaWduYXR1cmUYBSABKAlCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl" + "ci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetSignatureCsReq), SetSignatureCsReq.Parser, new string[]
			{
				"Signature"
			}, null, null, null, null)
		}));
	}
}
