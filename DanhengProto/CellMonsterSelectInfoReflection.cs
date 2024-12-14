using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000180 RID: 384
	public static class CellMonsterSelectInfoReflection
	{
		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x0003198E File Offset: 0x0002FB8E
		public static FileDescriptor Descriptor
		{
			get
			{
				return CellMonsterSelectInfoReflection.descriptor;
			}
		}

		// Token: 0x0400072F RID: 1839
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDZWxsTW9uc3RlclNlbGVjdEluZm8ucHJvdG8iSAoVQ2VsbE1vbnN0ZXJT" + "ZWxlY3RJbmZvEhcKD3NlbGVjdF9kZWNheV9pZBgLIAMoDRIWCg5tYXplX2J1" + "ZmZfbGlzdBgKIAMoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CellMonsterSelectInfo), CellMonsterSelectInfo.Parser, new string[]
			{
				"SelectDecayId",
				"MazeBuffList"
			}, null, null, null, null)
		}));
	}
}
