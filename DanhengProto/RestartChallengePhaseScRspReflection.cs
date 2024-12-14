using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DCE RID: 3534
	public static class RestartChallengePhaseScRspReflection
	{
		// Token: 0x17002C9D RID: 11421
		// (get) Token: 0x06009E0A RID: 40458 RVA: 0x001A4EA6 File Offset: 0x001A30A6
		public static FileDescriptor Descriptor
		{
			get
			{
				return RestartChallengePhaseScRspReflection.descriptor;
			}
		}

		// Token: 0x04003D6B RID: 15723
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXN0YXJ0Q2hhbGxlbmdlUGhhc2VTY1JzcC5wcm90bxoPU2NlbmVJbmZv" + "LnByb3RvIkgKGlJlc3RhcnRDaGFsbGVuZ2VQaGFzZVNjUnNwEhkKBXNjZW5l" + "GAYgASgLMgouU2NlbmVJbmZvEg8KB3JldGNvZGUYASABKA1CHqoCG0VnZ0xp" + "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RestartChallengePhaseScRsp), RestartChallengePhaseScRsp.Parser, new string[]
			{
				"Scene",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
