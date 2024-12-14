using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004F6 RID: 1270
	public static class ExtraScoreInfoReflection
	{
		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x060038C8 RID: 14536 RVA: 0x0009B9CA File Offset: 0x00099BCA
		public static FileDescriptor Descriptor
		{
			get
			{
				return ExtraScoreInfoReflection.descriptor;
			}
		}

		// Token: 0x04001687 RID: 5767
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRFeHRyYVNjb3JlSW5mby5wcm90byJYCg5FeHRyYVNjb3JlSW5mbxIRCglp" + "c19maW5pc2gYBiABKAgSEwoLR0xIRE1KQ0xGRkgYAiABKA0SEAoIZW5kX3Rp" + "bWUYByABKAMSDAoEd2VlaxgJIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ExtraScoreInfo), ExtraScoreInfo.Parser, new string[]
			{
				"IsFinish",
				"GLHDMJCLFFH",
				"EndTime",
				"Week"
			}, null, null, null, null)
		}));
	}
}
