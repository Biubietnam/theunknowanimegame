using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001F5 RID: 501
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueChangeyAeonDimensionNotify : IMessage<ChessRogueChangeyAeonDimensionNotify>, IMessage, IEquatable<ChessRogueChangeyAeonDimensionNotify>, IDeepCloneable<ChessRogueChangeyAeonDimensionNotify>, IBufferMessage
	{
		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x00040347 File Offset: 0x0003E547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueChangeyAeonDimensionNotify> Parser
		{
			get
			{
				return ChessRogueChangeyAeonDimensionNotify._parser;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x0004034E File Offset: 0x0003E54E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueChangeyAeonDimensionNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x00040360 File Offset: 0x0003E560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueChangeyAeonDimensionNotify.Descriptor;
			}
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00040367 File Offset: 0x0003E567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueChangeyAeonDimensionNotify()
		{
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0004036F File Offset: 0x0003E56F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueChangeyAeonDimensionNotify(ChessRogueChangeyAeonDimensionNotify other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x000403A4 File Offset: 0x0003E5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueChangeyAeonDimensionNotify Clone()
		{
			return new ChessRogueChangeyAeonDimensionNotify(this);
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x000403AC File Offset: 0x0003E5AC
		// (set) Token: 0x06001655 RID: 5717 RVA: 0x000403B4 File Offset: 0x0003E5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeon Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x000403BD File Offset: 0x0003E5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueChangeyAeonDimensionNotify);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x000403CB File Offset: 0x0003E5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueChangeyAeonDimensionNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00040400 File Offset: 0x0003E600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x0004043C File Offset: 0x0003E63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00040444 File Offset: 0x0003E644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0004044D File Offset: 0x0003E64D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00040480 File Offset: 0x0003E680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x000404C0 File Offset: 0x0003E6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueChangeyAeonDimensionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new ChessRogueQueryAeon();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00040514 File Offset: 0x0003E714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00040520 File Offset: 0x0003E720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new ChessRogueQueryAeon();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04000978 RID: 2424
		private static readonly MessageParser<ChessRogueChangeyAeonDimensionNotify> _parser = new MessageParser<ChessRogueChangeyAeonDimensionNotify>(() => new ChessRogueChangeyAeonDimensionNotify());

		// Token: 0x04000979 RID: 2425
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400097A RID: 2426
		public const int InfoFieldNumber = 14;

		// Token: 0x0400097B RID: 2427
		private ChessRogueQueryAeon info_;
	}
}
