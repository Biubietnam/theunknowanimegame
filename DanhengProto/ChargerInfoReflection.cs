using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001D6 RID: 470
	public static class ChargerInfoReflection
	{
		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x0003C7EF File Offset: 0x0003A9EF
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChargerInfoReflection.descriptor;
			}
		}

		// Token: 0x040008D8 RID: 2264
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDaGFyZ2VySW5mby5wcm90byI0CgtDaGFyZ2VySW5mbxITCgtHTUNGQkxG" + "QUZGTxgIIAEoDRIQCghncm91cF9pZBgJIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChargerInfo), ChargerInfo.Parser, new string[]
			{
				"GMCFBLFAFFO",
				"GroupId"
			}, null, null, null, null)
		}));
	}
}
