using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010EA RID: 4330
	public static class SetDisplayAvatarScRspReflection
	{
		// Token: 0x1700367C RID: 13948
		// (get) Token: 0x0600C116 RID: 49430 RVA: 0x0020724C File Offset: 0x0020544C
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetDisplayAvatarScRspReflection.descriptor;
			}
		}

		// Token: 0x04004E38 RID: 20024
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtTZXREaXNwbGF5QXZhdGFyU2NSc3AucHJvdG8aF0Rpc3BsYXlBdmF0YXJE",
			"YXRhLnByb3RvIlkKFVNldERpc3BsYXlBdmF0YXJTY1JzcBIPCgdyZXRjb2Rl",
			"GAwgASgNEi8KE2Rpc3BsYXlfYXZhdGFyX2xpc3QYDSADKAsyEi5EaXNwbGF5",
			"QXZhdGFyRGF0YUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			DisplayAvatarDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetDisplayAvatarScRsp), SetDisplayAvatarScRsp.Parser, new string[]
			{
				"Retcode",
				"DisplayAvatarList"
			}, null, null, null, null)
		}));
	}
}
