using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009FA RID: 2554
	public static class LeaveRaidCsReqReflection
	{
		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x06007163 RID: 29027 RVA: 0x0012DD73 File Offset: 0x0012BF73
		public static FileDescriptor Descriptor
		{
			get
			{
				return LeaveRaidCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002B9F RID: 11167
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRMZWF2ZVJhaWRDc1JlcS5wcm90byI3Cg5MZWF2ZVJhaWRDc1JlcRIPCgdy" + "YWlkX2lkGAYgASgNEhQKDGlzX3NhdmVfZGF0YRgDIAEoCEIeqgIbRWdnTGlu" + "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LeaveRaidCsReq), LeaveRaidCsReq.Parser, new string[]
			{
				"RaidId",
				"IsSaveData"
			}, null, null, null, null)
		}));
	}
}
