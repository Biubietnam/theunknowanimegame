using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000880 RID: 2176
	public static class GroupStateInfoReflection
	{
		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x060060C9 RID: 24777 RVA: 0x000FFD30 File Offset: 0x000FDF30
		public static FileDescriptor Descriptor
		{
			get
			{
				return GroupStateInfoReflection.descriptor;
			}
		}

		// Token: 0x04002530 RID: 9520
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRHcm91cFN0YXRlSW5mby5wcm90byJeCg5Hcm91cFN0YXRlSW5mbxIQCghn" + "cm91cF9pZBgPIAEoDRITCgtCS0dNQ0dKSUhHTxgBIAEoDRITCgtncm91cF9z" + "dGF0ZRgLIAEoDRIQCghlbnRyeV9pZBgOIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GroupStateInfo), GroupStateInfo.Parser, new string[]
			{
				"GroupId",
				"BKGMCGJIHGO",
				"GroupState",
				"EntryId"
			}, null, null, null, null)
		}));
	}
}
