using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C0C RID: 3084
	public static class NewMailScNotifyReflection
	{
		// Token: 0x1700264D RID: 9805
		// (get) Token: 0x0600888E RID: 34958 RVA: 0x00168602 File Offset: 0x00166802
		public static FileDescriptor Descriptor
		{
			get
			{
				return NewMailScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04003455 RID: 13397
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVOZXdNYWlsU2NOb3RpZnkucHJvdG8iJQoPTmV3TWFpbFNjTm90aWZ5EhIK" + "Ck1haWxJZExpc3QYDSADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(NewMailScNotify), NewMailScNotify.Parser, new string[]
			{
				"MailIdList"
			}, null, null, null, null)
		}));
	}
}
