using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000494 RID: 1172
	public static class EquipAetherDividePassiveSkillScRspReflection
	{
		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x0600342C RID: 13356 RVA: 0x0008F214 File Offset: 0x0008D414
		public static FileDescriptor Descriptor
		{
			get
			{
				return EquipAetherDividePassiveSkillScRspReflection.descriptor;
			}
		}

		// Token: 0x040014B2 RID: 5298
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CihFcXVpcEFldGhlckRpdmlkZVBhc3NpdmVTa2lsbFNjUnNwLnByb3RvGhxB",
			"ZXRoZXJEaXZpZGVTcGlyaXRJbmZvLnByb3RvGhVBZXRoZXJTa2lsbEluZm8u",
			"cHJvdG8ikAEKIkVxdWlwQWV0aGVyRGl2aWRlUGFzc2l2ZVNraWxsU2NSc3AS",
			"DwoHcmV0Y29kZRgJIAEoDRIsCgthZXRoZXJfaW5mbxgNIAEoCzIXLkFldGhl",
			"ckRpdmlkZVNwaXJpdEluZm8SKwoRYWV0aGVyX3NraWxsX2luZm8YDCABKAsy",
			"EC5BZXRoZXJTa2lsbEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
			"cm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			AetherDivideSpiritInfoReflection.Descriptor,
			AetherSkillInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EquipAetherDividePassiveSkillScRsp), EquipAetherDividePassiveSkillScRsp.Parser, new string[]
			{
				"Retcode",
				"AetherInfo",
				"AetherSkillInfo"
			}, null, null, null, null)
		}));
	}
}
