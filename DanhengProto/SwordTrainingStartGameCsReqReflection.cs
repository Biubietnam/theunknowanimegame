using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200124C RID: 4684
	public static class SwordTrainingStartGameCsReqReflection
	{
		// Token: 0x17003AEC RID: 15084
		// (get) Token: 0x0600D135 RID: 53557 RVA: 0x0022FB15 File Offset: 0x0022DD15
		public static FileDescriptor Descriptor
		{
			get
			{
				return SwordTrainingStartGameCsReqReflection.descriptor;
			}
		}

		// Token: 0x040053F9 RID: 21497
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTd29yZFRyYWluaW5nU3RhcnRHYW1lQ3NSZXEucHJvdG8iOQobU3dvcmRU" + "cmFpbmluZ1N0YXJ0R2FtZUNzUmVxEhoKEmdhbWVfc3RvcnlfbGluZV9pZBgG" + "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingStartGameCsReq), SwordTrainingStartGameCsReq.Parser, new string[]
			{
				"GameStoryLineId"
			}, null, null, null, null)
		}));
	}
}
