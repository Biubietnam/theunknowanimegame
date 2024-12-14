using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CA7 RID: 3239
	public enum PlatformType
	{
		// Token: 0x04003749 RID: 14153
		[OriginalName("EDITOR")]
		Editor,
		// Token: 0x0400374A RID: 14154
		[OriginalName("IOS")]
		Ios,
		// Token: 0x0400374B RID: 14155
		[OriginalName("ANDROID")]
		Android,
		// Token: 0x0400374C RID: 14156
		[OriginalName("PC")]
		Pc,
		// Token: 0x0400374D RID: 14157
		[OriginalName("WEB")]
		Web,
		// Token: 0x0400374E RID: 14158
		[OriginalName("WAP")]
		Wap,
		// Token: 0x0400374F RID: 14159
		[OriginalName("PS4")]
		Ps4,
		// Token: 0x04003750 RID: 14160
		[OriginalName("NINTENDO")]
		Nintendo,
		// Token: 0x04003751 RID: 14161
		[OriginalName("CLOUD_ANDROID")]
		CloudAndroid,
		// Token: 0x04003752 RID: 14162
		[OriginalName("CLOUD_PC")]
		CloudPc,
		// Token: 0x04003753 RID: 14163
		[OriginalName("CLOUD_IOS")]
		CloudIos,
		// Token: 0x04003754 RID: 14164
		[OriginalName("PS5")]
		Ps5,
		// Token: 0x04003755 RID: 14165
		[OriginalName("MAC")]
		Mac,
		// Token: 0x04003756 RID: 14166
		[OriginalName("CLOUD_MAC")]
		CloudMac,
		// Token: 0x04003757 RID: 14167
		[OriginalName("CLOUD_WEB_ANDROID")]
		CloudWebAndroid = 20,
		// Token: 0x04003758 RID: 14168
		[OriginalName("CLOUD_WEB_IOS")]
		CloudWebIos,
		// Token: 0x04003759 RID: 14169
		[OriginalName("CLOUD_WEB_PC")]
		CloudWebPc,
		// Token: 0x0400375A RID: 14170
		[OriginalName("CLOUD_WEB_MAC")]
		CloudWebMac,
		// Token: 0x0400375B RID: 14171
		[OriginalName("CLOUD_WEB_TOUCH")]
		CloudWebTouch,
		// Token: 0x0400375C RID: 14172
		[OriginalName("CLOUD_WEB_KEYBOARD")]
		CloudWebKeyboard
	}
}
