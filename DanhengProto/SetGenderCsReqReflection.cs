using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010FC RID: 4348
	public static class SetGenderCsReqReflection
	{
		// Token: 0x170036B4 RID: 14004
		// (get) Token: 0x0600C1E8 RID: 49640 RVA: 0x002090D5 File Offset: 0x002072D5
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetGenderCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004E7C RID: 20092
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRTZXRHZW5kZXJDc1JlcS5wcm90bxoMR2VuZGVyLnByb3RvIikKDlNldEdl" + "bmRlckNzUmVxEhcKBmdlbmRlchgPIAEoDjIHLkdlbmRlckIeqgIbRWdnTGlu" + "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			GenderReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetGenderCsReq), SetGenderCsReq.Parser, new string[]
			{
				"Gender"
			}, null, null, null, null)
		}));
	}
}
