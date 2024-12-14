using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010CE RID: 4302
	public static class SetAssistScRspReflection
	{
		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x0600BFDE RID: 49118 RVA: 0x002047D9 File Offset: 0x002029D9
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetAssistScRspReflection.descriptor;
			}
		}

		// Token: 0x04004DDC RID: 19932
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRTZXRBc3Npc3RTY1JzcC5wcm90byJBCg5TZXRBc3Npc3RTY1JzcBIPCgdy" + "ZXRjb2RlGAkgASgNEhEKCWF2YXRhcl9pZBgCIAEoDRILCgN1aWQYCiABKA1C" + "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetAssistScRsp), SetAssistScRsp.Parser, new string[]
			{
				"Retcode",
				"AvatarId",
				"Uid"
			}, null, null, null, null)
		}));
	}
}
