using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000C2 RID: 194
	public static class AvatarPathChangedNotifyReflection
	{
		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0001A07B File Offset: 0x0001827B
		public static FileDescriptor Descriptor
		{
			get
			{
				return AvatarPathChangedNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000393 RID: 915
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1BdmF0YXJQYXRoQ2hhbmdlZE5vdGlmeS5wcm90bxoZTXVsdGlQYXRoQXZh",
			"dGFyVHlwZS5wcm90byJrChdBdmF0YXJQYXRoQ2hhbmdlZE5vdGlmeRIWCg5i",
			"YXNlX2F2YXRhcl9pZBgNIAEoDRI4ChpjdXJfbXVsdGlfcGF0aF9hdmF0YXJf",
			"dHlwZRgEIAEoDjIULk11bHRpUGF0aEF2YXRhclR5cGVCHqoCG0VnZ0xpbmsu",
			"RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			MultiPathAvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AvatarPathChangedNotify), AvatarPathChangedNotify.Parser, new string[]
			{
				"BaseAvatarId",
				"CurMultiPathAvatarType"
			}, null, null, null, null)
		}));
	}
}
