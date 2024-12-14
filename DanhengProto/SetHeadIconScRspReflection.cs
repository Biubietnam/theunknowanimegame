using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001106 RID: 4358
	public static class SetHeadIconScRspReflection
	{
		// Token: 0x170036D3 RID: 14035
		// (get) Token: 0x0600C25C RID: 49756 RVA: 0x0020A1FE File Offset: 0x002083FE
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetHeadIconScRspReflection.descriptor;
			}
		}

		// Token: 0x04004EA2 RID: 20130
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZTZXRIZWFkSWNvblNjUnNwLnByb3RvIkEKEFNldEhlYWRJY29uU2NSc3AS" + "DwoHcmV0Y29kZRgIIAEoDRIcChRjdXJyZW50X2hlYWRfaWNvbl9pZBgJIAEo" + "DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetHeadIconScRsp), SetHeadIconScRsp.Parser, new string[]
			{
				"Retcode",
				"CurrentHeadIconId"
			}, null, null, null, null)
		}));
	}
}
