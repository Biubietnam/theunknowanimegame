using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001356 RID: 4950
	public static class TextJoinQueryScRspReflection
	{
		// Token: 0x17003E0F RID: 15887
		// (get) Token: 0x0600DCF5 RID: 56565 RVA: 0x0024C3F8 File Offset: 0x0024A5F8
		public static FileDescriptor Descriptor
		{
			get
			{
				return TextJoinQueryScRspReflection.descriptor;
			}
		}

		// Token: 0x040057E2 RID: 22498
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhUZXh0Sm9pblF1ZXJ5U2NSc3AucHJvdG8aElRleHRKb2luSW5mby5wcm90" + "byJMChJUZXh0Sm9pblF1ZXJ5U2NSc3ASJQoOdGV4dF9qb2luX2xpc3QYAyAD" + "KAsyDS5UZXh0Sm9pbkluZm8SDwoHcmV0Y29kZRgHIAEoDUIeqgIbRWdnTGlu" + "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			TextJoinInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TextJoinQueryScRsp), TextJoinQueryScRsp.Parser, new string[]
			{
				"TextJoinList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
