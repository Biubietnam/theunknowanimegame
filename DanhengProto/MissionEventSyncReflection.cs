using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AE0 RID: 2784
	public static class MissionEventSyncReflection
	{
		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x06007B5B RID: 31579 RVA: 0x001466E4 File Offset: 0x001448E4
		public static FileDescriptor Descriptor
		{
			get
			{
				return MissionEventSyncReflection.descriptor;
			}
		}

		// Token: 0x04002F4D RID: 12109
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZNaXNzaW9uRXZlbnRTeW5jLnByb3RvGg1NaXNzaW9uLnByb3RvImIKEE1p" + "c3Npb25FdmVudFN5bmMSEwoLQkJBT0JNUElESU4YDyADKA0SEwoLRkVITkJP" + "S05HRUsYAyADKA0SJAoSbWlzc2lvbl9ldmVudF9saXN0GAsgAygLMgguTWlz" + "c2lvbkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			MissionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MissionEventSync), MissionEventSync.Parser, new string[]
			{
				"BBAOBMPIDIN",
				"FEHNBOKNGEK",
				"MissionEventList"
			}, null, null, null, null)
		}));
	}
}
