using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A14 RID: 2580
	public static class LineupSlotDataReflection
	{
		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x060072AC RID: 29356 RVA: 0x00131654 File Offset: 0x0012F854
		public static FileDescriptor Descriptor
		{
			get
			{
				return LineupSlotDataReflection.descriptor;
			}
		}

		// Token: 0x04002C24 RID: 11300
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRMaW5ldXBTbG90RGF0YS5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJMCg5M" + "aW5ldXBTbG90RGF0YRIMCgRzbG90GA0gASgNEgoKAmlkGAMgASgNEiAKC2F2" + "YXRhcl90eXBlGAogASgOMgsuQXZhdGFyVHlwZUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LineupSlotData), LineupSlotData.Parser, new string[]
			{
				"Slot",
				"Id",
				"AvatarType"
			}, null, null, null, null)
		}));
	}
}
