using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005CC RID: 1484
	public static class GachaCeilingReflection
	{
		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x0600423C RID: 16956 RVA: 0x000B44E8 File Offset: 0x000B26E8
		public static FileDescriptor Descriptor
		{
			get
			{
				return GachaCeilingReflection.descriptor;
			}
		}

		// Token: 0x04001A4B RID: 6731
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJHYWNoYUNlaWxpbmcucHJvdG8aGEdhY2hhQ2VpbGluZ0F2YXRhci5wcm90",
			"byJhCgxHYWNoYUNlaWxpbmcSEgoKaXNfY2xhaW1lZBgGIAEoCBITCgtjZWls",
			"aW5nX251bRgBIAEoDRIoCgthdmF0YXJfbGlzdBgPIAMoCzITLkdhY2hhQ2Vp",
			"bGluZ0F2YXRhckIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			GachaCeilingAvatarReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GachaCeiling), GachaCeiling.Parser, new string[]
			{
				"IsClaimed",
				"CeilingNum",
				"AvatarList"
			}, null, null, null, null)
		}));
	}
}
