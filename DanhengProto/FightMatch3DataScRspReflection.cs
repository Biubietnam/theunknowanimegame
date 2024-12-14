using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000548 RID: 1352
	public static class FightMatch3DataScRspReflection
	{
		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06003C46 RID: 15430 RVA: 0x000A52BE File Offset: 0x000A34BE
		public static FileDescriptor Descriptor
		{
			get
			{
				return FightMatch3DataScRspReflection.descriptor;
			}
		}

		// Token: 0x04001830 RID: 6192
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpGaWdodE1hdGNoM0RhdGFTY1JzcC5wcm90bxoRQ0NIQ1BOTFBCREsucHJv",
			"dG8aEUNGSFBNQk9BSExBLnByb3RvImYKFEZpZ2h0TWF0Y2gzRGF0YVNjUnNw",
			"Eg8KB3JldGNvZGUYBiABKA0SIQoLRUJNT0tQQktNTUQYAyADKAsyDC5DQ0hD",
			"UE5MUEJESxIaCgRkYXRhGAwgASgLMgwuQ0ZIUE1CT0FITEFCHqoCG0VnZ0xp",
			"bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			CCHCPNLPBDKReflection.Descriptor,
			CFHPMBOAHLAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FightMatch3DataScRsp), FightMatch3DataScRsp.Parser, new string[]
			{
				"Retcode",
				"EBMOKPBKMMD",
				"Data"
			}, null, null, null, null)
		}));
	}
}
