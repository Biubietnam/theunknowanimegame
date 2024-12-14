using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001100 RID: 4352
	public static class SetGroupCustomSaveDataCsReqReflection
	{
		// Token: 0x170036C0 RID: 14016
		// (get) Token: 0x0600C215 RID: 49685 RVA: 0x0020978A File Offset: 0x0020798A
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetGroupCustomSaveDataCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004E8B RID: 20107
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTZXRHcm91cEN1c3RvbVNhdmVEYXRhQ3NSZXEucHJvdG8iVAobU2V0R3Jv" + "dXBDdXN0b21TYXZlRGF0YUNzUmVxEhEKCXNhdmVfZGF0YRgKIAEoCRIQCghn" + "cm91cF9pZBgOIAEoDRIQCghlbnRyeV9pZBgGIAEoDUIeqgIbRWdnTGluay5E" + "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetGroupCustomSaveDataCsReq), SetGroupCustomSaveDataCsReq.Parser, new string[]
			{
				"SaveData",
				"GroupId",
				"EntryId"
			}, null, null, null, null)
		}));
	}
}
