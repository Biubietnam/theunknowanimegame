using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010C0 RID: 4288
	public static class ServerPrefsReflection
	{
		// Token: 0x17003604 RID: 13828
		// (get) Token: 0x0600BF43 RID: 48963 RVA: 0x002031CC File Offset: 0x002013CC
		public static FileDescriptor Descriptor
		{
			get
			{
				return ServerPrefsReflection.descriptor;
			}
		}

		// Token: 0x04004DAD RID: 19885
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFTZXJ2ZXJQcmVmcy5wcm90byI0CgtTZXJ2ZXJQcmVmcxIXCg9zZXJ2ZXJf" + "cHJlZnNfaWQYDCABKA0SDAoEZGF0YRgJIAEoDEIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ServerPrefs), ServerPrefs.Parser, new string[]
			{
				"ServerPrefsId",
				"Data"
			}, null, null, null, null)
		}));
	}
}
