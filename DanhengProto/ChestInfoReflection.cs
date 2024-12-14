using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002BC RID: 700
	public static class ChestInfoReflection
	{
		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001F32 RID: 7986 RVA: 0x00058F90 File Offset: 0x00057190
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChestInfoReflection.descriptor;
			}
		}

		// Token: 0x04000CEE RID: 3310
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9DaGVzdEluZm8ucHJvdG8aD0NoZXN0VHlwZS5wcm90byJSCglDaGVzdElu" + "Zm8SHgoKY2hlc3RfdHlwZRgLIAEoDjIKLkNoZXN0VHlwZRISCgpvcGVuZWRf" + "bnVtGAogASgNEhEKCWV4aXN0X251bRgEIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ChestTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChestInfo), ChestInfo.Parser, new string[]
			{
				"ChestType",
				"OpenedNum",
				"ExistNum"
			}, null, null, null, null)
		}));
	}
}
