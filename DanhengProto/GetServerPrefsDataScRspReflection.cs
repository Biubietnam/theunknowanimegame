using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007EE RID: 2030
	public static class GetServerPrefsDataScRspReflection
	{
		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x06005A96 RID: 23190 RVA: 0x000F177E File Offset: 0x000EF97E
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetServerPrefsDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04002327 RID: 8999
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRTZXJ2ZXJQcmVmc0RhdGFTY1JzcC5wcm90bxoRU2VydmVyUHJlZnMu" + "cHJvdG8iTgoXR2V0U2VydmVyUHJlZnNEYXRhU2NSc3ASDwoHcmV0Y29kZRgM" + "IAEoDRIiCgxzZXJ2ZXJfcHJlZnMYDSABKAsyDC5TZXJ2ZXJQcmVmc0IeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ServerPrefsReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetServerPrefsDataScRsp), GetServerPrefsDataScRsp.Parser, new string[]
			{
				"Retcode",
				"ServerPrefs"
			}, null, null, null, null)
		}));
	}
}
