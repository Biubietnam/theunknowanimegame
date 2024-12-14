using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200107E RID: 4222
	public static class SceneMonsterWaveParamReflection
	{
		// Token: 0x17003529 RID: 13609
		// (get) Token: 0x0600BC35 RID: 48181 RVA: 0x001FB336 File Offset: 0x001F9536
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneMonsterWaveParamReflection.descriptor;
			}
		}

		// Token: 0x04004C8B RID: 19595
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTY2VuZU1vbnN0ZXJXYXZlUGFyYW0ucHJvdG8iagoVU2NlbmVNb25zdGVy" + "V2F2ZVBhcmFtEhMKC0lJQkVPRU5LTkNOGAEgASgNEg0KBWxldmVsGAsgASgN" + "EhMKC2VsaXRlX2dyb3VwGA0gASgNEhgKEGhhcmRfbGV2ZWxfZ3JvdXAYCiAB" + "KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneMonsterWaveParam), SceneMonsterWaveParam.Parser, new string[]
			{
				"IIBEOENKNCN",
				"Level",
				"EliteGroup",
				"HardLevelGroup"
			}, null, null, null, null)
		}));
	}
}
