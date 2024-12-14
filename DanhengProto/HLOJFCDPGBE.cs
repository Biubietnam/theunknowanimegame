using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008F9 RID: 2297
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HLOJFCDPGBE : IMessage<HLOJFCDPGBE>, IMessage, IEquatable<HLOJFCDPGBE>, IDeepCloneable<HLOJFCDPGBE>, IBufferMessage
	{
		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x06006677 RID: 26231 RVA: 0x00111CE7 File Offset: 0x0010FEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HLOJFCDPGBE> Parser
		{
			get
			{
				return HLOJFCDPGBE._parser;
			}
		}

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x06006678 RID: 26232 RVA: 0x00111CEE File Offset: 0x0010FEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HLOJFCDPGBEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x06006679 RID: 26233 RVA: 0x00111D00 File Offset: 0x0010FF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HLOJFCDPGBE.Descriptor;
			}
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x00111D07 File Offset: 0x0010FF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HLOJFCDPGBE()
		{
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x00111D10 File Offset: 0x0010FF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HLOJFCDPGBE(HLOJFCDPGBE other) : this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this.spBar_ = ((other.spBar_ != null) ? other.spBar_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x00111D68 File Offset: 0x0010FF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HLOJFCDPGBE Clone()
		{
			return new HLOJFCDPGBE(this);
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x0600667D RID: 26237 RVA: 0x00111D70 File Offset: 0x0010FF70
		// (set) Token: 0x0600667E RID: 26238 RVA: 0x00111D78 File Offset: 0x0010FF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherdivideSpiritLineupType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x0600667F RID: 26239 RVA: 0x00111D81 File Offset: 0x0010FF81
		// (set) Token: 0x06006680 RID: 26240 RVA: 0x00111D89 File Offset: 0x0010FF89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06006681 RID: 26241 RVA: 0x00111D92 File Offset: 0x0010FF92
		// (set) Token: 0x06006682 RID: 26242 RVA: 0x00111D9A File Offset: 0x0010FF9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpBarInfo SpBar
		{
			get
			{
				return this.spBar_;
			}
			set
			{
				this.spBar_ = value;
			}
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x00111DA3 File Offset: 0x0010FFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HLOJFCDPGBE);
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x00111DB4 File Offset: 0x0010FFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HLOJFCDPGBE other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && object.Equals(this.SpBar, other.SpBar) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x00111E14 File Offset: 0x00110014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != AetherdivideSpiritLineupType.AetherdivideSpiritLineupNone)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.spBar_ != null)
			{
				num ^= this.SpBar.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x00111E88 File Offset: 0x00110088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x00111E90 File Offset: 0x00110090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x00111E9C File Offset: 0x0011009C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != AetherdivideSpiritLineupType.AetherdivideSpiritLineupNone)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Id);
			}
			if (this.spBar_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SpBar);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006689 RID: 26249 RVA: 0x00111F10 File Offset: 0x00110110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != AetherdivideSpiritLineupType.AetherdivideSpiritLineupNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.spBar_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpBar);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600668A RID: 26250 RVA: 0x00111F80 File Offset: 0x00110180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HLOJFCDPGBE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != AetherdivideSpiritLineupType.AetherdivideSpiritLineupNone)
			{
				this.Type = other.Type;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.spBar_ != null)
			{
				if (this.spBar_ == null)
				{
					this.SpBar = new SpBarInfo();
				}
				this.SpBar.MergeFrom(other.SpBar);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x00111FFC File Offset: 0x001101FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600668C RID: 26252 RVA: 0x00112008 File Offset: 0x00110208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.spBar_ == null)
							{
								this.SpBar = new SpBarInfo();
							}
							input.ReadMessage(this.SpBar);
						}
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.Type = (AetherdivideSpiritLineupType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002762 RID: 10082
		private static readonly MessageParser<HLOJFCDPGBE> _parser = new MessageParser<HLOJFCDPGBE>(() => new HLOJFCDPGBE());

		// Token: 0x04002763 RID: 10083
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002764 RID: 10084
		public const int TypeFieldNumber = 1;

		// Token: 0x04002765 RID: 10085
		private AetherdivideSpiritLineupType type_;

		// Token: 0x04002766 RID: 10086
		public const int IdFieldNumber = 2;

		// Token: 0x04002767 RID: 10087
		private uint id_;

		// Token: 0x04002768 RID: 10088
		public const int SpBarFieldNumber = 3;

		// Token: 0x04002769 RID: 10089
		private SpBarInfo spBar_;
	}
}
