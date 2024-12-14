using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200089A RID: 2202
	public static class HealPoolInfoNotifyReflection
	{
		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06006252 RID: 25170 RVA: 0x00107299 File Offset: 0x00105499
		public static FileDescriptor Descriptor
		{
			get
			{
				return HealPoolInfoNotifyReflection.descriptor;
			}
		}

		// Token: 0x040025CB RID: 9675
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhIZWFsUG9vbEluZm9Ob3RpZnkucHJvdG8aEkhlYWxQb29sSW5mby5wcm90" + "byI7ChJIZWFsUG9vbEluZm9Ob3RpZnkSJQoOaGVhbF9wb29sX2luZm8YDCAB" + "KAsyDS5IZWFsUG9vbEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			HealPoolInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HealPoolInfoNotify), HealPoolInfoNotify.Parser, new string[]
			{
				"HealPoolInfo"
			}, null, null, null, null)
		}));
	}
}
