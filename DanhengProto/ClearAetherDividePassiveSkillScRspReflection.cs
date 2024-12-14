using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002D2 RID: 722
	public static class ClearAetherDividePassiveSkillScRspReflection
	{
		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x0005B855 File Offset: 0x00059A55
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClearAetherDividePassiveSkillScRspReflection.descriptor;
			}
		}

		// Token: 0x04000D4F RID: 3407
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CihDbGVhckFldGhlckRpdmlkZVBhc3NpdmVTa2lsbFNjUnNwLnByb3RvGhxB",
			"ZXRoZXJEaXZpZGVTcGlyaXRJbmZvLnByb3RvGhVBZXRoZXJTa2lsbEluZm8u",
			"cHJvdG8ikAEKIkNsZWFyQWV0aGVyRGl2aWRlUGFzc2l2ZVNraWxsU2NSc3AS",
			"DwoHcmV0Y29kZRgDIAEoDRIrChFhZXRoZXJfc2tpbGxfaW5mbxgPIAEoCzIQ",
			"LkFldGhlclNraWxsSW5mbxIsCgthZXRoZXJfaW5mbxgHIAEoCzIXLkFldGhl",
			"ckRpdmlkZVNwaXJpdEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
			"cm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			AetherDivideSpiritInfoReflection.Descriptor,
			AetherSkillInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ClearAetherDividePassiveSkillScRsp), ClearAetherDividePassiveSkillScRsp.Parser, new string[]
			{
				"Retcode",
				"AetherSkillInfo",
				"AetherInfo"
			}, null, null, null, null)
		}));
	}
}
