using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011EE RID: 4590
	public static class StrongChallengeActivityInfoReflection
	{
		// Token: 0x170039E5 RID: 14821
		// (get) Token: 0x0600CD34 RID: 52532 RVA: 0x00226DB6 File Offset: 0x00224FB6
		public static FileDescriptor Descriptor
		{
			get
			{
				return StrongChallengeActivityInfoReflection.descriptor;
			}
		}

		// Token: 0x040052C5 RID: 21189
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFTdHJvbmdDaGFsbGVuZ2VBY3Rpdml0eUluZm8ucHJvdG8aIVN0cm9uZ0No",
			"YWxsZW5nZUFjdGl2aXR5RGF0YS5wcm90byKzAQobU3Ryb25nQ2hhbGxlbmdl",
			"QWN0aXZpdHlJbmZvEkIKC1BFREhLQk9ISExJGAwgAygLMi0uU3Ryb25nQ2hh",
			"bGxlbmdlQWN0aXZpdHlJbmZvLlBFREhLQk9ISExJRW50cnkaUAoQUEVESEtC",
			"T0hITElFbnRyeRILCgNrZXkYASABKA0SKwoFdmFsdWUYAiABKAsyHC5TdHJv",
			"bmdDaGFsbGVuZ2VBY3Rpdml0eURhdGE6AjgBQh6qAhtFZ2dMaW5rLkRhbmhl",
			"bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			StrongChallengeActivityDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StrongChallengeActivityInfo), StrongChallengeActivityInfo.Parser, new string[]
			{
				"PEDHKBOHHLI"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
