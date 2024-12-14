using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B8E RID: 2958
	public static class MonsterListReflection
	{
		// Token: 0x170024BF RID: 9407
		// (get) Token: 0x06008314 RID: 33556 RVA: 0x00159FAF File Offset: 0x001581AF
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonsterListReflection.descriptor;
			}
		}

		// Token: 0x04003223 RID: 12835
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNb25zdGVyTGlzdC5wcm90byIuCgtNb25zdGVyTGlzdBISCgptb25zdGVy" + "X2lkGAogASgNEgsKA251bRgOIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonsterList), MonsterList.Parser, new string[]
			{
				"MonsterId",
				"Num"
			}, null, null, null, null)
		}));
	}
}
