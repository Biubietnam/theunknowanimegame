using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001418 RID: 5144
	public static class WaitDelResourceReflection
	{
		// Token: 0x17004070 RID: 16496
		// (get) Token: 0x0600E583 RID: 58755 RVA: 0x0026239A File Offset: 0x0026059A
		public static FileDescriptor Descriptor
		{
			get
			{
				return WaitDelResourceReflection.descriptor;
			}
		}

		// Token: 0x04005B26 RID: 23334
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVXYWl0RGVsUmVzb3VyY2UucHJvdG8iKwoPV2FpdERlbFJlc291cmNlEgsK" + "A251bRgPIAEoDRILCgN0aWQYASABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl" + "cnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(WaitDelResource), WaitDelResource.Parser, new string[]
			{
				"Num",
				"Tid"
			}, null, null, null, null)
		}));
	}
}
