using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C63 RID: 3171
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OMPDJIJNNBP : IMessage<OMPDJIJNNBP>, IMessage, IEquatable<OMPDJIJNNBP>, IDeepCloneable<OMPDJIJNNBP>, IBufferMessage
	{
		// Token: 0x17002792 RID: 10130
		// (get) Token: 0x06008CDD RID: 36061 RVA: 0x001745F4 File Offset: 0x001727F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OMPDJIJNNBP> Parser
		{
			get
			{
				return OMPDJIJNNBP._parser;
			}
		}

		// Token: 0x17002793 RID: 10131
		// (get) Token: 0x06008CDE RID: 36062 RVA: 0x001745FB File Offset: 0x001727FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OMPDJIJNNBPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002794 RID: 10132
		// (get) Token: 0x06008CDF RID: 36063 RVA: 0x0017460D File Offset: 0x0017280D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OMPDJIJNNBP.Descriptor;
			}
		}

		// Token: 0x06008CE0 RID: 36064 RVA: 0x00174614 File Offset: 0x00172814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OMPDJIJNNBP()
		{
		}

		// Token: 0x06008CE1 RID: 36065 RVA: 0x0017461C File Offset: 0x0017281C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OMPDJIJNNBP(OMPDJIJNNBP other) : this()
		{
			this.level_ = other.level_;
			this.rewardDisplayType_ = other.rewardDisplayType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CE2 RID: 36066 RVA: 0x0017464D File Offset: 0x0017284D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OMPDJIJNNBP Clone()
		{
			return new OMPDJIJNNBP(this);
		}

		// Token: 0x17002795 RID: 10133
		// (get) Token: 0x06008CE3 RID: 36067 RVA: 0x00174655 File Offset: 0x00172855
		// (set) Token: 0x06008CE4 RID: 36068 RVA: 0x0017465D File Offset: 0x0017285D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17002796 RID: 10134
		// (get) Token: 0x06008CE5 RID: 36069 RVA: 0x00174666 File Offset: 0x00172866
		// (set) Token: 0x06008CE6 RID: 36070 RVA: 0x0017466E File Offset: 0x0017286E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RewardDisplayType
		{
			get
			{
				return this.rewardDisplayType_;
			}
			set
			{
				this.rewardDisplayType_ = value;
			}
		}

		// Token: 0x06008CE7 RID: 36071 RVA: 0x00174677 File Offset: 0x00172877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OMPDJIJNNBP);
		}

		// Token: 0x06008CE8 RID: 36072 RVA: 0x00174685 File Offset: 0x00172885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OMPDJIJNNBP other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.RewardDisplayType == other.RewardDisplayType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008CE9 RID: 36073 RVA: 0x001746C4 File Offset: 0x001728C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.RewardDisplayType != 0U)
			{
				num ^= this.RewardDisplayType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008CEA RID: 36074 RVA: 0x0017471C File Offset: 0x0017291C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008CEB RID: 36075 RVA: 0x00174724 File Offset: 0x00172924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CEC RID: 36076 RVA: 0x00174730 File Offset: 0x00172930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardDisplayType != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RewardDisplayType);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CED RID: 36077 RVA: 0x00174788 File Offset: 0x00172988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.RewardDisplayType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RewardDisplayType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008CEE RID: 36078 RVA: 0x001747E0 File Offset: 0x001729E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OMPDJIJNNBP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.RewardDisplayType != 0U)
			{
				this.RewardDisplayType = other.RewardDisplayType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008CEF RID: 36079 RVA: 0x00174830 File Offset: 0x00172A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008CF0 RID: 36080 RVA: 0x0017483C File Offset: 0x00172A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Level = input.ReadUInt32();
					}
				}
				else
				{
					this.RewardDisplayType = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400361B RID: 13851
		private static readonly MessageParser<OMPDJIJNNBP> _parser = new MessageParser<OMPDJIJNNBP>(() => new OMPDJIJNNBP());

		// Token: 0x0400361C RID: 13852
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400361D RID: 13853
		public const int LevelFieldNumber = 9;

		// Token: 0x0400361E RID: 13854
		private uint level_;

		// Token: 0x0400361F RID: 13855
		public const int RewardDisplayTypeFieldNumber = 1;

		// Token: 0x04003620 RID: 13856
		private uint rewardDisplayType_;
	}
}
