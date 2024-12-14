using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001094 RID: 4244
	public static class SecretKeyInfoReflection
	{
		// Token: 0x17003579 RID: 13689
		// (get) Token: 0x0600BD49 RID: 48457 RVA: 0x001FE2EA File Offset: 0x001FC4EA
		public static FileDescriptor Descriptor
		{
			get
			{
				return SecretKeyInfoReflection.descriptor;
			}
		}

		// Token: 0x04004CF9 RID: 19705
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNTZWNyZXRLZXlJbmZvLnByb3RvGhNTZWNyZXRLZXlUeXBlLnByb3RvIkEK" + "DVNlY3JldEtleUluZm8SEgoKc2VjcmV0X2tleRgPIAEoCRIcCgR0eXBlGAQg" + "ASgOMg4uU2VjcmV0S2V5VHlwZUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			SecretKeyTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SecretKeyInfo), SecretKeyInfo.Parser, new string[]
			{
				"SecretKey",
				"Type"
			}, null, null, null, null)
		}));
	}
}
