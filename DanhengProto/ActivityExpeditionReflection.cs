using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000034 RID: 52
	public static class ActivityExpeditionReflection
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000698C File Offset: 0x00004B8C
		public static FileDescriptor Descriptor
		{
			get
			{
				return ActivityExpeditionReflection.descriptor;
			}
		}

		// Token: 0x040000AD RID: 173
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhBY3Rpdml0eUV4cGVkaXRpb24ucHJvdG8ijAEKEkFjdGl2aXR5RXhwZWRp",
			"dGlvbhIKCgJpZBgGIAEoDRITCgtMQU9KQk9DSUVIThgDIAEoDRITCgtCUE1K",
			"UEVMRkpCSxgOIAEoDRITCgtQSE9HRU1QTEhMThgHIAEoDRITCgtPRkxLSENC",
			"RENBShgNIAEoAxIWCg5hdmF0YXJfaWRfbGlzdBgPIAMoDUIeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ActivityExpedition), ActivityExpedition.Parser, new string[]
			{
				"Id",
				"LAOJBOCIEHN",
				"BPMJPELFJBK",
				"PHOGEMPLHLN",
				"OFLKHCBDCAJ",
				"AvatarIdList"
			}, null, null, null, null)
		}));
	}
}
