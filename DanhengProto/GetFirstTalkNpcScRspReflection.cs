using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006AE RID: 1710
	public static class GetFirstTalkNpcScRspReflection
	{
		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06004C8F RID: 19599 RVA: 0x000CF9F4 File Offset: 0x000CDBF4
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFirstTalkNpcScRspReflection.descriptor;
			}
		}

		// Token: 0x04001E4A RID: 7754
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpHZXRGaXJzdFRhbGtOcGNTY1JzcC5wcm90bxoWRmlyc3ROcGNUYWxrSW5m",
			"by5wcm90byJYChRHZXRGaXJzdFRhbGtOcGNTY1JzcBIPCgdyZXRjb2RlGAMg",
			"ASgNEi8KFG5wY19tZWV0X3N0YXR1c19saXN0GA0gAygLMhEuRmlyc3ROcGNU",
			"YWxrSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			FirstNpcTalkInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFirstTalkNpcScRsp), GetFirstTalkNpcScRsp.Parser, new string[]
			{
				"Retcode",
				"NpcMeetStatusList"
			}, null, null, null, null)
		}));
	}
}
