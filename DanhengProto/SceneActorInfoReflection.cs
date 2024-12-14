using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200104C RID: 4172
	public static class SceneActorInfoReflection
	{
		// Token: 0x1700344C RID: 13388
		// (get) Token: 0x0600B9A0 RID: 47520 RVA: 0x001F235D File Offset: 0x001F055D
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneActorInfoReflection.descriptor;
			}
		}

		// Token: 0x04004B28 RID: 19240
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChRTY2VuZUFjdG9ySW5mby5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJqCg5T",
			"Y2VuZUFjdG9ySW5mbxIgCgthdmF0YXJfdHlwZRgNIAEoDjILLkF2YXRhclR5",
			"cGUSFgoOYmFzZV9hdmF0YXJfaWQYCiABKA0SEQoJbWFwX2xheWVyGAYgASgN",
			"EgsKA3VpZBgJIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneActorInfo), SceneActorInfo.Parser, new string[]
			{
				"AvatarType",
				"BaseAvatarId",
				"MapLayer",
				"Uid"
			}, null, null, null, null)
		}));
	}
}
