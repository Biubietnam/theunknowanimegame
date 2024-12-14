using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000614 RID: 1556
	public static class GetAllServerPrefsDataScRspReflection
	{
		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x060045CE RID: 17870 RVA: 0x000BF41A File Offset: 0x000BD61A
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetAllServerPrefsDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04001BEC RID: 7148
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBHZXRBbGxTZXJ2ZXJQcmVmc0RhdGFTY1JzcC5wcm90bxoRU2VydmVyUHJl",
			"ZnMucHJvdG8iVgoaR2V0QWxsU2VydmVyUHJlZnNEYXRhU2NSc3ASDwoHcmV0",
			"Y29kZRgNIAEoDRInChFzZXJ2ZXJfcHJlZnNfbGlzdBgOIAMoCzIMLlNlcnZl",
			"clByZWZzQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			ServerPrefsReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetAllServerPrefsDataScRsp), GetAllServerPrefsDataScRsp.Parser, new string[]
			{
				"Retcode",
				"ServerPrefsList"
			}, null, null, null, null)
		}));
	}
}
