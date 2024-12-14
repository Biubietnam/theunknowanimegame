using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012B8 RID: 4792
	public static class TakeApRewardScRspReflection
	{
		// Token: 0x17003C1C RID: 15388
		// (get) Token: 0x0600D5C6 RID: 54726 RVA: 0x0023A63A File Offset: 0x0023883A
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeApRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x0400556B RID: 21867
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdUYWtlQXBSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8iTgoR" + "VGFrZUFwUmV3YXJkU2NSc3ASGQoGcmV3YXJkGAsgASgLMgkuSXRlbUxpc3QS" + "DwoHcmV0Y29kZRgJIAEoDRINCgVsZXZlbBgGIAEoDUIeqgIbRWdnTGluay5E" + "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeApRewardScRsp), TakeApRewardScRsp.Parser, new string[]
			{
				"Reward",
				"Retcode",
				"Level"
			}, null, null, null, null)
		}));
	}
}
