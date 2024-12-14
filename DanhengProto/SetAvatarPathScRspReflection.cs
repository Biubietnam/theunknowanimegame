using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010D2 RID: 4306
	public static class SetAvatarPathScRspReflection
	{
		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x0600C00C RID: 49164 RVA: 0x00204E41 File Offset: 0x00203041
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetAvatarPathScRspReflection.descriptor;
			}
		}

		// Token: 0x04004DEA RID: 19946
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTZXRBdmF0YXJQYXRoU2NSc3AucHJvdG8aGU11bHRpUGF0aEF2YXRhclR5" + "cGUucHJvdG8iTgoSU2V0QXZhdGFyUGF0aFNjUnNwEg8KB3JldGNvZGUYAiAB" + "KA0SJwoJYXZhdGFyX2lkGA8gASgOMhQuTXVsdGlQYXRoQXZhdGFyVHlwZUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			MultiPathAvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetAvatarPathScRsp), SetAvatarPathScRsp.Parser, new string[]
			{
				"Retcode",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
