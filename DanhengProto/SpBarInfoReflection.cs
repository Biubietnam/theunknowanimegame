using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001178 RID: 4472
	public static class SpBarInfoReflection
	{
		// Token: 0x17003849 RID: 14409
		// (get) Token: 0x0600C791 RID: 51089 RVA: 0x002177FD File Offset: 0x002159FD
		public static FileDescriptor Descriptor
		{
			get
			{
				return SpBarInfoReflection.descriptor;
			}
		}

		// Token: 0x04005098 RID: 20632
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9TcEJhckluZm8ucHJvdG8iKwoJU3BCYXJJbmZvEg4KBmN1cl9zcBgBIAEo" + "DRIOCgZtYXhfc3AYAiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SpBarInfo), SpBarInfo.Parser, new string[]
			{
				"CurSp",
				"MaxSp"
			}, null, null, null, null)
		}));
	}
}
