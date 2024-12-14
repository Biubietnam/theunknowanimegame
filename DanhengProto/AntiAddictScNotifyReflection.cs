using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000A4 RID: 164
	public static class AntiAddictScNotifyReflection
	{
		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0001408F File Offset: 0x0001228F
		public static FileDescriptor Descriptor
		{
			get
			{
				return AntiAddictScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040002A0 RID: 672
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhBbnRpQWRkaWN0U2NOb3RpZnkucHJvdG8iQgoSQW50aUFkZGljdFNjTm90" + "aWZ5Eg0KBWxldmVsGA8gASgJEhAKCG1zZ190eXBlGAsgASgNEgsKA21zZxgE" + "IAEoCUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AntiAddictScNotify), AntiAddictScNotify.Parser, new string[]
			{
				"Level",
				"MsgType",
				"Msg"
			}, null, null, null, null)
		}));
	}
}
