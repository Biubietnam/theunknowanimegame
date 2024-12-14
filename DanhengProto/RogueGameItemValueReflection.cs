using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E92 RID: 3730
	public static class RogueGameItemValueReflection
	{
		// Token: 0x17002F19 RID: 12057
		// (get) Token: 0x0600A6B1 RID: 42673 RVA: 0x001C11AB File Offset: 0x001BF3AB
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueGameItemValueReflection.descriptor;
			}
		}

		// Token: 0x04004435 RID: 17461
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhSb2d1ZUdhbWVJdGVtVmFsdWUucHJvdG8ihAEKElJvZ3VlR2FtZUl0ZW1W",
			"YWx1ZRI6Cgx2aXJ0dWFsX2l0ZW0YAiADKAsyJC5Sb2d1ZUdhbWVJdGVtVmFs",
			"dWUuVmlydHVhbEl0ZW1FbnRyeRoyChBWaXJ0dWFsSXRlbUVudHJ5EgsKA2tl",
			"eRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFCHqoCG0VnZ0xpbmsuRGFuaGVu",
			"Z1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueGameItemValue), RogueGameItemValue.Parser, new string[]
			{
				"VirtualItem"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
