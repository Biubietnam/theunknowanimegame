using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011F8 RID: 4600
	public static class SubmitEmotionItemScRspReflection
	{
		// Token: 0x17003A03 RID: 14851
		// (get) Token: 0x0600CDA4 RID: 52644 RVA: 0x00227EFB File Offset: 0x002260FB
		public static FileDescriptor Descriptor
		{
			get
			{
				return SubmitEmotionItemScRspReflection.descriptor;
			}
		}

		// Token: 0x040052EB RID: 21227
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTdWJtaXRFbW90aW9uSXRlbVNjUnNwLnByb3RvIjwKFlN1Ym1pdEVtb3Rp" + "b25JdGVtU2NSc3ASEQoJc2NyaXB0X2lkGAcgASgNEg8KB3JldGNvZGUYDyAB" + "KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SubmitEmotionItemScRsp), SubmitEmotionItemScRsp.Parser, new string[]
			{
				"ScriptId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
