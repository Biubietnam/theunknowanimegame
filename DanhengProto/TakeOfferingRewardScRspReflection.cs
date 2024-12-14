using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012FE RID: 4862
	public static class TakeOfferingRewardScRspReflection
	{
		// Token: 0x17003CFA RID: 15610
		// (get) Token: 0x0600D8F6 RID: 55542 RVA: 0x00242569 File Offset: 0x00240769
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeOfferingRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x04005685 RID: 22149
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1UYWtlT2ZmZXJpbmdSZXdhcmRTY1JzcC5wcm90bxoRUE9QREhGRUJMUEcu",
			"cHJvdG8aDkl0ZW1MaXN0LnByb3RvImgKF1Rha2VPZmZlcmluZ1Jld2FyZFNj",
			"UnNwEhkKBnJld2FyZBgDIAEoCzIJLkl0ZW1MaXN0EiEKC0pMRUZNTEFERUhJ",
			"GAsgASgLMgwuUE9QREhGRUJMUEcSDwoHcmV0Y29kZRgKIAEoDUIeqgIbRWdn",
			"TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			POPDHFEBLPGReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeOfferingRewardScRsp), TakeOfferingRewardScRsp.Parser, new string[]
			{
				"Reward",
				"JLEFMLADEHI",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
