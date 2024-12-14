using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A54 RID: 2644
	public static class LockEquipmentCsReqReflection
	{
		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x06007544 RID: 30020 RVA: 0x00137842 File Offset: 0x00135A42
		public static FileDescriptor Descriptor
		{
			get
			{
				return LockEquipmentCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002D1D RID: 11549
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhMb2NrRXF1aXBtZW50Q3NSZXEucHJvdG8iRQoSTG9ja0VxdWlwbWVudENz" + "UmVxEhQKDGlzX3Byb3RlY3RlZBgDIAEoCBIZChFlcXVpcG1lbnRfaWRfbGlz" + "dBgIIAMoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LockEquipmentCsReq), LockEquipmentCsReq.Parser, new string[]
			{
				"IsProtected",
				"EquipmentIdList"
			}, null, null, null, null)
		}));
	}
}
