using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001AA RID: 426
	public static class ChallengeLineupNotifyReflection
	{
		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x00037730 File Offset: 0x00035930
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeLineupNotifyReflection.descriptor;
			}
		}

		// Token: 0x0400081A RID: 2074
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDaGFsbGVuZ2VMaW5ldXBOb3RpZnkucHJvdG8aFUV4dHJhTGluZXVwVHlw" + "ZS5wcm90byJEChVDaGFsbGVuZ2VMaW5ldXBOb3RpZnkSKwoRZXh0cmFfbGlu" + "ZXVwX3R5cGUYCSABKA4yEC5FeHRyYUxpbmV1cFR5cGVCHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ExtraLineupTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeLineupNotify), ChallengeLineupNotify.Parser, new string[]
			{
				"ExtraLineupType"
			}, null, null, null, null)
		}));
	}
}
