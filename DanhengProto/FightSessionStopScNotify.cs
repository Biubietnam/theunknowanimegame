using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000559 RID: 1369
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightSessionStopScNotify : IMessage<FightSessionStopScNotify>, IMessage, IEquatable<FightSessionStopScNotify>, IDeepCloneable<FightSessionStopScNotify>, IBufferMessage
	{
		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06003D08 RID: 15624 RVA: 0x000A73C5 File Offset: 0x000A55C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightSessionStopScNotify> Parser
		{
			get
			{
				return FightSessionStopScNotify._parser;
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06003D09 RID: 15625 RVA: 0x000A73CC File Offset: 0x000A55CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightSessionStopScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06003D0A RID: 15626 RVA: 0x000A73DE File Offset: 0x000A55DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightSessionStopScNotify.Descriptor;
			}
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x000A73E5 File Offset: 0x000A55E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightSessionStopScNotify()
		{
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x000A73ED File Offset: 0x000A55ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightSessionStopScNotify(FightSessionStopScNotify other) : this()
		{
			this.bANNAKDNBFA_ = ((other.bANNAKDNBFA_ != null) ? other.bANNAKDNBFA_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x000A7422 File Offset: 0x000A5622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightSessionStopScNotify Clone()
		{
			return new FightSessionStopScNotify(this);
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06003D0E RID: 15630 RVA: 0x000A742A File Offset: 0x000A562A
		// (set) Token: 0x06003D0F RID: 15631 RVA: 0x000A7432 File Offset: 0x000A5632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EDDPABIGHBE BANNAKDNBFA
		{
			get
			{
				return this.bANNAKDNBFA_;
			}
			set
			{
				this.bANNAKDNBFA_ = value;
			}
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x000A743B File Offset: 0x000A563B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightSessionStopScNotify);
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x000A7449 File Offset: 0x000A5649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightSessionStopScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.BANNAKDNBFA, other.BANNAKDNBFA) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x000A747C File Offset: 0x000A567C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.bANNAKDNBFA_ != null)
			{
				num ^= this.BANNAKDNBFA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x000A74B8 File Offset: 0x000A56B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x000A74C0 File Offset: 0x000A56C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D15 RID: 15637 RVA: 0x000A74C9 File Offset: 0x000A56C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.bANNAKDNBFA_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.BANNAKDNBFA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D16 RID: 15638 RVA: 0x000A74FC File Offset: 0x000A56FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.bANNAKDNBFA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BANNAKDNBFA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x000A753C File Offset: 0x000A573C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightSessionStopScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.bANNAKDNBFA_ != null)
			{
				if (this.bANNAKDNBFA_ == null)
				{
					this.BANNAKDNBFA = new EDDPABIGHBE();
				}
				this.BANNAKDNBFA.MergeFrom(other.BANNAKDNBFA);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x000A7590 File Offset: 0x000A5790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x000A759C File Offset: 0x000A579C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.bANNAKDNBFA_ == null)
					{
						this.BANNAKDNBFA = new EDDPABIGHBE();
					}
					input.ReadMessage(this.BANNAKDNBFA);
				}
			}
		}

		// Token: 0x04001875 RID: 6261
		private static readonly MessageParser<FightSessionStopScNotify> _parser = new MessageParser<FightSessionStopScNotify>(() => new FightSessionStopScNotify());

		// Token: 0x04001876 RID: 6262
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001877 RID: 6263
		public const int BANNAKDNBFAFieldNumber = 11;

		// Token: 0x04001878 RID: 6264
		private EDDPABIGHBE bANNAKDNBFA_;
	}
}
