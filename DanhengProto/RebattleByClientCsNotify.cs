using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D7F RID: 3455
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RebattleByClientCsNotify : IMessage<RebattleByClientCsNotify>, IMessage, IEquatable<RebattleByClientCsNotify>, IDeepCloneable<RebattleByClientCsNotify>, IBufferMessage
	{
		// Token: 0x17002B8B RID: 11147
		// (get) Token: 0x06009A57 RID: 39511 RVA: 0x0019AC87 File Offset: 0x00198E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RebattleByClientCsNotify> Parser
		{
			get
			{
				return RebattleByClientCsNotify._parser;
			}
		}

		// Token: 0x17002B8C RID: 11148
		// (get) Token: 0x06009A58 RID: 39512 RVA: 0x0019AC8E File Offset: 0x00198E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RebattleByClientCsNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B8D RID: 11149
		// (get) Token: 0x06009A59 RID: 39513 RVA: 0x0019ACA0 File Offset: 0x00198EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RebattleByClientCsNotify.Descriptor;
			}
		}

		// Token: 0x06009A5A RID: 39514 RVA: 0x0019ACA7 File Offset: 0x00198EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RebattleByClientCsNotify()
		{
		}

		// Token: 0x06009A5B RID: 39515 RVA: 0x0019ACB0 File Offset: 0x00198EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RebattleByClientCsNotify(RebattleByClientCsNotify other) : this()
		{
			this.rebattleType_ = other.rebattleType_;
			this.stt_ = ((other.stt_ != null) ? other.stt_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A5C RID: 39516 RVA: 0x0019ACFC File Offset: 0x00198EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RebattleByClientCsNotify Clone()
		{
			return new RebattleByClientCsNotify(this);
		}

		// Token: 0x17002B8E RID: 11150
		// (get) Token: 0x06009A5D RID: 39517 RVA: 0x0019AD04 File Offset: 0x00198F04
		// (set) Token: 0x06009A5E RID: 39518 RVA: 0x0019AD0C File Offset: 0x00198F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RebattleType RebattleType
		{
			get
			{
				return this.rebattleType_;
			}
			set
			{
				this.rebattleType_ = value;
			}
		}

		// Token: 0x17002B8F RID: 11151
		// (get) Token: 0x06009A5F RID: 39519 RVA: 0x0019AD15 File Offset: 0x00198F15
		// (set) Token: 0x06009A60 RID: 39520 RVA: 0x0019AD1D File Offset: 0x00198F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStatistics Stt
		{
			get
			{
				return this.stt_;
			}
			set
			{
				this.stt_ = value;
			}
		}

		// Token: 0x06009A61 RID: 39521 RVA: 0x0019AD26 File Offset: 0x00198F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RebattleByClientCsNotify);
		}

		// Token: 0x06009A62 RID: 39522 RVA: 0x0019AD34 File Offset: 0x00198F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RebattleByClientCsNotify other)
		{
			return other != null && (other == this || (this.RebattleType == other.RebattleType && object.Equals(this.Stt, other.Stt) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A63 RID: 39523 RVA: 0x0019AD84 File Offset: 0x00198F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RebattleType != RebattleType.None)
			{
				num ^= this.RebattleType.GetHashCode();
			}
			if (this.stt_ != null)
			{
				num ^= this.Stt.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A64 RID: 39524 RVA: 0x0019ADDF File Offset: 0x00198FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009A65 RID: 39525 RVA: 0x0019ADE7 File Offset: 0x00198FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A66 RID: 39526 RVA: 0x0019ADF0 File Offset: 0x00198FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RebattleType != RebattleType.None)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.RebattleType);
			}
			if (this.stt_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Stt);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A67 RID: 39527 RVA: 0x0019AE4C File Offset: 0x0019904C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RebattleType != RebattleType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RebattleType);
			}
			if (this.stt_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Stt);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A68 RID: 39528 RVA: 0x0019AEA4 File Offset: 0x001990A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RebattleByClientCsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RebattleType != RebattleType.None)
			{
				this.RebattleType = other.RebattleType;
			}
			if (other.stt_ != null)
			{
				if (this.stt_ == null)
				{
					this.Stt = new BattleStatistics();
				}
				this.Stt.MergeFrom(other.Stt);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009A69 RID: 39529 RVA: 0x0019AF0C File Offset: 0x0019910C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A6A RID: 39530 RVA: 0x0019AF18 File Offset: 0x00199118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.stt_ == null)
						{
							this.Stt = new BattleStatistics();
						}
						input.ReadMessage(this.Stt);
					}
				}
				else
				{
					this.RebattleType = (RebattleType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003BE8 RID: 15336
		private static readonly MessageParser<RebattleByClientCsNotify> _parser = new MessageParser<RebattleByClientCsNotify>(() => new RebattleByClientCsNotify());

		// Token: 0x04003BE9 RID: 15337
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BEA RID: 15338
		public const int RebattleTypeFieldNumber = 5;

		// Token: 0x04003BEB RID: 15339
		private RebattleType rebattleType_;

		// Token: 0x04003BEC RID: 15340
		public const int SttFieldNumber = 7;

		// Token: 0x04003BED RID: 15341
		private BattleStatistics stt_;
	}
}
