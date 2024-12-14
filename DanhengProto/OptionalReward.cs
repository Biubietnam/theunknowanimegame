using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C79 RID: 3193
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OptionalReward : IMessage<OptionalReward>, IMessage, IEquatable<OptionalReward>, IDeepCloneable<OptionalReward>, IBufferMessage
	{
		// Token: 0x170027DC RID: 10204
		// (get) Token: 0x06008DE8 RID: 36328 RVA: 0x00177008 File Offset: 0x00175208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OptionalReward> Parser
		{
			get
			{
				return OptionalReward._parser;
			}
		}

		// Token: 0x170027DD RID: 10205
		// (get) Token: 0x06008DE9 RID: 36329 RVA: 0x0017700F File Offset: 0x0017520F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OptionalRewardReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027DE RID: 10206
		// (get) Token: 0x06008DEA RID: 36330 RVA: 0x00177021 File Offset: 0x00175221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OptionalReward.Descriptor;
			}
		}

		// Token: 0x06008DEB RID: 36331 RVA: 0x00177028 File Offset: 0x00175228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OptionalReward()
		{
		}

		// Token: 0x06008DEC RID: 36332 RVA: 0x00177030 File Offset: 0x00175230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OptionalReward(OptionalReward other) : this()
		{
			this.optionalRewardId_ = other.optionalRewardId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DED RID: 36333 RVA: 0x00177061 File Offset: 0x00175261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OptionalReward Clone()
		{
			return new OptionalReward(this);
		}

		// Token: 0x170027DF RID: 10207
		// (get) Token: 0x06008DEE RID: 36334 RVA: 0x00177069 File Offset: 0x00175269
		// (set) Token: 0x06008DEF RID: 36335 RVA: 0x00177071 File Offset: 0x00175271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OptionalRewardId
		{
			get
			{
				return this.optionalRewardId_;
			}
			set
			{
				this.optionalRewardId_ = value;
			}
		}

		// Token: 0x170027E0 RID: 10208
		// (get) Token: 0x06008DF0 RID: 36336 RVA: 0x0017707A File Offset: 0x0017527A
		// (set) Token: 0x06008DF1 RID: 36337 RVA: 0x00177082 File Offset: 0x00175282
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

		// Token: 0x06008DF2 RID: 36338 RVA: 0x0017708B File Offset: 0x0017528B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OptionalReward);
		}

		// Token: 0x06008DF3 RID: 36339 RVA: 0x00177099 File Offset: 0x00175299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OptionalReward other)
		{
			return other != null && (other == this || (this.OptionalRewardId == other.OptionalRewardId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008DF4 RID: 36340 RVA: 0x001770D8 File Offset: 0x001752D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OptionalRewardId != 0U)
			{
				num ^= this.OptionalRewardId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008DF5 RID: 36341 RVA: 0x00177130 File Offset: 0x00175330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008DF6 RID: 36342 RVA: 0x00177138 File Offset: 0x00175338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DF7 RID: 36343 RVA: 0x00177144 File Offset: 0x00175344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionalRewardId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.OptionalRewardId);
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

		// Token: 0x06008DF8 RID: 36344 RVA: 0x001771A0 File Offset: 0x001753A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OptionalRewardId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OptionalRewardId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DF9 RID: 36345 RVA: 0x001771F8 File Offset: 0x001753F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OptionalReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OptionalRewardId != 0U)
			{
				this.OptionalRewardId = other.OptionalRewardId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008DFA RID: 36346 RVA: 0x00177248 File Offset: 0x00175448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DFB RID: 36347 RVA: 0x00177254 File Offset: 0x00175454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
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
					this.OptionalRewardId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400367A RID: 13946
		private static readonly MessageParser<OptionalReward> _parser = new MessageParser<OptionalReward>(() => new OptionalReward());

		// Token: 0x0400367B RID: 13947
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400367C RID: 13948
		public const int OptionalRewardIdFieldNumber = 8;

		// Token: 0x0400367D RID: 13949
		private uint optionalRewardId_;

		// Token: 0x0400367E RID: 13950
		public const int LevelFieldNumber = 9;

		// Token: 0x0400367F RID: 13951
		private uint level_;
	}
}
