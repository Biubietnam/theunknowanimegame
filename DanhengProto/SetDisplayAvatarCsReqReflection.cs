using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010E8 RID: 4328
	public static class SetDisplayAvatarCsReqReflection
	{
		// Token: 0x17003677 RID: 13943
		// (get) Token: 0x0600C102 RID: 49410 RVA: 0x00206FD1 File Offset: 0x002051D1
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetDisplayAvatarCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004E32 RID: 20018
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTZXREaXNwbGF5QXZhdGFyQ3NSZXEucHJvdG8aF0Rpc3BsYXlBdmF0YXJE" + "YXRhLnByb3RvIkgKFVNldERpc3BsYXlBdmF0YXJDc1JlcRIvChNkaXNwbGF5" + "X2F2YXRhcl9saXN0GAogAygLMhIuRGlzcGxheUF2YXRhckRhdGFCHqoCG0Vn" + "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			DisplayAvatarDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetDisplayAvatarCsReq), SetDisplayAvatarCsReq.Parser, new string[]
			{
				"DisplayAvatarList"
			}, null, null, null, null)
		}));
	}
}
