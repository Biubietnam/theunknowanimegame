using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DD6 RID: 3542
	public static class RetcodeNotifyReflection
	{
		// Token: 0x17002CAF RID: 11439
		// (get) Token: 0x06009E4F RID: 40527 RVA: 0x001A7922 File Offset: 0x001A5B22
		public static FileDescriptor Descriptor
		{
			get
			{
				return RetcodeNotifyReflection.descriptor;
			}
		}

		// Token: 0x040040F9 RID: 16633
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNSZXRjb2RlTm90aWZ5LnByb3RvGg1SZXRjb2RlLnByb3RvIj8KDVJldGNv" + "ZGVOb3RpZnkSGQoHcmV0Y29kZRgDIAEoDjIILlJldGNvZGUSEwoLRERETlBQ" + "QUtJTk4YDSADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[]
		{
			RetcodeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RetcodeNotify), RetcodeNotify.Parser, new string[]
			{
				"Retcode",
				"DDDNPPAKINN"
			}, null, null, null, null)
		}));
	}
}
