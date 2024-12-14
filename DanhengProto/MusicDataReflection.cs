using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BD6 RID: 3030
	public static class MusicDataReflection
	{
		// Token: 0x17002599 RID: 9625
		// (get) Token: 0x0600861A RID: 34330 RVA: 0x00161EB6 File Offset: 0x001600B6
		public static FileDescriptor Descriptor
		{
			get
			{
				return MusicDataReflection.descriptor;
			}
		}

		// Token: 0x0400335A RID: 13146
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9NdXNpY0RhdGEucHJvdG8iPAoJTXVzaWNEYXRhEhEKCWlzX3BsYXllZBgE" + "IAEoCBIKCgJpZBgLIAEoDRIQCghncm91cF9pZBgIIAEoDUIeqgIbRWdnTGlu" + "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MusicData), MusicData.Parser, new string[]
			{
				"IsPlayed",
				"Id",
				"GroupId"
			}, null, null, null, null)
		}));
	}
}
