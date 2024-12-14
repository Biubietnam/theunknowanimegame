using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D3E RID: 3390
	public static class QuestRecordReflection
	{
		// Token: 0x17002ACD RID: 10957
		// (get) Token: 0x06009795 RID: 38805 RVA: 0x00194149 File Offset: 0x00192349
		public static FileDescriptor Descriptor
		{
			get
			{
				return QuestRecordReflection.descriptor;
			}
		}

		// Token: 0x04003AF6 RID: 15094
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFRdWVzdFJlY29yZC5wcm90byI0CgtRdWVzdFJlY29yZBITCgtPSU5DQkdN" + "UEJJQxgDIAEoDRIQCghwcm9ncmVzcxgPIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(QuestRecord), QuestRecord.Parser, new string[]
			{
				"OINCBGMPBIC",
				"Progress"
			}, null, null, null, null)
		}));
	}
}
