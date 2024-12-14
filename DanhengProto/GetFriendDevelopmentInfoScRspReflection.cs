using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006C6 RID: 1734
	public static class GetFriendDevelopmentInfoScRspReflection
	{
		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x06004DA4 RID: 19876 RVA: 0x000D257E File Offset: 0x000D077E
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFriendDevelopmentInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001EB1 RID: 7857
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNHZXRGcmllbmREZXZlbG9wbWVudEluZm9TY1JzcC5wcm90bxoRRkFJTk1P",
			"QlBKTUcucHJvdG8iYAodR2V0RnJpZW5kRGV2ZWxvcG1lbnRJbmZvU2NSc3AS",
			"DwoHcmV0Y29kZRgKIAEoDRILCgN1aWQYByABKA0SIQoLT0lNQk1HTk5OQk0Y",
			"DyADKAsyDC5GQUlOTU9CUEpNR0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			FAINMOBPJMGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendDevelopmentInfoScRsp), GetFriendDevelopmentInfoScRsp.Parser, new string[]
			{
				"Retcode",
				"Uid",
				"OIMBMGNNNBM"
			}, null, null, null, null)
		}));
	}
}
