using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001174 RID: 4468
	public static class SpaceZooTakeScRspReflection
	{
		// Token: 0x1700383C RID: 14396
		// (get) Token: 0x0600C761 RID: 51041 RVA: 0x0021704E File Offset: 0x0021524E
		public static FileDescriptor Descriptor
		{
			get
			{
				return SpaceZooTakeScRspReflection.descriptor;
			}
		}

		// Token: 0x04005088 RID: 20616
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdTcGFjZVpvb1Rha2VTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8iVAoR" + "U3BhY2Vab29UYWtlU2NSc3ASDwoHcmV0Y29kZRgMIAEoDRITCgtHRENPREJD" + "REtBQRgPIAEoDRIZCgZyZXdhcmQYCiABKAsyCS5JdGVtTGlzdEIeqgIbRWdn" + "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooTakeScRsp), SpaceZooTakeScRsp.Parser, new string[]
			{
				"Retcode",
				"GDCODBCDKAA",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
