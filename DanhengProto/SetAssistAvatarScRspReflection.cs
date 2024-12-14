using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010CA RID: 4298
	public static class SetAssistAvatarScRspReflection
	{
		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x0600BFAF RID: 49071 RVA: 0x0020409F File Offset: 0x0020229F
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetAssistAvatarScRspReflection.descriptor;
			}
		}

		// Token: 0x04004DCB RID: 19915
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXRBc3Npc3RBdmF0YXJTY1JzcC5wcm90byJSChRTZXRBc3Npc3RBdmF0" + "YXJTY1JzcBIPCgdyZXRjb2RlGAIgASgNEhEKCWF2YXRhcl9pZBgHIAEoDRIW" + "Cg5hdmF0YXJfaWRfbGlzdBgNIAMoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetAssistAvatarScRsp), SetAssistAvatarScRsp.Parser, new string[]
			{
				"Retcode",
				"AvatarId",
				"AvatarIdList"
			}, null, null, null, null)
		}));
	}
}
