using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010BA RID: 4282
	public static class SendMsgCsReqReflection
	{
		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x0600BEFA RID: 48890 RVA: 0x0020255C File Offset: 0x0020075C
		public static FileDescriptor Descriptor
		{
			get
			{
				return SendMsgCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004D90 RID: 19856
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJTZW5kTXNnQ3NSZXEucHJvdG8aDU1zZ1R5cGUucHJvdG8aDkNoYXRUeXBl",
			"LnByb3RvGhFMRkNLUFBETElKSS5wcm90byKsAQoMU2VuZE1zZ0NzUmVxEh4K",
			"DG1lc3NhZ2VfdHlwZRgEIAEoDjIILk1zZ1R5cGUSEAoIZXh0cmFfaWQYByAB",
			"KA0SIQoLQk5BQk5DQ01JTE0YCCABKAsyDC5MRkNLUFBETElKSRIUCgxtZXNz",
			"YWdlX3RleHQYBiABKAkSEwoLdGFyZ2V0X2xpc3QYASADKA0SHAoJY2hhdF90",
			"eXBlGAIgASgOMgkuQ2hhdFR5cGVCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			MsgTypeReflection.Descriptor,
			ChatTypeReflection.Descriptor,
			LFCKPPDLIJIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SendMsgCsReq), SendMsgCsReq.Parser, new string[]
			{
				"MessageType",
				"ExtraId",
				"BNABNCCMILM",
				"MessageText",
				"TargetList",
				"ChatType"
			}, null, null, null, null)
		}));
	}
}
