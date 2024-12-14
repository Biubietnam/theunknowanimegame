using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001042 RID: 4162
	public static class RotaterDataReflection
	{
		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x0600B92F RID: 47407 RVA: 0x001F1327 File Offset: 0x001EF527
		public static FileDescriptor Descriptor
		{
			get
			{
				return RotaterDataReflection.descriptor;
			}
		}

		// Token: 0x04004B03 RID: 19203
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFSb3RhdGVyRGF0YS5wcm90byJJCgtSb3RhdGVyRGF0YRIQCghncm91cF9p" + "ZBgMIAEoDRITCgtHTUNGQkxGQUZGTxgFIAEoDRITCgtMRU5QR0NQTUdDTBgC" + "IAEoAkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RotaterData), RotaterData.Parser, new string[]
			{
				"GroupId",
				"GMCFBLFAFFO",
				"LENPGCPMGCL"
			}, null, null, null, null)
		}));
	}
}
