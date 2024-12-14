using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005B8 RID: 1464
	public static class FormulaTypeValueReflection
	{
		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x0600417E RID: 16766 RVA: 0x000B2702 File Offset: 0x000B0902
		public static FileDescriptor Descriptor
		{
			get
			{
				return FormulaTypeValueReflection.descriptor;
			}
		}

		// Token: 0x04001A00 RID: 6656
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZGb3JtdWxhVHlwZVZhbHVlLnByb3RvIooBChBGb3JtdWxhVHlwZVZhbHVl",
			"Ej8KEGZvcm11bGFfdHlwZV9tYXAYCCADKAsyJS5Gb3JtdWxhVHlwZVZhbHVl",
			"LkZvcm11bGFUeXBlTWFwRW50cnkaNQoTRm9ybXVsYVR5cGVNYXBFbnRyeRIL",
			"CgNrZXkYASABKA0SDQoFdmFsdWUYAiABKAU6AjgBQh6qAhtFZ2dMaW5rLkRh",
			"bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FormulaTypeValue), FormulaTypeValue.Parser, new string[]
			{
				"FormulaTypeMap"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
