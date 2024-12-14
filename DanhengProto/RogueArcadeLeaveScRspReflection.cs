using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DFC RID: 3580
	public static class RogueArcadeLeaveScRspReflection
	{
		// Token: 0x17002D37 RID: 11575
		// (get) Token: 0x0600A01E RID: 40990 RVA: 0x001ADBAA File Offset: 0x001ABDAA
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueArcadeLeaveScRspReflection.descriptor;
			}
		}

		// Token: 0x040041A0 RID: 16800
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtSb2d1ZUFyY2FkZUxlYXZlU2NSc3AucHJvdG8aEUlLRU5BQUpEQUZGLnBy" + "b3RvIloKFVJvZ3VlQXJjYWRlTGVhdmVTY1JzcBIPCgdyZXRjb2RlGAwgASgN" + "EjAKGnJvZ3VlX3RvdXJuX2N1cl9zY2VuZV9pbmZvGAIgASgLMgwuSUtFTkFB" + "SkRBRkZCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			IKENAAJDAFFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueArcadeLeaveScRsp), RogueArcadeLeaveScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueTournCurSceneInfo"
			}, null, null, null, null)
		}));
	}
}
