using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008E0 RID: 2272
	public static class HeliobusUpgradeLevelScRspReflection
	{
		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x06006558 RID: 25944 RVA: 0x0010EFD6 File Offset: 0x0010D1D6
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeliobusUpgradeLevelScRspReflection.descriptor;
			}
		}

		// Token: 0x040026FA RID: 9978
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9IZWxpb2J1c1VwZ3JhZGVMZXZlbFNjUnNwLnByb3RvIjsKGUhlbGlvYnVz" + "VXBncmFkZUxldmVsU2NSc3ASDwoHcmV0Y29kZRgKIAEoDRINCgVsZXZlbBgD" + "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusUpgradeLevelScRsp), HeliobusUpgradeLevelScRsp.Parser, new string[]
			{
				"Retcode",
				"Level"
			}, null, null, null, null)
		}));
	}
}
