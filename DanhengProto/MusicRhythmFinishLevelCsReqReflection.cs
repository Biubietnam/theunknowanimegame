using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BDC RID: 3036
	public static class MusicRhythmFinishLevelCsReqReflection
	{
		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x06008668 RID: 34408 RVA: 0x00162D99 File Offset: 0x00160F99
		public static FileDescriptor Descriptor
		{
			get
			{
				return MusicRhythmFinishLevelCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003382 RID: 13186
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFNdXNpY1JoeXRobUZpbmlzaExldmVsQ3NSZXEucHJvdG8iRQobTXVzaWNS" + "aHl0aG1GaW5pc2hMZXZlbENzUmVxEhAKCHNjb3JlX2lkGAwgASgNEhQKDGZp" + "bmlzaF9sZXZlbBgLIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MusicRhythmFinishLevelCsReq), MusicRhythmFinishLevelCsReq.Parser, new string[]
			{
				"ScoreId",
				"FinishLevel"
			}, null, null, null, null)
		}));
	}
}
