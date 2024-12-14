using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200050E RID: 1294
	public static class FeatureSwitchInfoReflection
	{
		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x06003A09 RID: 14857 RVA: 0x0009FA42 File Offset: 0x0009DC42
		public static FileDescriptor Descriptor
		{
			get
			{
				return FeatureSwitchInfoReflection.descriptor;
			}
		}

		// Token: 0x0400171E RID: 5918
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdGZWF0dXJlU3dpdGNoSW5mby5wcm90bxoXRmVhdHVyZVN3aXRjaFR5cGUu",
			"cHJvdG8aGEZlYXR1cmVTd2l0Y2hQYXJhbS5wcm90byJ2ChFGZWF0dXJlU3dp",
			"dGNoSW5mbxIgCgRUeXBlGAEgASgOMhIuRmVhdHVyZVN3aXRjaFR5cGUSKAoL",
			"c3dpdGNoX2xpc3QYAiADKAsyEy5GZWF0dXJlU3dpdGNoUGFyYW0SFQoNaXNf",
			"YWxsX2Nsb3NlZBgDIAEoCEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
			"b3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			FeatureSwitchTypeReflection.Descriptor,
			FeatureSwitchParamReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FeatureSwitchInfo), FeatureSwitchInfo.Parser, new string[]
			{
				"Type",
				"SwitchList",
				"IsAllClosed"
			}, null, null, null, null)
		}));
	}
}
