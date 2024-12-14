using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000354 RID: 852
	public static class DailyRefreshNotifyReflection
	{
		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x0600260F RID: 9743 RVA: 0x0006B0C2 File Offset: 0x000692C2
		public static FileDescriptor Descriptor
		{
			get
			{
				return DailyRefreshNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000F76 RID: 3958
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhEYWlseVJlZnJlc2hOb3RpZnkucHJvdG8iJQoSRGFpbHlSZWZyZXNoTm90" + "aWZ5Eg8KB2N1cl9kYXkYDiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl" + "ci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DailyRefreshNotify), DailyRefreshNotify.Parser, new string[]
			{
				"CurDay"
			}, null, null, null, null)
		}));
	}
}
