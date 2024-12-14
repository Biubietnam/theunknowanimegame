using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001112 RID: 4370
	public static class SetLineupNameScRspReflection
	{
		// Token: 0x170036F5 RID: 14069
		// (get) Token: 0x0600C2E2 RID: 49890 RVA: 0x0020B3ED File Offset: 0x002095ED
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetLineupNameScRspReflection.descriptor;
			}
		}

		// Token: 0x04004EC8 RID: 20168
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTZXRMaW5ldXBOYW1lU2NSc3AucHJvdG8iQgoSU2V0TGluZXVwTmFtZVNj" + "UnNwEgwKBG5hbWUYBCABKAkSDQoFaW5kZXgYDSABKA0SDwoHcmV0Y29kZRgG" + "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetLineupNameScRsp), SetLineupNameScRsp.Parser, new string[]
			{
				"Name",
				"Index",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
