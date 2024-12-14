using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EC0 RID: 3776
	public static class RogueMagicEnableTalentScRspReflection
	{
		// Token: 0x17002FAD RID: 12205
		// (get) Token: 0x0600A8CA RID: 43210 RVA: 0x001C6B2E File Offset: 0x001C4D2E
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicEnableTalentScRspReflection.descriptor;
			}
		}

		// Token: 0x040044F6 RID: 17654
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFSb2d1ZU1hZ2ljRW5hYmxlVGFsZW50U2NSc3AucHJvdG8aGlJvZ3VlTWFn",
			"aWNUYWxlbnRJbmZvLnByb3RvImYKG1JvZ3VlTWFnaWNFbmFibGVUYWxlbnRT",
			"Y1JzcBIPCgdyZXRjb2RlGAQgASgNEjYKF3JvZ3VlX21hZ2ljX3RhbGVudF9p",
			"bmZvGAwgASgLMhUuUm9ndWVNYWdpY1RhbGVudEluZm9CHqoCG0VnZ0xpbmsu",
			"RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueMagicTalentInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicEnableTalentScRsp), RogueMagicEnableTalentScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueMagicTalentInfo"
			}, null, null, null, null)
		}));
	}
}
