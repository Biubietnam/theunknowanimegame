using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200078A RID: 1930
	public static class GetQuestRecordScRspReflection
	{
		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x0600563E RID: 22078 RVA: 0x000E75DE File Offset: 0x000E57DE
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetQuestRecordScRspReflection.descriptor;
			}
		}

		// Token: 0x040021C3 RID: 8643
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRRdWVzdFJlY29yZFNjUnNwLnByb3RvGhFRdWVzdFJlY29yZC5wcm90" + "byJJChNHZXRRdWVzdFJlY29yZFNjUnNwEg8KB3JldGNvZGUYCSABKA0SIQoL" + "TEtKUEhOSExGSUYYDiADKAsyDC5RdWVzdFJlY29yZEIeqgIbRWdnTGluay5E" + "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			QuestRecordReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetQuestRecordScRsp), GetQuestRecordScRsp.Parser, new string[]
			{
				"Retcode",
				"LKJPHNHLFIF"
			}, null, null, null, null)
		}));
	}
}
