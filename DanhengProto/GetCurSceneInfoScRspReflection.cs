using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200067C RID: 1660
	public static class GetCurSceneInfoScRspReflection
	{
		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06004A63 RID: 19043 RVA: 0x000CA686 File Offset: 0x000C8886
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetCurSceneInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001D84 RID: 7556
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRDdXJTY2VuZUluZm9TY1JzcC5wcm90bxoPU2NlbmVJbmZvLnByb3Rv" + "IkIKFEdldEN1clNjZW5lSW5mb1NjUnNwEhkKBXNjZW5lGAYgASgLMgouU2Nl" + "bmVJbmZvEg8KB3JldGNvZGUYAiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl" + "cnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetCurSceneInfoScRsp), GetCurSceneInfoScRsp.Parser, new string[]
			{
				"Scene",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
