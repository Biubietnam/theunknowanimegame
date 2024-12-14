using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A5E RID: 2654
	public static class LoginActivityDataReflection
	{
		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x060075B3 RID: 30131 RVA: 0x001387D7 File Offset: 0x001369D7
		public static FileDescriptor Descriptor
		{
			get
			{
				return LoginActivityDataReflection.descriptor;
			}
		}

		// Token: 0x04002D40 RID: 11584
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdMb2dpbkFjdGl2aXR5RGF0YS5wcm90byJIChFMb2dpbkFjdGl2aXR5RGF0" + "YRITCgtIQkRQQ0lIQU9DSBgHIAMoDRISCgpsb2dpbl9kYXlzGA4gASgNEgoK" + "AmlkGAQgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LoginActivityData), LoginActivityData.Parser, new string[]
			{
				"HBDPCIHAOCH",
				"LoginDays",
				"Id"
			}, null, null, null, null)
		}));
	}
}
