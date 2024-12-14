using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004F2 RID: 1266
	public static class ExtraLineupDestroyNotifyReflection
	{
		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x060038B1 RID: 14513 RVA: 0x0009B6A4 File Offset: 0x000998A4
		public static FileDescriptor Descriptor
		{
			get
			{
				return ExtraLineupDestroyNotifyReflection.descriptor;
			}
		}

		// Token: 0x0400166F RID: 5743
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5FeHRyYUxpbmV1cERlc3Ryb3lOb3RpZnkucHJvdG8aFUV4dHJhTGluZXVw" + "VHlwZS5wcm90byJHChhFeHRyYUxpbmV1cERlc3Ryb3lOb3RpZnkSKwoRZXh0" + "cmFfbGluZXVwX3R5cGUYASABKA4yEC5FeHRyYUxpbmV1cFR5cGVCHqoCG0Vn" + "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ExtraLineupTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ExtraLineupDestroyNotify), ExtraLineupDestroyNotify.Parser, new string[]
			{
				"ExtraLineupType"
			}, null, null, null, null)
		}));
	}
}
