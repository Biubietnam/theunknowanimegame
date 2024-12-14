using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001298 RID: 4760
	public static class SyncRogueReviveInfoScNotifyReflection
	{
		// Token: 0x17003BC0 RID: 15296
		// (get) Token: 0x0600D462 RID: 54370 RVA: 0x002371D4 File Offset: 0x002353D4
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncRogueReviveInfoScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040054FF RID: 21759
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTeW5jUm9ndWVSZXZpdmVJbmZvU2NOb3RpZnkucHJvdG8aFVJvZ3VlUmV2" + "aXZlSW5mby5wcm90byJEChtTeW5jUm9ndWVSZXZpdmVJbmZvU2NOb3RpZnkS" + "JQoLcmV2aXZlX2luZm8YASABKAsyEC5Sb2d1ZVJldml2ZUluZm9CHqoCG0Vn" + "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			RogueReviveInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueReviveInfoScNotify), SyncRogueReviveInfoScNotify.Parser, new string[]
			{
				"ReviveInfo"
			}, null, null, null, null)
		}));
	}
}
