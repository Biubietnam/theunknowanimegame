using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001C4 RID: 452
	public static class ChallengeStoryStatisticsReflection
	{
		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x0003A8D7 File Offset: 0x00038AD7
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeStoryStatisticsReflection.descriptor;
			}
		}

		// Token: 0x0400088E RID: 2190
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5DaGFsbGVuZ2VTdG9yeVN0YXRpc3RpY3MucHJvdG8aIkNoYWxsZW5nZVN0",
			"b3J5U3RhZ2VUZXJ0aW5nZ2kucHJvdG8iZQoYQ2hhbGxlbmdlU3RvcnlTdGF0",
			"aXN0aWNzEjYKD3N0YWdlX3RlcnRpbmdnaRgDIAEoCzIdLkNoYWxsZW5nZVN0",
			"b3J5U3RhZ2VUZXJ0aW5nZ2kSEQoJcmVjb3JkX2lkGAQgASgNQh6qAhtFZ2dM",
			"aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChallengeStoryStageTertinggiReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeStoryStatistics), ChallengeStoryStatistics.Parser, new string[]
			{
				"StageTertinggi",
				"RecordId"
			}, null, null, null, null)
		}));
	}
}
