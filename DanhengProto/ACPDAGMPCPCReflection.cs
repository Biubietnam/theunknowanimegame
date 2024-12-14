using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200002E RID: 46
	public static class ACPDAGMPCPCReflection
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00005A59 File Offset: 0x00003C59
		public static FileDescriptor Descriptor
		{
			get
			{
				return ACPDAGMPCPCReflection.descriptor;
			}
		}

		// Token: 0x0400008A RID: 138
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFBQ1BEQUdNUENQQy5wcm90bxoSUGxhdGZvcm1UeXBlLnByb3RvIq4BCgtB",
			"Q1BEQUdNUENQQxIfCghwbGF0Zm9ybRgHIAEoDjINLlBsYXRmb3JtVHlwZRIN",
			"CgVsZXZlbBgKIAEoDRIRCgloZWFkX2ljb24YCyABKA0SCwoDdWlkGA8gASgN",
			"EhMKC3JlbWFya19uYW1lGAMgASgJEhMKC0hGSEdQTE1FRkdKGA0gASgJEhMK",
			"C01IQ0tPRUFER0VMGAkgASgNEhAKCG5pY2tuYW1lGAIgASgJQh6qAhtFZ2dM",
			"aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			PlatformTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ACPDAGMPCPC), ACPDAGMPCPC.Parser, new string[]
			{
				"Platform",
				"Level",
				"HeadIcon",
				"Uid",
				"RemarkName",
				"HFHGPLMEFGJ",
				"MHCKOEADGEL",
				"Nickname"
			}, null, null, null, null)
		}));
	}
}
