using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000FB RID: 251
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleRogueMagicModifierInfo : IMessage<BattleRogueMagicModifierInfo>, IMessage, IEquatable<BattleRogueMagicModifierInfo>, IDeepCloneable<BattleRogueMagicModifierInfo>, IBufferMessage
	{
		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x00021369 File Offset: 0x0001F569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleRogueMagicModifierInfo> Parser
		{
			get
			{
				return BattleRogueMagicModifierInfo._parser;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x00021370 File Offset: 0x0001F570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleRogueMagicModifierInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x00021382 File Offset: 0x0001F582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleRogueMagicModifierInfo.Descriptor;
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00021389 File Offset: 0x0001F589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicModifierInfo()
		{
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00021391 File Offset: 0x0001F591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicModifierInfo(BattleRogueMagicModifierInfo other) : this()
		{
			this.rogueMagicBattleConst_ = other.rogueMagicBattleConst_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x000213B6 File Offset: 0x0001F5B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicModifierInfo Clone()
		{
			return new BattleRogueMagicModifierInfo(this);
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x000213BE File Offset: 0x0001F5BE
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x000213C6 File Offset: 0x0001F5C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RogueMagicBattleConst
		{
			get
			{
				return this.rogueMagicBattleConst_;
			}
			set
			{
				this.rogueMagicBattleConst_ = value;
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x000213CF File Offset: 0x0001F5CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleRogueMagicModifierInfo);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x000213DD File Offset: 0x0001F5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleRogueMagicModifierInfo other)
		{
			return other != null && (other == this || (this.RogueMagicBattleConst == other.RogueMagicBattleConst && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0002140C File Offset: 0x0001F60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RogueMagicBattleConst != 0U)
			{
				num ^= this.RogueMagicBattleConst.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0002144B File Offset: 0x0001F64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00021453 File Offset: 0x0001F653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0002145C File Offset: 0x0001F65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RogueMagicBattleConst != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RogueMagicBattleConst);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00021490 File Offset: 0x0001F690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RogueMagicBattleConst != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueMagicBattleConst);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x000214CE File Offset: 0x0001F6CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleRogueMagicModifierInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RogueMagicBattleConst != 0U)
			{
				this.RogueMagicBattleConst = other.RogueMagicBattleConst;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x000214FF File Offset: 0x0001F6FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00021508 File Offset: 0x0001F708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RogueMagicBattleConst = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040004B7 RID: 1207
		private static readonly MessageParser<BattleRogueMagicModifierInfo> _parser = new MessageParser<BattleRogueMagicModifierInfo>(() => new BattleRogueMagicModifierInfo());

		// Token: 0x040004B8 RID: 1208
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004B9 RID: 1209
		public const int RogueMagicBattleConstFieldNumber = 1;

		// Token: 0x040004BA RID: 1210
		private uint rogueMagicBattleConst_;
	}
}
