using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200084A RID: 2122
	public static class GetVideoVersionKeyScRspReflection
	{
		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x06005E60 RID: 24160 RVA: 0x000F9CD2 File Offset: 0x000F7ED2
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetVideoVersionKeyScRspReflection.descriptor;
			}
		}

		// Token: 0x04002456 RID: 9302
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1HZXRWaWRlb1ZlcnNpb25LZXlTY1JzcC5wcm90bxoSVmlkZW9LZXlJbmZv",
			"LnByb3RvIosBChdHZXRWaWRlb1ZlcnNpb25LZXlTY1JzcBIPCgdyZXRjb2Rl",
			"GAkgASgNEioKE3ZpZGVvX2tleV9pbmZvX2xpc3QYDiADKAsyDS5WaWRlb0tl",
			"eUluZm8SMwocYWN0aXZpdHlfdmlkZW9fa2V5X2luZm9fbGlzdBgFIAMoCzIN",
			"LlZpZGVvS2V5SW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			VideoKeyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetVideoVersionKeyScRsp), GetVideoVersionKeyScRsp.Parser, new string[]
			{
				"Retcode",
				"VideoKeyInfoList",
				"ActivityVideoKeyInfoList"
			}, null, null, null, null)
		}));
	}
}
