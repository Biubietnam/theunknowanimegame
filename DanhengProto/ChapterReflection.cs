using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001D2 RID: 466
	public static class ChapterReflection
	{
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x0003BFAE File Offset: 0x0003A1AE
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChapterReflection.descriptor;
			}
		}

		// Token: 0x040008C4 RID: 2244
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg1DaGFwdGVyLnByb3RvGg5XYXlwb2ludC5wcm90bxoSQ2hhcHRlckJyaWVm" + "LnByb3RvIk0KB0NoYXB0ZXISHgoLS0FBR0NORENCQUwYBiADKAsyCS5XYXlw" + "b2ludBIiCgtLQ1BOSUlMTUZFSxgLIAEoCzINLkNoYXB0ZXJCcmllZkIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			WaypointReflection.Descriptor,
			ChapterBriefReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Chapter), Chapter.Parser, new string[]
			{
				"KAAGCNDCBAL",
				"KCPNIILMFEK"
			}, null, null, null, null)
		}));
	}
}
