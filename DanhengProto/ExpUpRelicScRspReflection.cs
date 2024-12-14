using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004EE RID: 1262
	public static class ExpUpRelicScRspReflection
	{
		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x0600387A RID: 14458 RVA: 0x0009AB54 File Offset: 0x00098D54
		public static FileDescriptor Descriptor
		{
			get
			{
				return ExpUpRelicScRspReflection.descriptor;
			}
		}

		// Token: 0x04001656 RID: 5718
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVFeHBVcFJlbGljU2NSc3AucHJvdG8aDlBpbGVJdGVtLnByb3RvIkcKD0V4" + "cFVwUmVsaWNTY1JzcBIPCgdyZXRjb2RlGAUgASgNEiMKEHJldHVybl9pdGVt" + "X2xpc3QYASADKAsyCS5QaWxlSXRlbUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			PileItemReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ExpUpRelicScRsp), ExpUpRelicScRsp.Parser, new string[]
			{
				"Retcode",
				"ReturnItemList"
			}, null, null, null, null)
		}));
	}
}
