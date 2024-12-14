using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000528 RID: 1320
	public static class FightEnterScRspReflection
	{
		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06003B15 RID: 15125 RVA: 0x000A27D2 File Offset: 0x000A09D2
		public static FileDescriptor Descriptor
		{
			get
			{
				return FightEnterScRspReflection.descriptor;
			}
		}

		// Token: 0x040017C3 RID: 6083
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVGaWdodEVudGVyU2NSc3AucHJvdG8iggEKD0ZpZ2h0RW50ZXJTY1JzcBIT",
			"CgtLTUFOUEpDTUFPQhgEIAEoDRITCgtMSk1GT0hMT0JDSRgFIAEoCBIXCg9z",
			"ZWNyZXRfa2V5X3NlZWQYDyABKAQSGwoTc2VydmVyX3RpbWVzdGFtcF9tcxgN",
			"IAEoBBIPCgdyZXRjb2RlGAEgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
			"ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FightEnterScRsp), FightEnterScRsp.Parser, new string[]
			{
				"KMANPJCMAOB",
				"LJMFOHLOBCI",
				"SecretKeySeed",
				"ServerTimestampMs",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
